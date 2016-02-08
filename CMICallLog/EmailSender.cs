using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMICallLog
{
    class EmailSender
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }


        public EmailSender(string to, string subject, string message)
        {
            To = to;
            Subject = subject;
            Message = message;
        }

        public static void SendIncidentEmail(Database db, Incident inc)
        {
            Dictionary<string, string> email = db.GetEmailSettings();

            string subject = String.Format("Incident Created for NSN {0}", inc.StoreNumber);
            string message = "STORE NUMBER: " + inc.StoreNumber;
            message += "\nINCIDENT NUMBER: " + inc.IncidentNumber;
            message += "\nCONTACT NAME: " + inc.ContactName;
            message += "\nDATE/TIME: " + inc.CreateDateTime;
            message += "\nPROBLEM : " + inc.Problem;

            SmtpClient client = new SmtpClient(email["emailHost"]);

            string to = db.GetEmailsForStoreNumber(inc.StoreNumber.ToString());

            if (to == "")
                return;

            MailMessage msg = new MailMessage(email["emailFrom"], to);
            msg.Body = message;
            msg.Subject = subject;

            client.Credentials = new System.Net.NetworkCredential(email["emailUser"], email["emailPassword"]);

            client.SendAsync(msg, "TestEmail");
        }

        public static void SendUpdateEmail(Database db, Update update)
        {
            Dictionary<string, string> email = db.GetEmailSettings();

            string subject = String.Format("Update for incident {0} (NSN {1})", update.Incident.IncidentNumber,
                update.Incident.StoreNumber);
            if (update.Status.ToLower() == "closed")
                subject = String.Format("Incident {0} (NSN {1}) has been closed", update.Incident.IncidentNumber,
                    update.Incident.StoreNumber);
            string message = "STORE NUMBER: " + update.Incident.StoreNumber;
            message += "\nINCIDENT NUMBER: " + update.Incident.IncidentNumber;
            message += "\nPROBLEM: " + update.Incident.Problem;
            message += "\n\nDATE/TIME: " + update.EndDateTime;
            message += "\nUPDATE BY: " + update.UpdateBy;
            message += "\nSTATUS: " + update.Status;
            message += "\nDESCRIPTION: " + update.Description;

            SmtpClient client = new SmtpClient(email["emailHost"]);

            string to = db.GetEmailsForStoreNumber(update.Incident.StoreNumber.ToString());

            if (to == "")
                return;

            MailMessage msg = new MailMessage(email["emailFrom"], to);
            msg.Body = message;
            msg.Subject = subject;

            client.Credentials = new System.Net.NetworkCredential(email["emailUser"], email["emailPassword"]);

            client.SendAsync(msg, "TestEmail");
        }
    }
}
