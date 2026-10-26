using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: AssemblyTitle($safeprojectname$.BuildInfo.Name)]
[assembly: AssemblyDescription($safeprojectname$.BuildInfo.Description)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany($safeprojectname$.BuildInfo.Company)]
[assembly: AssemblyProduct($safeprojectname$.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + $safeprojectname$.BuildInfo.Author)]
[assembly: AssemblyTrademark($safeprojectname$.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion($safeprojectname$.BuildInfo.Version)]
[assembly: AssemblyFileVersion($safeprojectname$.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof($safeprojectname$.$safeprojectname$), $safeprojectname$.BuildInfo.Name, $safeprojectname$.BuildInfo.Version, $safeprojectname$.BuildInfo.Author, $safeprojectname$.BuildInfo.DownloadLink)]
[assembly: MelonGame($safeprojectname$.BuildInfo.MelonGameCompany, $safeprojectname$.BuildInfo.MelonGameName)]