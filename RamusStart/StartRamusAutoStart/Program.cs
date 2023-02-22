namespace StartRamus
{
    using System.Diagnostics;
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {

            string directoryPath = Path.GetTempPath() + "\\RamusAutoStart";
            DirectoryInfo dirInfo = new(directoryPath);
            if (dirInfo.Exists)
            {
                ProcessStartInfo process = new(directoryPath + "\\commands.bat")
                {
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                try
                {
                    Process.Start(process);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var form = new PathFinder.PathFinder();

                form.ShowDialog();
            }
        }
    }
}