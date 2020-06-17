using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace find_a_word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            browse.Enabled = false;
            showPath.Enabled = false;
            result.Enabled = false;
            word.Enabled = true;
        }

        private void wordInput(object sender, KeyEventArgs e)
        {
            int m = word.Text.Length;
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (m == 0)
                {
                    DialogResult result = MessageBox.Show("You entered no word. \n Do you want to retry?", "Error",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result != DialogResult.Yes)
                    {
                        this.Close();
                    }
                    return;
                }
            }
            showPath.Enabled = true;
            browse.Enabled = true;
            word.Enabled = false;
            browse.BackColor = Color.Gray;
        }

        private void pathInput(object sender, EventArgs e)
        {
            int m = word.Text.Length;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                showPath.Text = openFileDialog1.FileName;
            }
            string path = showPath.Text;
            showPath.Enabled = false;
            browse.Enabled = false;
            var text = Helper.ReadAllLines(path);
            char[] charArray = text.ToCharArray();
            int n = 0;
            string w = word.Text;
            char[] wordArray = w.ToCharArray();
            char space = ' ';
            char punkt = '.';
            int j = 0;
            for (int i = 0; i <= charArray.Length - m + 1; i++)
            {
                if (charArray[i] != wordArray[j])
                {
                    continue;
                }
                for (int k = 1; k < m; k++)
                {
                    if (charArray[i + k] != wordArray[j + k])
                    {
                        break;
                    }
                    else
                    {
                        if ((k == m - 1) && (charArray[i + k + 1] == space || charArray[i + k + 1] == punkt))
                        {
                            n += 1;
                        }
                    }
                }
            }
            result.Text = "There is " + n + " " + w + " in this file.";
        }

        private void showResult(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {

                Console.Beep(500, 2000);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }

    public static class Helper
    {
        public static string ReadAllLines(string path)
        {
            string result = "";
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    result += sr.ReadLine();
                }
            }
            return result;
        }
    }
}
