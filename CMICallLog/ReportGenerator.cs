using IronPython;
using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMICallLog
{
    static class ReportGenerator
    {
        public static void RunReportScript(string path)
        {
            ScriptEngine eng = Python.CreateEngine();
            ScriptSource script;
            script = eng.CreateScriptSourceFromFile(path);
            CompiledCode code = script.Compile();
            ScriptScope scope = eng.CreateScope();

            Database db = new Database();
            scope.SetVariable("database", db);
            EmailSender email = new EmailSender();
            scope.SetVariable("email", email);

            //email.SendReport(db, "tim.hamilton@cmi9800.com", "Test", "Test Message");

            code.Execute(scope);
        }
    }
}
