//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XamlStaticHelperNamespace {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
    internal class _XamlStaticHelper {
        
        private static System.WeakReference schemaContextField;
        
        private static System.Collections.Generic.IList<System.Reflection.Assembly> assemblyListField;
        
        internal static System.Xaml.XamlSchemaContext SchemaContext {
            get {
                System.Xaml.XamlSchemaContext xsc = null;
                if ((schemaContextField != null)) {
                    xsc = ((System.Xaml.XamlSchemaContext)(schemaContextField.Target));
                    if ((xsc != null)) {
                        return xsc;
                    }
                }
                if ((AssemblyList.Count > 0)) {
                    xsc = new System.Xaml.XamlSchemaContext(AssemblyList);
                }
                else {
                    xsc = new System.Xaml.XamlSchemaContext();
                }
                schemaContextField = new System.WeakReference(xsc);
                return xsc;
            }
        }
        
        internal static System.Collections.Generic.IList<System.Reflection.Assembly> AssemblyList {
            get {
                if ((assemblyListField == null)) {
                    assemblyListField = LoadAssemblies();
                }
                return assemblyListField;
            }
        }
        
        private static System.Collections.Generic.IList<System.Reflection.Assembly> LoadAssemblies() {
            System.Collections.Generic.IList<System.Reflection.Assembly> assemblyList = new System.Collections.Generic.List<System.Reflection.Assembly>();
            assemblyList.Add(Load("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("Accessibility, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"));
            assemblyList.Add(Load("Microsoft.CSharp, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a" +
                        "3a"));
            assemblyList.Add(Load("Microsoft.VisualBasic.Core, Version=10.0.6.0, Culture=neutral, PublicKeyToken=b03" +
                        "f5f7f11d50a3a"));
            assemblyList.Add(Load("Microsoft.VisualBasic, Version=10.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("Microsoft.VisualBasic.Forms, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03" +
                        "f5f7f11d50a3a"));
            assemblyList.Add(Load("Microsoft.Win32.Primitives, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(Load("Microsoft.Win32.Registry.AccessControl, Version=5.0.0.0, Culture=neutral, PublicK" +
                        "eyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("Microsoft.Win32.Registry, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
                        "7f11d50a3a"));
            assemblyList.Add(Load("Microsoft.Win32.SystemEvents, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc" +
                        "7b13ffcd2ddd51"));
            assemblyList.Add(Load("netstandard, Version=2.1.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51"));
            assemblyList.Add(Load("SimpleTCP, Version=1.0.24.0, Culture=neutral, PublicKeyToken=null"));
            assemblyList.Add(Load("System.AppContext, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50" +
                        "a3a"));
            assemblyList.Add(Load("System.Buffers, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51" +
                        ""));
            assemblyList.Add(Load("System.CodeDom, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51" +
                        ""));
            assemblyList.Add(Load("System.Collections.Concurrent, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b" +
                        "03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Collections, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d5" +
                        "0a3a"));
            assemblyList.Add(Load("System.Collections.Immutable, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Collections.NonGeneric, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b" +
                        "03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Collections.Specialized, Version=5.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.ComponentModel.Annotations, Version=5.0.0.0, Culture=neutral, PublicKeyTok" +
                        "en=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.ComponentModel.DataAnnotations, Version=4.0.0.0, Culture=neutral, PublicKe" +
                        "yToken=31bf3856ad364e35"));
            assemblyList.Add(Load("System.ComponentModel, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.ComponentModel.EventBasedAsync, Version=5.0.0.0, Culture=neutral, PublicKe" +
                        "yToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.ComponentModel.Primitives, Version=5.0.0.0, Culture=neutral, PublicKeyToke" +
                        "n=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.ComponentModel.TypeConverter, Version=5.0.0.0, Culture=neutral, PublicKeyT" +
                        "oken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Configuration.ConfigurationManager, Version=5.0.0.0, Culture=neutral, Publ" +
                        "icKeyToken=cc7b13ffcd2ddd51"));
            assemblyList.Add(Load("System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                        "d50a3a"));
            assemblyList.Add(Load("System.Console, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                        ""));
            assemblyList.Add(Load("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Data.Common, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d5" +
                        "0a3a"));
            assemblyList.Add(Load("System.Data.DataSetExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b" +
                        "77a5c561934e089"));
            assemblyList.Add(Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Data.SqlClient, Version=4.6.1.3, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.Design, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.Contracts, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.Debug, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
                        "7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.DiagnosticSource, Version=5.0.0.0, Culture=neutral, PublicKeyT" +
                        "oken=cc7b13ffcd2ddd51"));
            assemblyList.Add(Load("System.Diagnostics.EventLog, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7" +
                        "b13ffcd2ddd51"));
            assemblyList.Add(Load("System.Diagnostics.FileVersionInfo, Version=5.0.0.0, Culture=neutral, PublicKeyTo" +
                        "ken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.PerformanceCounter, Version=5.0.0.0, Culture=neutral, PublicKe" +
                        "yToken=cc7b13ffcd2ddd51"));
            assemblyList.Add(Load("System.Diagnostics.Process, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.StackTrace, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b" +
                        "03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.TextWriterTraceListener, Version=5.0.0.0, Culture=neutral, Pub" +
                        "licKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.Tools, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
                        "7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.TraceSource, Version=5.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Diagnostics.Tracing, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(Load("System.DirectoryServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
                        "7f11d50a3a"));
            assemblyList.Add(Load("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Drawing.Common, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffc" +
                        "d2ddd51"));
            assemblyList.Add(Load("System.Drawing.Design, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.Drawing, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                        ""));
            assemblyList.Add(Load("System.Drawing.Primitives, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.Dynamic.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Formats.Asn1, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2" +
                        "ddd51"));
            assemblyList.Add(Load("System.Globalization.Calendars, Version=5.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Globalization, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                        "d50a3a"));
            assemblyList.Add(Load("System.Globalization.Extensions, Version=5.0.0.0, Culture=neutral, PublicKeyToken" +
                        "=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.Compression.Brotli, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b7" +
                        "7a5c561934e089"));
            assemblyList.Add(Load("System.IO.Compression, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561" +
                        "934e089"));
            assemblyList.Add(Load("System.IO.Compression.FileSystem, Version=4.0.0.0, Culture=neutral, PublicKeyToke" +
                        "n=b77a5c561934e089"));
            assemblyList.Add(Load("System.IO.Compression.ZipFile, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b" +
                        "77a5c561934e089"));
            assemblyList.Add(Load("System.IO, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.FileSystem.AccessControl, Version=5.0.0.0, Culture=neutral, PublicKeyTo" +
                        "ken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.FileSystem, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                        "d50a3a"));
            assemblyList.Add(Load("System.IO.FileSystem.DriveInfo, Version=5.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.FileSystem.Primitives, Version=5.0.0.0, Culture=neutral, PublicKeyToken" +
                        "=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.FileSystem.Watcher, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.IsolatedStorage, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.MemoryMappedFiles, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03" +
                        "f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.Packaging, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                        "50a3a"));
            assemblyList.Add(Load("System.IO.Pipes.AccessControl, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b" +
                        "03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.IO.Pipes, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                        "a"));
            assemblyList.Add(Load("System.IO.UnmanagedMemoryStream, Version=5.0.0.0, Culture=neutral, PublicKeyToken" +
                        "=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Linq, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Linq.Expressions, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Linq.Parallel, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                        "d50a3a"));
            assemblyList.Add(Load("System.Linq.Queryable, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.Memory, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51"));
            assemblyList.Add(Load("System.Net, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Net.Http, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                        "a"));
            assemblyList.Add(Load("System.Net.Http.Json, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd" +
                        "2ddd51"));
            assemblyList.Add(Load("System.Net.HttpListener, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13f" +
                        "fcd2ddd51"));
            assemblyList.Add(Load("System.Net.Mail, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd5" +
                        "1"));
            assemblyList.Add(Load("System.Net.NameResolution, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.Net.NetworkInformation, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b" +
                        "03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Net.Ping, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                        "a"));
            assemblyList.Add(Load("System.Net.Primitives, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.Net.Requests, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                        "50a3a"));
            assemblyList.Add(Load("System.Net.Security, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                        "50a3a"));
            assemblyList.Add(Load("System.Net.ServicePoint, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13f" +
                        "fcd2ddd51"));
            assemblyList.Add(Load("System.Net.Sockets, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d5" +
                        "0a3a"));
            assemblyList.Add(Load("System.Net.WebClient, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd" +
                        "2ddd51"));
            assemblyList.Add(Load("System.Net.WebHeaderCollection, Version=5.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Net.WebProxy, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2" +
                        "ddd51"));
            assemblyList.Add(Load("System.Net.WebSockets.Client, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Net.WebSockets, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.Numerics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e08" +
                        "9"));
            assemblyList.Add(Load("System.Numerics.Vectors, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.ObjectModel, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d5" +
                        "0a3a"));
            assemblyList.Add(Load("System.Reflection.DispatchProxy, Version=5.0.0.0, Culture=neutral, PublicKeyToken" +
                        "=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Reflection, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50" +
                        "a3a"));
            assemblyList.Add(Load("System.Reflection.Emit, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Reflection.Emit.ILGeneration, Version=5.0.0.0, Culture=neutral, PublicKeyT" +
                        "oken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Reflection.Emit.Lightweight, Version=5.0.0.0, Culture=neutral, PublicKeyTo" +
                        "ken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Reflection.Extensions, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Reflection.Metadata, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(Load("System.Reflection.Primitives, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Reflection.TypeExtensions, Version=5.0.0.0, Culture=neutral, PublicKeyToke" +
                        "n=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Resources.Extensions, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7" +
                        "b13ffcd2ddd51"));
            assemblyList.Add(Load("System.Resources.Reader, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Resources.ResourceManager, Version=5.0.0.0, Culture=neutral, PublicKeyToke" +
                        "n=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Resources.Writer, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.CompilerServices.Unsafe, Version=5.0.0.0, Culture=neutral, PublicK" +
                        "eyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.CompilerServices.VisualC, Version=5.0.0.0, Culture=neutral, Public" +
                        "KeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                        ""));
            assemblyList.Add(Load("System.Runtime.Extensions, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Handles, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Runtime.InteropServices, Version=5.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.InteropServices.RuntimeInformation, Version=5.0.0.0, Culture=neutr" +
                        "al, PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Intrinsics, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b1" +
                        "3ffcd2ddd51"));
            assemblyList.Add(Load("System.Runtime.Loader, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.Runtime.Numerics, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b7" +
                        "7a5c561934e089"));
            assemblyList.Add(Load("System.Runtime.Serialization.Formatters, Version=5.0.0.0, Culture=neutral, Public" +
                        "KeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Serialization.Json, Version=5.0.0.0, Culture=neutral, PublicKeyTok" +
                        "en=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Serialization.Primitives, Version=5.0.0.0, Culture=neutral, Public" +
                        "KeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Runtime.Serialization.Xml, Version=5.0.0.0, Culture=neutral, PublicKeyToke" +
                        "n=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.AccessControl, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b" +
                        "03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Claims, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.Algorithms, Version=5.0.0.0, Culture=neutral, Public" +
                        "KeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.Cng, Version=5.0.0.0, Culture=neutral, PublicKeyToke" +
                        "n=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.Csp, Version=5.0.0.0, Culture=neutral, PublicKeyToke" +
                        "n=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.Encoding, Version=5.0.0.0, Culture=neutral, PublicKe" +
                        "yToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.Pkcs, Version=5.0.0.0, Culture=neutral, PublicKeyTok" +
                        "en=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.Primitives, Version=5.0.0.0, Culture=neutral, Public" +
                        "KeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.ProtectedData, Version=5.0.0.0, Culture=neutral, Pub" +
                        "licKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.X509Certificates, Version=5.0.0.0, Culture=neutral, " +
                        "PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Cryptography.Xml, Version=5.0.0.0, Culture=neutral, PublicKeyToke" +
                        "n=cc7b13ffcd2ddd51"));
            assemblyList.Add(Load("System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                        "a"));
            assemblyList.Add(Load("System.Security.Permissions, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7" +
                        "b13ffcd2ddd51"));
            assemblyList.Add(Load("System.Security.Principal, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5" +
                        "f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.Principal.Windows, Version=5.0.0.0, Culture=neutral, PublicKeyTok" +
                        "en=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Security.SecureString, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b0" +
                        "3f5f7f11d50a3a"));
            assemblyList.Add(Load("System.ServiceModel.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf385" +
                        "6ad364e35"));
            assemblyList.Add(Load("System.ServiceProcess, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                        "1d50a3a"));
            assemblyList.Add(Load("System.Text.Encoding.CodePages, Version=5.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Text.Encoding, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                        "d50a3a"));
            assemblyList.Add(Load("System.Text.Encoding.Extensions, Version=5.0.0.0, Culture=neutral, PublicKeyToken" +
                        "=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Text.Encodings.Web, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b1" +
                        "3ffcd2ddd51"));
            assemblyList.Add(Load("System.Text.Json, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd" +
                        "51"));
            assemblyList.Add(Load("System.Text.RegularExpressions, Version=5.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Threading.AccessControl, Version=5.0.0.0, Culture=neutral, PublicKeyToken=" +
                        "b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Threading.Channels, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b1" +
                        "3ffcd2ddd51"));
            assemblyList.Add(Load("System.Threading, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a" +
                        "3a"));
            assemblyList.Add(Load("System.Threading.Overlapped, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03" +
                        "f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Threading.Tasks.Dataflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken" +
                        "=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Threading.Tasks, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Threading.Tasks.Extensions, Version=5.0.0.0, Culture=neutral, PublicKeyTok" +
                        "en=cc7b13ffcd2ddd51"));
            assemblyList.Add(Load("System.Threading.Tasks.Parallel, Version=5.0.0.0, Culture=neutral, PublicKeyToken" +
                        "=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Threading.Thread, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Threading.ThreadPool, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03" +
                        "f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Threading.Timer, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Transactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c56193" +
                        "4e089"));
            assemblyList.Add(Load("System.Transactions.Local, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b1" +
                        "3ffcd2ddd51"));
            assemblyList.Add(Load("System.ValueTuple, Version=4.0.3.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2dd" +
                        "d51"));
            assemblyList.Add(Load("System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Web.HttpUtility, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ff" +
                        "cd2ddd51"));
            assemblyList.Add(Load("System.Windows, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                        ""));
            assemblyList.Add(Load("System.Windows.Extensions, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b1" +
                        "3ffcd2ddd51"));
            assemblyList.Add(Load("System.Windows.Forms.Design, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77" +
                        "a5c561934e089"));
            assemblyList.Add(Load("System.Windows.Forms.Design.Editors, Version=5.0.0.0, Culture=neutral, PublicKeyT" +
                        "oken=b03f5f7f11d50a3a"));
            assemblyList.Add(Load("System.Windows.Forms, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5619" +
                        "34e089"));
            assemblyList.Add(Load("System.Windows.Forms.Primitives, Version=5.0.0.0, Culture=neutral, PublicKeyToken" +
                        "=b77a5c561934e089"));
            assemblyList.Add(Load("System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
            assemblyList.Add(Load("System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e08" +
                        "9"));
            assemblyList.Add(Load("System.Xml.ReaderWriter, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                        "f11d50a3a"));
            assemblyList.Add(Load("System.Xml.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c" +
                        "561934e089"));
            assemblyList.Add(Load("System.Xml.XDocument, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                        "d50a3a"));
            assemblyList.Add(Load("System.Xml.XmlDocument, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                        "11d50a3a"));
            assemblyList.Add(Load("System.Xml.XmlSerializer, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
                        "7f11d50a3a"));
            assemblyList.Add(Load("System.Xml.XPath, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a" +
                        "3a"));
            assemblyList.Add(Load("System.Xml.XPath.XDocument, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                        "5f7f11d50a3a"));
            assemblyList.Add(Load("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"));
            assemblyList.Add(System.Reflection.Assembly.GetExecutingAssembly());
            return assemblyList;
        }
        
        private static System.Reflection.Assembly Load(string assemblyNameVal) {
            System.Reflection.AssemblyName assemblyName = new System.Reflection.AssemblyName(assemblyNameVal);
            byte[] publicKeyToken = assemblyName.GetPublicKeyToken();
            System.Reflection.Assembly asm = null;
            try {
                asm = System.Reflection.Assembly.Load(assemblyName.FullName);
            }
            catch (System.Exception ) {
                System.Reflection.AssemblyName shortName = new System.Reflection.AssemblyName(assemblyName.Name);
                if ((publicKeyToken != null)) {
                    shortName.SetPublicKeyToken(publicKeyToken);
                }
                asm = System.Reflection.Assembly.Load(shortName);
            }
            return asm;
        }
    }
}
