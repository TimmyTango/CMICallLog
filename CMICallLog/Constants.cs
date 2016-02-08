using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMICallLog
{
    class Constants
    {
        public static string[] ContactType =
        {
            "In Person",
            "Live Call",
            "Email",
            "Vmail",
            "Emerg"
        };

        public static string[] Status =
        {
            "Open",
            "Closed",
            "R/V",
            "F/U",
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4"
        };

        public static string[] ProblemType =
        {
            "Connectivity",
            "Hardware",
            "Software",
            "Procedural",
            "Other"
        };

        public static string[] Priority =
        {
            "Priority",
            "High",
            "Normal",
            "Low"
        };

        public static string[] UpdateType =
        {
            "Work Ticket",
            "Helpdesk",
            "Operations",
            "Vendor"
        };
    }
}
