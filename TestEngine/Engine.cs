using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace TestEngine
{
        public class Engine
    {
        [DllImport("libtopsimengwrapper.so")]
        public static extern void Invoke([MarshalAs(UnmanagedType.LPStr)] string strrequest,
        StringBuilder strresponse);

        public static void ComputeOutput()
        {
            string input = File.ReadAllText("json1.json");
            Console.WriteLine(input);
            string request = input;
            //StringBuilder request = new StringBuilder(input);
            var response = new StringBuilder(3000);

            Invoke(request, response);
            Console.WriteLine("Response From Engine:" + response);
        }
    }
}
