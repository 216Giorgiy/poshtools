﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudioTools.Project;
using PowerShellTools.LanguageService;

namespace PowerShellTools.Project
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [Guid(GuidList.PowerShellToolsProjectPackageGuid)]
    [ProvideProjectFactory(typeof(PowerShellProjectFactory), "PowerShell", "PowerShell Project Files (*.pssproj);*.pssproj", "pssproj", "pssproj", @"\ProjectTemplates\PowerShell", LanguageVsTemplate = "PowerShell", NewProjectRequireNewFolderVsTemplate = false)]
    [ProvideProjectItem(typeof(PowerShellProjectFactory), "PowerShell", @"Templates", 500)]
    [ProvideLanguageExtension(typeof(PowerShellLanguageInfo), ".ps1")]
    [ProvideLanguageExtension(typeof(PowerShellLanguageInfo), ".psm1")]
    [ProvideLanguageExtension(typeof(PowerShellLanguageInfo), ".psd1")]
    [ProvideEditorExtension(typeof(PowerShellEditorFactory), PowerShellConstants.PS1File, 50, ProjectGuid = VSConstants.CLSID.MiscellaneousFilesProject_string, NameResourceID = 3004, DefaultName = "module", TemplateDir = "NewItemTemplates")]
    public class PowerShellProjectPackage : CommonProjectPackage
    {
        public override ProjectFactory CreateProjectFactory()
        {
            return new PowerShellProjectFactory(this);
        }

        public override CommonEditorFactory CreateEditorFactory()
        {
            return new PowerShellEditorFactory(this);
        }

        public override uint GetIconIdForAboutBox()
        {
            //TODO: GetIconIdForAboutBox
            return 0;
        }

        public override uint GetIconIdForSplashScreen()
        {
            //TODO: GetIconIdFroSplashScreen
            return 0;
        }

        public override string GetProductName()
        {
            return PowerShellConstants.LanguageName;
        }

        public override string GetProductDescription()
        {
            return PowerShellConstants.LanguageName;
        }

        public override string GetProductVersion()
        {
            return this.GetType().Assembly.GetName().Version.ToString();
        }
    }
}
