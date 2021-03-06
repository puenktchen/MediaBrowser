﻿using MediaPortal.Common.Utils;
using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Media Browser")]
[assembly: AssemblyDescription("MediaBrowser for MediaPortal")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else 
[assembly: AssemblyConfiguration("Release")] 
#endif
[assembly: AssemblyCompany("Armand Pondman")]
[assembly: AssemblyProduct("Media Browser")]
[assembly: AssemblyCopyright("Copyright © 2014 Armand Pondman")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("1b09d9e8-bb5c-454b-967a-fff2e622d239")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("0.30.*")]
[assembly: AssemblyInformationalVersion("0.30 Beta")]

// mediaportal compatible version
[assembly: CompatibleVersion("1.6.0.0")]
