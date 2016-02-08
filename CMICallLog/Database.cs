using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

//\\192.168.100.243\operations\is\cmicalllog\CmiCallLogDB.sqlite

namespace CMICallLog
{
    public class Database
    {
        private SQLiteConnection db;
        private static string connectionString = "Data Source=CmiCallLogDB.sqlite;Version=3;Timeout=3;";
        public static string dbVersion = "1.2.0.2";
        public const string dateFormat = "yyyy-MM-dd HH:mm:ss";

        public Database()
        {
            while (!DatabaseExists())
            {
                //MessageBox.Show("Test");
                ChooseDbLocation frm = new ChooseDbLocation();
                System.Windows.Forms.DialogResult result = frm.ShowDialog();
                Program.LoadDbLocation();
                if (result == System.Windows.Forms.DialogResult.Cancel && !DatabaseExists())
                    Program.ExitApp();
            }
            try
            {
                connectionString = @"Data Source=" + Program.DbLocation + ";Version=3;";
                this.db = new SQLiteConnection(Database.connectionString,true);
                dbVersion = GetDatabaseVersion();
                //System.Windows.Forms.MessageBox.Show(Program.updater.CheckHigherVersion(dbVersion).ToString());
                if (Program.dbUpdater.CheckHigherVersion(dbVersion))
                {
                    System.Windows.Forms.MessageBox.Show("Newer database version found. Update will now run.");
                    Program.dbUpdater.UpdateDatabase(this, dbVersion);
                }
            }
            catch(SQLiteException e)
            {
                System.Windows.Forms.MessageBox.Show("Could not open database: " + e.ToString());
                Program.ExitApp();
            }
        }

        private void Open()
        {
            if (this.db.State != ConnectionState.Open)
            {
                try
                {
                    this.db.Open();
                    Program.Log.Info("Opening database");
                }
                catch (SQLiteException e)
                {
                    string err = "Error opening SQLite database.\n" + e.ToString();
                    System.Windows.Forms.MessageBox.Show(err);
                    Program.Log.Error(err);
                    Program.ExitApp();
                }
            }
        }

        public void Close()
        {
            if (this.db.State != ConnectionState.Closed)
            {
                this.db.Close();
                Program.Log.Info("Closing database");
            }
        }

        private bool DatabaseExists()
        {
            string dbFile = Program.DbLocation;
            if (dbFile == "" || !System.IO.File.Exists(dbFile))
            {
                return false;
            }

            return true;
        }

        public static void SetupNewDatabase(string path)
        {
            Program.Log.Info("Creating new database: " + path);
            SQLiteConnection.CreateFile(path);
            string conString = @"Data Source = " + path + "; Version = 3;";
            SQLiteConnection con = new SQLiteConnection(conString, true);
            CreateTables(con);
        }

        private static void CreateTables(SQLiteConnection con)
        {
            con.Open();

            string sql = @"CREATE TABLE `settings` (
	                        `id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                        `key`	TEXT NOT NULL UNIQUE,
	                        `value`	TEXT
                        );";
            SQLiteCommand com = new SQLiteCommand(con);
            com.CommandText = sql ;
            com.ExecuteNonQuery();

            sql = @"CREATE TABLE `tickets` (
	                `id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                `ticketNumber`	INTEGER NOT NULL,
	                `dateCreated`	TEXT,
	                `timeCreated`	TEXT,
	                `contactType`	TEXT,
	                `createdBy`	TEXT,
	                `storeNumber`	TEXT,
	                `issueType`	TEXT,
	                `status`	TEXT,
	                `priority`	VARCHAR(25) DEFAULT 'Normal',
	                `description`	TEXT,
	                `dateCompleted`	TEXT,
	                `completedBy`	TEXT,
	                `solution`	TEXT
                );";
            com.CommandText = sql;
            com.ExecuteNonQuery();

            sql  = @"CREATE TABLE `attached_files` (
	                `id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                `ticketNumber`	INTEGER NOT NULL,
	                `filePath`	TEXT NOT NULL
                );";
            com.CommandText = sql;
            com.ExecuteNonQuery();

            com.CommandText = @"insert into settings(`key`, `value`) values ('ticketNumber', '1')";
            com.ExecuteNonQuery();

            com.CommandText = String.Format(@"insert into settings(`key`, `value`) values ('dbVersion', '{0}')", dbVersion);
            com.ExecuteNonQuery();

            con.Close();
        }

        private string GetDatabaseVersion()
        {
            this.Open();

            //String sql = String.Format("select ticketNumber, dateCreated, timeCreated, contactType, createdBy, " +
            //    "storeNumber, issueType, status, priority, description, dateCompleted, completedBy, solution from tickets where id={0}", id);
            string sql = @"select value from settings where key='dbVersion'";

            SQLiteCommand com = new SQLiteCommand(sql, this.db);
            SQLiteDataReader reader = com.ExecuteReader();
            if (!reader.HasRows)
                return "1.0.0.0";
            reader.Read();
            return reader[0].ToString();
        }

        private SQLiteCommand BuildInsertQuery(String table, Dictionary<string, string> data)
        {
            this.Open();
            SQLiteCommand cmd = new SQLiteCommand(this.db);

            string columns = "";
            string values = "";

            foreach (KeyValuePair<String, String> val in data)
            {
                columns += String.Format(" {0},", val.Key);
                values += String.Format(" {0},", "@" + val.Key);
                cmd.Parameters.Add(new SQLiteParameter("@" + val.Key, val.Value));
            }
            columns = columns.Substring(0, columns.Length - 1);
            values = values.Substring(0, values.Length - 1);

            cmd.CommandText = String.Format("insert into {0}({1}) values ({2})", table, columns, values);
            return cmd;
        }

        private SQLiteCommand BuildUpdateQuery(string table, Dictionary<string, string> data, string where)
        {
            this.Open();
            SQLiteCommand cmd = this.db.CreateCommand();
            string updates = "";

            foreach (KeyValuePair<String, String> val in data)
            {
                updates += String.Format(" {0}={1},", val.Key, "@"+val.Key);
                cmd.Parameters.Add(new SQLiteParameter("@"+val.Key, val.Value));
            }
            updates = updates.Substring(0, updates.Length - 1);

            cmd.CommandText = String.Format("update {0} set {1} where {2}", table, updates, where);
            cmd.CommandType = CommandType.Text;
            return cmd;
        }

        public void RunUpdateFile(string path)
        {
            this.Open();
            string sql = "";
            using (System.IO.StreamReader sf = new System.IO.StreamReader(path))
            {
                sql = sf.ReadToEnd();
            }
            SQLiteCommand com = new SQLiteCommand(sql, this.db);
            com.ExecuteNonQuery();
        }

        public List<string> GetStoreList()
        {
            Program.Log.Info("Database.GetStoreList()");
            this.Open();
            List<string> storeList = new List<string>(200);
            string sql = "select storeNumber from stores";
            SQLiteCommand cmd = new SQLiteCommand(sql, this.db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                storeList.Add(reader["storeNumber"].ToString());
            }
            return storeList;
        }

        public DataSet GetOpenIncidents(FilterState state, string storeFilter = null)
        {
            Program.Log.Info("Database.GetOpenIncidents()");
            this.Open();
            string sql = "select * from incidents where lower(status) != 'closed' {0}";
            if (storeFilter == null)
            {
                sql = String.Format(sql, "{0} order by storeNumber");
                
            }
            else
            {
                sql = String.Format(sql, "and storeNumber={0}");
                sql = String.Format(sql, storeFilter);
                sql += " {0}";
            }
            if (state.ShowAdditionalFilters == false)
                sql = String.Format(sql, "and lower(status)!='level 3' and lower(status)!='level 4'");
            else
                sql = String.Format(sql, "");
            SQLiteDataAdapter adap = new SQLiteDataAdapter(sql, this.db);
            DataSet ds = new DataSet();
            adap.Fill(ds, "incidents");

            return ds;
        }

        public DataSet GetClosedIncidents(FilterState state, string storeFilter = null)
        {
            Program.Log.Info("Database.GetClosedIncidents()");
            this.Open();
            string sql = "select * from incidents where lower(status) = 'closed' {0}";
            if (storeFilter == null)
            {
                sql = String.Format(sql, "{0} order by storeNumber");

            }
            else
            {
                sql = String.Format(sql, "and storeNumber={0}");
                sql = String.Format(sql, storeFilter);
                sql += " {0}";
            }
            if (state.ShowAdditionalFilters == false)
                sql = String.Format(sql, "and lower(status)!='level 3' and lower(status)!='level 4'");
            else
                sql = String.Format(sql, "");
            SQLiteDataAdapter adap = new SQLiteDataAdapter(sql, this.db);
            DataSet ds = new DataSet();
            adap.Fill(ds, "incidents");

            return ds;
        }

        public Incident GetIncidentDetails(string incidentNumber)
        {
            Program.Log.Info("Database.GetIncidentDetails(" + incidentNumber + ")");
            this.Open();

            String sql = String.Format("select * from incidents where incidentNumber={0}", incidentNumber);
            
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, this.db);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Incident incident = new Incident();
            if (table.Rows.Count > 0)
                incident = new Incident(table.Rows[0]);

            return incident;
        }

        public void CreateIncident(Incident incident)
        {
            this.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from incidents where 1 = 0", this.db);

            SQLiteCommandBuilder cmdb = new SQLiteCommandBuilder(adapter);
            cmdb.GetInsertCommand();
            DataTable incidents = new DataTable();
            adapter.Fill(incidents);
            incident.AddToDataTable(incidents);
            incidents.Rows[0].SetField<string>(0, null);
            adapter.Update(incidents);

            incident.IncidentNumber = (int)this.db.LastInsertRowId;

            Program.Log.Info("Database.CreateIncident(" + incident.IncidentNumber + ")");
        }

        public void UpdateIncident(Incident incident)
        {
            this.Open();

            string sql = String.Format("select * from incidents where incidentNumber={0}", incident.IncidentNumber);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, this.db);
            SQLiteCommandBuilder cmdb = new SQLiteCommandBuilder(adapter);
            cmdb.GetInsertCommand();
            DataTable table = new DataTable();
            adapter.Fill(table);
            table.Rows[0].Delete();
            incident.AddToDataTable(table);
            adapter.Update(table);


            Program.Log.Info("Database.UpdateIncident(" + incident.IncidentNumber + ")");
        }

        public void DeleteIncident(string incidentNumber)
        {
            this.Open();

            string sql = String.Format("select * from incidents where incidentNumber={0}", incidentNumber);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, this.db);
            SQLiteCommandBuilder cmdb = new SQLiteCommandBuilder(adapter);
            cmdb.GetInsertCommand();
            DataTable table = new DataTable();
            adapter.Fill(table);
            table.Rows[0].Delete();
            adapter.Update(table);


            Program.Log.Info("Database.DeleteIncident(" + incidentNumber + ")");
        }

        // Updates table

        public List<Update> GetUpdatesForIncident(Incident incident)
        {
            this.Open();
            List<Update> updates = new List<Update>();

            string sql = string.Format("select * from updates where incident={0}", incident.IncidentNumber);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, this.db);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach(DataRow row in table.Rows)
            {
                updates.Add(new Update(row, incident));
            }

            Program.Log.Info("Database.GetUpdatesForIncident(" + incident.IncidentNumber + ")");

            return updates;
        }

        public string GetLatestUpdateForIncident(Incident incident)
        {
            Program.Log.Info("Database.GetLatestUpdateForIncident(" + incident.IncidentNumber + ")");

            this.Open();
            List<Update> updates = new List<Update>();

            string sql = string.Format("select * from updates where incident={0} order by updateNumber desc limit 1", incident.IncidentNumber);

            SQLiteDataAdapter adpt = new SQLiteDataAdapter(sql, this.db);
            DataTable table = new DataTable();
            adpt.Fill(table);
            if (table.Rows.Count > 0)
            {
                Update upd = new Update(table.Rows[0], incident);
                string ret = upd.StartDateTime.ToString("MM/dd");
                ret += " - " + upd.UpdateBy + " - " + upd.Description;
                return ret;
            }
            else
                return "";
        }

        public Dictionary<string, string> GetLatestUpdatesForOpenIncidents()
        {
            Program.Log.Info("Database.GetLatestUpdatesForOpenIncidents()");

            this.Open();
            Dictionary<string, string> descriptions = new Dictionary<string, string>();

            string sql = @"select incidentNumber, u1.description from incidents
                join updates u1
                on incidents.incidentNumber = u1.incident
                and not exists(
                    select 1 from updates u2

                    where u2.incident = incidents.incidentNumber

                    and u2.updateNumber > u1.updateNumber
                    )
                where lower(incidents.status) != 'closed'
                group by incidentNumber";

            SQLiteCommand cmd = new SQLiteCommand(sql, this.db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                descriptions.Add(reader[0].ToString(), reader[1].ToString());
            }
            return descriptions;
        }

        public Update GetUpdateDetails(string updateNumber, Incident incident)
        {
            Program.Log.Info("Database.GetUpdateDetails(" + updateNumber + ")");

            this.Open();

            String sql = String.Format("select * from updates where updateNumber={0}", updateNumber);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, this.db);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Update update = new Update(incident);
            if (table.Rows.Count > 0)
            {
                update = new Update(table.Rows[0], incident);
            }

            return update;
        }

        public void CreateUpdate(Update update)
        {
            this.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from updates where 1 = 0", this.db);

            SQLiteCommandBuilder cmdb = new SQLiteCommandBuilder(adapter);
            cmdb.GetInsertCommand();
            DataTable table = new DataTable();
            adapter.Fill(table);
            update.AddToDataTable(table);
            table.Rows[0].SetField<string>(0, null);
            adapter.Update(table);

            update.UpdateNumber = (int)this.db.LastInsertRowId;

            Program.Log.Info("Database.CreateUpdate("+update.UpdateNumber+")");
        }

        public void UpdateUpdate(Update update)
        {
            this.Open();

            string sql = String.Format("select * from updates where updateNumber={0}", update.UpdateNumber);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, this.db);
            SQLiteCommandBuilder cmdb = new SQLiteCommandBuilder(adapter);
            cmdb.GetInsertCommand();
            DataTable table = new DataTable();
            adapter.Fill(table);
            table.Rows[0].Delete();
            update.AddToDataTable(table);
            adapter.Update(table);

            Program.Log.Info("Database.UpdateUpdate(" + update.UpdateNumber + ")");
        }

        public void DeleteUpdate(string updateNumber)
        {
            this.Open();

            string sql = String.Format("select * from updates where updateNumber={0}", updateNumber);

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, this.db);
            SQLiteCommandBuilder cmdb = new SQLiteCommandBuilder(adapter);
            cmdb.GetInsertCommand();
            DataTable table = new DataTable();
            adapter.Fill(table);
            table.Rows[0].Delete();
            adapter.Update(table);

            Program.Log.Info("Database.DeleteUpdate(" + updateNumber + ")");
        }

        public Dictionary<string, string> GetEmailSettings()
        {
            string sql = "select key, value from settings where key in ('emailHost', 'emailFrom', 'emailUser', 'emailPassword', 'emailTo')";
            SQLiteCommand com = new SQLiteCommand(sql, this.db);
            SQLiteDataReader reader = com.ExecuteReader();
            if (!reader.HasRows)
                return null;
            Dictionary<string, string> settings = new Dictionary<string, string>();
            while(reader.Read())
            {
                settings.Add(reader[0].ToString(), reader[1].ToString());
            }
            reader.Close();
            return settings;
        }

        public void UpdateEmailSettings(Dictionary<string, string> emailSettings)
        {
            this.Open();

            for(int i = 0; i < emailSettings.Count; i++)
            {
                string key = emailSettings.ElementAt(i).Key;
                string value = emailSettings.ElementAt(i).Value;
                string sql = String.Format("update settings set value='{0}' where key='{1}';", value, key);

                SQLiteCommand com = new SQLiteCommand(sql, this.db);
                com.ExecuteNonQuery();
            }
        }

        public string GetEmailsForStoreNumber(string storeNumber)
        {
            string sql = string.Format("select super, ops from stores where storeNumber='{0}'", storeNumber);
            SQLiteCommand com = new SQLiteCommand(sql, this.db);
            SQLiteDataReader reader = com.ExecuteReader();
            if (!reader.HasRows)
                return "";
            string address = GetEmailSettings()["emailTo"];
            while(reader.Read())
            {
                if (storeNumber != "98000")
                    address = address.Replace("[STORE]", string.Format("cmi.{0}@us.stores.mcd.com", storeNumber));
                else
                    address = address.Replace("[STORE]", "");
                address = address.Replace("[SUPER]", reader["super"].ToString());
                address = address.Replace("[OPSMGR]", reader["ops"].ToString());
            }
            address = address.TrimEnd(',');
            reader.Close();
            return address;
        }

        public string[] GetOpsManagers()
        {
            string sql = "select distinct ops from stores";

            SQLiteCommand com = new SQLiteCommand(sql, this.db);
            SQLiteDataReader reader = com.ExecuteReader();
            List<string> ops = new List<string>();
            while(reader.Read())
            {
                ops.Add(reader["ops"].ToString());
            }
            return ops.ToArray();
        }

        public string[] GetSupersForOps(string ops)
        {
            string sql = "select distinct super from stores where ops='" + ops + "'";

            SQLiteCommand com = new SQLiteCommand(sql, this.db);
            SQLiteDataReader reader = com.ExecuteReader();
            List<string> supers = new List<string>();
            while (reader.Read())
            {
                supers.Add(reader["super"].ToString());
            }
            return supers.ToArray();
        }

        public string[] GetStoresForSuper(string super)
        {
            string sql = "select distinct storeNumber from stores where super='" + super + "'";

            SQLiteCommand com = new SQLiteCommand(sql, this.db);
            SQLiteDataReader reader = com.ExecuteReader();
            List<string> stores = new List<string>();
            while (reader.Read())
            {
                stores.Add(reader["storeNumber"].ToString());
            }
            return stores.ToArray();
        }
    }
}
