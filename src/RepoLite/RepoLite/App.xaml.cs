﻿using RepoLite.Models;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace RepoLite
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public static string ClientDataPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Pattisoft\CodeGeneration\";

        public static Guid ClientId => Guid.Parse(ConfigurationManager.AppSettings["ClientId"]);

        public static List<CodePreview> CodePreview { get; set; }
    }
}
