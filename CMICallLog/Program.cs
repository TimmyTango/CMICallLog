using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;
using System.IO;

namespace CMICallLog
{
    static class Program
    {
        private static string dbLocation;
        public static DBUpdater dbUpdater;
        public static string version;
        public static Updater updater;
        public static readonly log4net.ILog Log =
            log4net.LogManager.GetLogger("CMI Call Log");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData) + @"\CMI Call Log\app.config");

            Log.Info("--Application Start--");

            LoadDbLocation();
            dbUpdater = new DBUpdater();
            updater = new Updater();
            Update();
            version = updater.Current;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NewMainForm());
        }

        public static void Update()
        {
            Log.Info("Checking for update.");
            if (updater.UpdateAvailable())
            {
                DialogResult res = MessageBox.Show("Update available. Would you like to update?", "Program Update", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Log.Info("Applying update.");
                    updater.Update();
                    Application.Restart();
                }
            }
        }

        public static void LoadDbLocation()
        {
            dbLocation = ReadSetting("dbLocation");
            Log.Info("Database location found as: " + dbLocation);
        }

        public static string ReadSetting(string key)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var appSettings = configFile.AppSettings.Settings;

                //var appSettings = ConfigurationManager.AppSettings;
                //string result = appSettings[key] ?? "";
                string result = "";
                if (appSettings[key] != null)
                    result = appSettings[key].Value;
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Could not read setting: " + key);
            }
            return null;
        }

        public static void WriteSetting(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                Log.Info("Config setting " + key + " changed to " + value);
            }
            catch (ConfigurationErrorsException e)
            {
                string error = "Could not write setting: " + key + " [" + value + "]";
                MessageBox.Show(error);
                Log.Error(error);
            }
        }

        public static void CopyTicketToClipboard(string ticketNum, string ticketDesc)
        {
            Clipboard.SetText("#" + ticketNum + " - " + ticketDesc);
        }

        public static void CopyToClipboard(Incident inc, List<Update> upds)
        {
            string copy = "#" + inc.IncidentNumber + " - " + inc.Problem.Trim();
            foreach(Update upd in upds)
            {
                copy += " [" + upd.StartDateTime.ToString("MM/dd") + " " + upd.UpdateBy.Trim() +
                    "] - " + upd.Description.Trim();
            }
            
            Clipboard.SetText(copy);
        }

        public static string DbLocation
        {
            get { return dbLocation; }
            set { dbLocation = value; }
        }

        // Converts HH:MM to hHMMP
        public static string ConvertToShortTime(string longTime)
        {
            string ret = "";
            try
            {
                string[] split = longTime.Split(':');
                int hours = Int32.Parse(split[0]);
                if(hours >= 12)
                {
                    ret = "p";
                    if(hours > 12)
                        hours -= 12;
                } else
                {
                    ret = "a";
                    if (hours == 0) hours = 12;
                }
                ret = hours + split[1] + ret;
            } catch (Exception e)
            {
                return "800a";
            }

            return ret;
        }

        // Converts hHMMP to HH:MM
        public static string ConvertToLongTime(string shortTime)
        {
            string ret = "";
            try
            {
                string period = shortTime.Substring(shortTime.Length - 1);
                int minutes = Int32.Parse(shortTime.Substring(shortTime.Length - 3, 2));
                int hours;
                if(shortTime.Length == 4) //HMM
                {
                    hours = Int32.Parse(shortTime.Substring(0, 1));
                }
                else if (shortTime.Length == 5) //HHMM
                {
                    hours = Int32.Parse(shortTime.Substring(0, 2));
                }
                else { throw new Exception(); }

                if (period == "p")
                    hours += 12;
                else if (period == "a" && hours == 12)
                    hours = 0;
                DateTime dt = new DateTime(1, 1, 1, hours, minutes, 0);
                ret = dt.ToString("HH:mm");

            }
            catch (Exception e)
            {
                return "08:00";
            }

            return ret;
        }

        public static void ExitApp()
        {
            Log.Info("--Application Exited--");
            Application.Exit();
            Environment.Exit(1);
        }
    }
}
