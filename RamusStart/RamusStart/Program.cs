using System.Diagnostics;
using System.Windows.Forms;
internal class Program
{
    private static void Main(string[] args)
    {
        //change disk command
        string changeDisk = "C:";
        //path to programm in computer
        string ramusPath = "cd C:\\Ramus\\bin";
        //java path in computer
        string javaPath = "path C:\\Program Files\\Java\\jdk1.8.0_261\\bin";
        //command to start programm
        string startRamus = "java -jar ramus-startup.jar";

        string[] commands = { changeDisk, ramusPath, javaPath , startRamus };

        //create bat file with commands
        File.WriteAllLines("coms.bat", commands);

        ProcessStartInfo process = new("coms.bat")
        {
            CreateNoWindow = true,
            WindowStyle = ProcessWindowStyle.Hidden
        };

        try
        {
            Process.Start(process).WaitForExit();
        }
        catch(Exception ex)
        {
           MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
        }
    }
}