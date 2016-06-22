using System;
using System.Collections.Generic;
using System.IO;

namespace CMICallLog
{
    public class DBUpdater
    {
        private string updatePath;
        private List<Version> updates;

        public DBUpdater()
        {
            updatePath = @".\updates\";
            updates = new List<Version>();
            ParseUpdateFolder();
        }

        private void ParseUpdateFolder()
        {
            if (Directory.Exists(updatePath))
            {
                DirectoryInfo directory = new DirectoryInfo(updatePath);
                DirectoryInfo[] directories = directory.GetDirectories();

                foreach (DirectoryInfo update in directories)
                {
                    updates.Add(new Version(update.Name));
                }
            }
        }

        public bool CheckHigherVersion(string version)
        {
            Version current = new Version(version);
            if(updates.Count > 0)
                if (updates[updates.Count - 1] > current)
                    return true;
            return false;
        }

        public void UpdateDatabase(Database db, string currentVersion)
        {
            Version current = new Version(currentVersion);
            DirectoryInfo dir = new DirectoryInfo(updatePath);
            foreach (Version v in updates)
            {
                if (v > current)
                {
                    DirectoryInfo updateDir = new DirectoryInfo(updatePath + v.ToString());
                    foreach (FileInfo info in updateDir.GetFiles("*.sql"))
                    {
                        db.RunUpdateFile(info.FullName);
                    }
                }
            }
        }
    }
}
