using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    internal class CommandsToStart
    {
        public static string[] Commands(string javaPath, string ramusPath)
        {
            //change disk command
            string changeDisk = ramusPath.Split("\\").First();
            //command to start programm
            string startRamus = "java -jar ramus-startup.jar";

            string[] commands = {"cd " + changeDisk,"cd " + ramusPath,"path " + javaPath, startRamus };

            return commands;
        }
    }
}
