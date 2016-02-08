using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMICallLog
{
    public class Update
    {
        //CREATE TABLE "updates" (
        // `updateNumber`	INTEGER,
        // `incident`	INTEGER NOT NULL,
        // `startDateTime`	TEXT,
        // `endDateTime`	TEXT,
        // `updateBy`	TEXT,
        // `type`	TEXT,
        // `status`	TEXT,
        // `description`	TEXT,
        // PRIMARY KEY(updateNumber)
        //)
        private int updateNumber;
        private Incident incident;
        private DateTime startDateTime;
        private DateTime endDateTime;
        private string updateBy;
        private string type;
        private string status;
        private string description;

        public Update(Incident incident)
        {
            Incident = incident;
            StartDateTime = DateTime.Now;
            EndDateTime = DateTime.Now;
            Status = "open";
        }

        public Update(DataRow row, Incident incident)
        {
            UpdateNumber = int.Parse(row["updateNumber"].ToString());
            Incident = incident;
            StartDateTime = DateTime.ParseExact(
                row["startDateTime"].ToString(),
                Database.dateFormat,
                CultureInfo.InvariantCulture
                );
            EndDateTime = DateTime.ParseExact(
                row["endDateTime"].ToString(),
                Database.dateFormat,
                CultureInfo.InvariantCulture
                );
            UpdateBy = row["updateBy"].ToString();
            Type = row["type"].ToString();
            Status = row["status"].ToString();
            Description = row["description"].ToString();
        }

        public void AddToDataTable(DataTable table)
        {
            table.Rows.Add(
                UpdateNumber,
                Incident.IncidentNumber,
                StartDateTime.ToString(Database.dateFormat),
                EndDateTime.ToString(Database.dateFormat),
                UpdateBy,
                Type,
                Status,
                Description
                );
        }

        // Properties //

        public int UpdateNumber
        {
            get
            {
                return updateNumber;
            }

            set
            {
                updateNumber = value;
            }
        }

        public Incident Incident
        {
            get
            {
                return incident;
            }

            set
            {
                incident = value;
            }
        }

        public DateTime StartDateTime
        {
            get
            {
                return startDateTime;
            }

            set
            {
                startDateTime = value;
            }
        }

        public DateTime EndDateTime
        {
            get
            {
                return endDateTime;
            }

            set
            {
                endDateTime = value;
            }
        }

        public string UpdateBy
        {
            get
            {
                return updateBy;
            }

            set
            {
                updateBy = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
    }
}
