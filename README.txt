Program Name: RK SPOON WORLD
Program Purpose : To display the differnt types of spoon and their dicription 
Program Author : Ruchita Patel
Date Created : 2023-10-11 0955[ISO Date]

2023-10-11 0945
Create MvcSpoon project in Visual Studio 2019

2023-10-11 0950
Create GitHub repository

2023-10-11 1000
Propertoes -> launchSetting.json
comment the code 
//"sslPort": 44378
 so that project is run in localhost

 2023-10-11 1004
 Create img folder in wwwroot folder to save images which is used in project

 2023-10-11 1007
 Reference for logo - https://www.google.com/search?q=rk+spoon+image&tbm=isch&hl=en&chips=q:rk+spoon+image,online_chips:logo:i4vQyBnSQqo%3D&rlz=1C1VDKB_enCA1021CA1022&sa=X&ved=2ahUKEwjviZHXl-6BAxWaA2IAHSAKB8YQ4lYoAXoECAEQMg&biw=1519&bih=835#imgrc=Sz1mvPOvEOXPyM&imgdii=OQ07hnRwE9JkKM

2023-10-11 1021
Modify the home page 
add logo of the RK Spoon Company
and write the welcome Message 

2023-10-11 1042
update _Layout.cshtml file
rename MvcSpoon to RKSpoon

2023-10-11 1054
add Aboutus page in Views -> Home -> Aboutus.cshtml

2023-10-11 1100
add new navlink for Abouus page in Shared -> _Layout.cshtml page
add new method for Abotus page in HomeController 
test the app
run successfully 

2023-10-11 1111
add a comment in HomeController.cs file

2023-10-11 1142
add discription in Aboutus page
also add css properties
test the app
run successfully 

2023-10-12 0158
clean the solution and build it 
run successfully

2023-10-12 0202
add controller name MvcSpoon.cs

2023-10-12 0208
add new class in Modal folder called MvcSpoons.cs

2023-10-12 0319
install below packeg form tools->  NuGet Package Manager -> Manage NuGet Package for solution
Microsoft.EntityFrameworkCore.SqlServer
MvcSpoon

Installing:

Microsoft.Bcl.AsyncInterfaces.1.1.0
Microsoft.Bcl.HashCode.1.1.0
Microsoft.CSharp.4.5.0
Microsoft.Data.SqlClient.1.0.19269.1
Microsoft.EntityFrameworkCore.3.1.1
Microsoft.EntityFrameworkCore.Abstractions.3.1.1
Microsoft.EntityFrameworkCore.Analyzers.3.1.1
Microsoft.EntityFrameworkCore.Relational.3.1.1
Microsoft.EntityFrameworkCore.SqlServer.3.1.1
Microsoft.Extensions.Caching.Abstractions.3.1.1
Microsoft.Extensions.Caching.Memory.3.1.1
Microsoft.Extensions.Configuration.3.1.1
Microsoft.Extensions.Configuration.Abstractions.3.1.1
Microsoft.Extensions.Configuration.Binder.3.1.1
Microsoft.Extensions.DependencyInjection.3.1.1
Microsoft.Extensions.DependencyInjection.Abstractions.3.1.1
Microsoft.Extensions.Logging.3.1.1
Microsoft.Extensions.Logging.Abstractions.3.1.1
Microsoft.Extensions.Options.3.1.1
Microsoft.Extensions.Primitives.3.1.1
Microsoft.Identity.Client.3.0.8
Microsoft.NETCore.Platforms.2.0.0
Microsoft.NETCore.Targets.1.1.0
Microsoft.Win32.Registry.4.5.0
runtime.native.System.4.3.0
runtime.native.System.Data.SqlClient.sni.4.4.0
runtime.win-arm64.runtime.native.System.Data.SqlClient.sni.4.4.0
runtime.win-x64.runtime.native.System.Data.SqlClient.sni.4.4.0
runtime.win-x86.runtime.native.System.Data.SqlClient.sni.4.4.0
System.Collections.4.3.0
System.Collections.Concurrent.4.3.0
System.Collections.Immutable.1.7.0
System.Collections.NonGeneric.4.3.0
System.Collections.Specialized.4.3.0
System.ComponentModel.4.3.0
System.ComponentModel.Annotations.4.7.0
System.ComponentModel.Primitives.4.3.0
System.ComponentModel.TypeConverter.4.3.0
System.Configuration.ConfigurationManager.4.5.0
System.Diagnostics.Debug.4.3.0
System.Diagnostics.DiagnosticSource.4.7.0
System.Diagnostics.Tools.4.3.0
System.Diagnostics.Tracing.4.3.0
System.Globalization.4.3.0
System.Globalization.Extensions.4.3.0
System.IO.4.3.0
System.IO.FileSystem.4.3.0
System.IO.FileSystem.Primitives.4.3.0
System.Linq.4.3.0
System.Net.NameResolution.4.3.0
System.Net.Primitives.4.3.0
System.Private.DataContractSerialization.4.3.0
System.Reflection.4.3.0
System.Reflection.Emit.4.3.0
System.Reflection.Emit.ILGeneration.4.3.0
System.Reflection.Emit.Lightweight.4.3.0
System.Reflection.Extensions.4.3.0
System.Reflection.Primitives.4.3.0
System.Reflection.TypeExtensions.4.3.0
System.Resources.ResourceManager.4.3.0
System.Runtime.4.3.0
System.Runtime.Caching.4.5.0
System.Runtime.CompilerServices.Unsafe.4.5.0
System.Runtime.Extensions.4.3.0
System.Runtime.Handles.4.3.0
System.Runtime.InteropServices.4.3.0
System.Runtime.Serialization.Formatters.4.3.0
System.Runtime.Serialization.Json.4.3.0
System.Runtime.Serialization.Primitives.4.3.0
System.Security.AccessControl.4.5.0
System.Security.Cryptography.Primitives.4.3.0
System.Security.Cryptography.ProtectedData.4.5.0
System.Security.Permissions.4.5.0
System.Security.Principal.Windows.4.5.0
System.Security.SecureString.4.3.0
System.Text.Encoding.4.3.0
System.Text.Encoding.CodePages.4.5.0
System.Text.Encoding.Extensions.4.3.0
System.Text.RegularExpressions.4.3.0
System.Threading.4.3.0
System.Threading.Tasks.4.3.0
System.Threading.Tasks.Extensions.4.3.0
System.Xml.ReaderWriter.4.3.0
System.Xml.XDocument.4.3.0
System.Xml.XmlDocument.4.3.0
System.Xml.XmlSerializer.4.3.0

2023-10-12 0324
create Data folder and also create MvcSpoonContext.cs file

2023-10-12 0329
add connection string in appsetting.json file 
add data context in startup.cs file

2023-10-12 03:45
got an error when add new scaffolded item
solution :- write a spoon instaed of Spoons

2023-10-12 0348
add a migration initils using
Add-Migration InitialCreate command

update database using
Update-Database command