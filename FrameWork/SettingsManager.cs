﻿using System.Collections.Generic;
using System.IO;

namespace FrameWork
{
    public class SettingsManager
    {
        private FileInfo SettingsFile { get; set; }

        public SettingsManager(string strLogFileName)
        {
            this.SettingsFile = new FileInfo(strLogFileName);

            if (!this.SettingsFile.Exists)
            {
                using (StreamWriter stwrAppend = this.SettingsFile.AppendText())
                {
                }
            }
        }

        public bool AreSettingsSet(List<string> settingNames)
        {
            Dictionary<string, string> allSettings = GetAllSettings();

            foreach (string CurrSetting in settingNames)
            {
                if (!allSettings.ContainsKey(CurrSetting))
                {
                    return false;
                }
            }
            
            return true;
        }

        public Dictionary<string, string> GetAllSettings()
        {
            Dictionary<string, string> allSettings = new Dictionary<string, string>();

            using (StreamReader settingsReader = new StreamReader(this.SettingsFile.FullName))
            {
                while (!settingsReader.EndOfStream)
	            {
                    allSettings.Add(settingsReader.ReadLine(), settingsReader.ReadLine()); 
	            }
            }

            return allSettings;
        }

        public void SaveSettings(Dictionary<string, string> allSettings)
        {
            using (StreamWriter settingsWriter = 
                                    new StreamWriter(this.SettingsFile.Open(FileMode.Create)))
            {
                foreach (KeyValuePair<string, string> CurrSetting in allSettings)
                {
                    settingsWriter.WriteLine(CurrSetting.Key);
                    settingsWriter.WriteLine(CurrSetting.Value);
                }
            }
        }
    }
}
