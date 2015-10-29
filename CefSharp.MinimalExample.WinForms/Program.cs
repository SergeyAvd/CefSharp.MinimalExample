// Copyright © 2010-2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            var settings = new CefSettings();
            settings.LogSeverity = LogSeverity.Verbose;
            var args = settings.CefCommandLineArgs;
            // Set up be default
            //settings.CefCommandLineArgs.Add("enable-system-flash", "1"); //Automatically discovered and load a system-wide installation of Pepper Flash.
            settings.CefCommandLineArgs.Add("enable-npapi", "1"); //Enable NPAPI plugs which were disabled by default in Chromium 43 (NPAPI will be removed completely in Chromium 45)          
            var version = settings.ProductVersion;
            Cef.Initialize(settings);

            var browser = new BrowserForm();
            Application.Run(browser);
        }
    }
}
