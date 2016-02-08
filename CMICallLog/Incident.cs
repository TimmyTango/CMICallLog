using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CMICallLog
{
    public class Incident
    {
        /*
        CREATE TABLE "incidents" (
	        `incidentNumber`	INTEGER NOT NULL,
	        `storeNumber`	INTEGER NOT NULL,
	        `contactName`	TEXT,
	        `createDateTime`	TEXT NOT NULL,
	        `contactType`	TEXT,
	        `problemType`	TEXT,
	        `status`	TEXT,
	        `priority`	TEXT DEFAULT 'Normal',
	        `posManual`	INTEGER DEFAULT 0,
	        `problem`	TEXT,
	        PRIMARY KEY(incidentNumber)
        )
        */

        private int incidentNumber;
        private int storeNumber;
        private string contactName;
        private DateTime createDateTime;
        private string contactType;
        private string problemType;
        private string status;
        private string priority;
        private bool posManual;
        private string problem;        

        public Incident()
        {
            CreateDateTime = DateTime.Now;
            Priority = "Normal";
            Status = "open";
        }

        public Incident(DataRow row)
        {
            IncidentNumber = int.Parse(row["incidentNumber"].ToString());
            StoreNumber = int.Parse(row["storeNumber"].ToString());
            ContactName = row["contactName"].ToString();
            CreateDateTime = DateTime.ParseExact(
                row["createDateTime"].ToString(),
                Database.dateFormat,
                CultureInfo.InvariantCulture
                );
            ContactType = row["contactType"].ToString();
            ProblemType = row["problemType"].ToString();
            Status = row["status"].ToString();
            Priority = row["priority"].ToString();
            PosManual = row["posManual"].ToString() == "0" ? false : true;
            Problem = row["problem"].ToString();
        }

        public void AddToDataTable(DataTable table)
        {
            table.Rows.Add(IncidentNumber, StoreNumber, ContactName, CreateDateTime.ToString(Database.dateFormat),
                ContactType, ProblemType, Status, Priority, Convert.ToInt32(PosManual), Problem);
        }

        public MailMessage CreateMailMessage()
        {
            string subject = String.Format("Incident Created for NSN {0}", StoreNumber);
            string message = "STORE NUMBER: " + StoreNumber;
            message += "\nINCIDENT NUMBER: " + IncidentNumber;
            message += "\nCONTACT NAME: " + ContactName;
            message += "\nDATE/TIME: " + CreateDateTime;
            message += "\nPROBLEM : " + Problem;

            MailMessage msg = new MailMessage();
            msg.Subject = subject;
            msg.Body = message;

            return msg;
        }


        public int IncidentNumber
        {
            get
            {
                return incidentNumber;
            }

            set
            {
                incidentNumber = value;
            }
        }

        public int StoreNumber
        {
            get
            {
                return storeNumber;
            }

            set
            {
                storeNumber = value;
            }
        }

        public string ContactName
        {
            get
            {
                return contactName;
            }

            set
            {
                contactName = value;
            }
        }

        public DateTime CreateDateTime
        {
            get
            {
                return createDateTime;
            }

            set
            {
                createDateTime = value;
            }
        }

        public string ContactType
        {
            get
            {
                return contactType;
            }

            set
            {
                contactType = value;
            }
        }

        public string ProblemType
        {
            get
            {
                return problemType;
            }

            set
            {
                problemType = value;
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

        public string Priority
        {
            get
            {
                return priority;
            }

            set
            {
                priority = value;
            }
        }

        public bool PosManual
        {
            get
            {
                return posManual;
            }

            set
            {
                posManual = value;
            }
        }

        public string Problem
        {
            get
            {
                return problem;
            }

            set
            {
                problem = value;
            }
        }

    }
}
