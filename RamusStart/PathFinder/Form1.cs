using System.Diagnostics;

namespace PathFinder
{
    public partial class PathFinder : Form
    {
        public PathFinder()
        {
            InitializeComponent();

            string directoryPath = Path.GetTempPath() + "\\RamusAutoStart";
            DirectoryInfo dirInfo = new(directoryPath);
            if (dirInfo.Exists)
            {
                try
                {
                    dirInfo.Delete(true);
                }
                catch { }
            }
        }

        private void RamusPathObserverButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new()
            {
                Filter = "Jar files(*.jar)|*.jar"
            };

            if (file.ShowDialog() == DialogResult.OK)
            {
                // ��� ������ ����� � ����� C:\Ramus\bin\file.* � ��������� ����� ������� ���� C:\Ramus\bin
                var position = file.FileName.LastIndexOf('\\');
                textBoxRamusPath.Text = file.FileName.Remove(position, file.FileName.Length - position);
            }
        }

        private void JavaPathObserverButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new()
            {
                Filter = "Java exe file(Java.exe)|Java.exe"
            };

            if (file.ShowDialog() == DialogResult.OK)
            {
                // ��� ������ ����� � ����� C:\Program Files\Java\jdk1.8.0_261\bin\java.exe � ��������� ����� ������� ���� C:\Program Files\Java\jdk1.8.0_261\bin
                var position = file.FileName.LastIndexOf('\\');
                textBoxJavaPath.Text = file.FileName.Remove(position, file.FileName.Length - position);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (!textBoxJavaPath.Text.Equals("") && !textBoxRamusPath.Equals(""))
            {
                try
                {
                    string directoryPath = Path.GetTempPath() + "\\RamusAutoStart";
                    DirectoryInfo dirInfo = new(directoryPath);
                    if (!dirInfo.Exists)
                    {
                        // ������� �����
                        dirInfo.Create();
                        // ������� ����� � ������ � ���������
                        File.WriteAllText(directoryPath + "\\Paths.txt", textBoxJavaPath.Text + "\n" + textBoxRamusPath.Text);
                        File.WriteAllLines(directoryPath + "\\commands.bat", CommandsToStart.Commands(textBoxJavaPath.Text, textBoxRamusPath.Text));

                        Process.Start("StartRamus.exe");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("�������� ����� temp � ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("���������� ������� ���� �� Java � Ramus","������",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}