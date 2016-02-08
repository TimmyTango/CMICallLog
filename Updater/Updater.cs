using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace CMICallLog
{
    public class Updater
    {
        string versionURL = @"https://dl.dropboxusercontent.com/u/37651679/CMI%20Call%20Log/Version.txt";
        string installerURL = @"https://dl.dropboxusercontent.com/u/37651679/CMI%20Call%20Log/CMI%20Call%20Log.msi";
        WebClient webClient;
        Version current;
        Version newVersion;
        static string versionFile = @".\version.txt";


        public string Current
        {
            get { return current.ToString(); }
        }

        static void Main(string[] args)
        {
            Updater u = new Updater();
            u.Update();
        }

        public Updater()
        {
            GetCurrentVersion();
            webClient = new WebClient();
        }

        public void Update()
        {
            if (UpdateAvailable())
                UpdateCMICallLog();
        }

        void GetCurrentVersion()
        {
            try
            {
                using(FileStream fs = new FileStream(versionFile, FileMode.Open, FileAccess.Read))
                {
                    StreamReader sr = new StreamReader(fs);
                    string fileVersion = sr.ReadToEnd();
                    sr.Close();
                    current = new Version(fileVersion);
                }
            }
            catch (Exception e)
            {
                current = new Version(0, 0, 0, 0);
            }
            //File.WriteAllText(@".\version.txt", current.ToString());
        }

        void UpdateCMICallLog()
        {
            string tmp = Path.GetTempPath() + @"\CMI Call Log.exe";
            try
            {
                webClient.DownloadFile(installerURL, tmp);
            }
            catch (Exception e)
            {
            }
            if (File.Exists(tmp))
            {
                System.Diagnostics.Process.Start(tmp);
                Environment.Exit(0);
            }
        }

        public bool UpdateAvailable()
        {
            try
            {
                Version update = new Version(webClient.DownloadString(versionURL));
                newVersion = update;
                return update > current;
            }
            catch (Exception e)
            {
            }

            return false;
        }
    }
}
