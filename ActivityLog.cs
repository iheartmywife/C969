using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chermak_PA_C969
{
    public class ActivityLog
    {
        private static string FileName = "Login_History.txt";

        private static readonly StreamWriter _streamWriter = new StreamWriter(FileName, true);

        public static void LogActivity(string username, bool loginSuccessful)
        {
            if (loginSuccessful)
            {
                _streamWriter.WriteLine($" USER {username} has logged in at {DateTime.Now.ToUniversalTime()}.");
                _streamWriter.Flush();
            }
            else 
            {
                _streamWriter.WriteLine($"Failed Login Attempty with USER {username} at {DateTime.Now.ToUniversalTime()}.");
                _streamWriter.Flush();
            }
        }
    }
}
