using System;
using System.Collections.Generic;
using System.Configuration;


namespace CMICallLog
{
    public class Core
    {
        private static string dbLocation;
        public static DBUpdater dbUpdater;
        public static string version;
        public static readonly log4net.ILog Log =
        log4net.LogManager.GetLogger("CMI Call Log");

        public Core()
        {
            AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData) + @"\CMI Call Log\app.config");

            Log.Info("--Application Start--");
            LoadDbLocation();
            dbUpdater = new DBUpdater();
            version = "1.5.1.0";
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

                string result = "";
                if (appSettings[key] != null)
                    result = appSettings[key].Value;
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                Log.Error("Could not read setting: " + key);
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
                Log.Error(error);
            }
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
                if (hours >= 12)
                {
                    ret = "p";
                    if (hours > 12)
                        hours -= 12;
                }
                else
                {
                    ret = "a";
                    if (hours == 0) hours = 12;
                }
                ret = hours + split[1] + ret;
            }
            catch (Exception e)
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
                if (shortTime.Length == 4) //HMM
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
    }
}