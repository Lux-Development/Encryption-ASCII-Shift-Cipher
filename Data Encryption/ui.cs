using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Encryption
{
    public partial class ui : Form
    {
        public ui()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public string enc;
        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            string input = siticoneTextBox1.Text;
            string nickname = siticoneTextBox4.Text;
            string velocity = "none";

            if (low.Checked == true)
            {
                velocity = "low";
            }
            if (mid.Checked == true)
            {
                velocity = "medium";
            }
            if (high.Checked == true)
            {
                velocity = "high";
            }
            if (extreme.Checked == true)
            {
                velocity = "extreme";
            }

            if (velocity == "low")
            {
                string encrypt = "";
                for (int iChar = 0; iChar < input.Length; iChar++)
                {
                    encrypt += (char)(input[iChar] + 2);
                }

                using (StreamWriter writer = new StreamWriter($@"C:\Encryption\[Level] # Low\{nickname}.encrypted"))
                {
                    writer.WriteLine(encrypt);
                }

                MessageBox.Show($@"Saved encryption string into C:\Encryption\[Level] # Low\{nickname}.encrypted");
            }

            if (velocity == "medium")
            {
                string encrypt = "";
                for (int iChar = 0; iChar < input.Length; iChar++)
                {
                    encrypt += (char)(input[iChar] + 4);
                }

                using (StreamWriter writer = new StreamWriter($@"C:\Encryption\[Level] # Medium\{nickname}.encrypted"))
                {
                    writer.WriteLine(encrypt);
                }

                MessageBox.Show($@"Saved encryption string into C:\Encryption\[Level] # Medium\{nickname}.encrypted");
            }

            if (velocity == "high")
            {
                string encrypt = "";
                for (int iChar = 0; iChar < input.Length; iChar++)
                {
                    encrypt += (char)(input[iChar] + 6);
                }

                using (StreamWriter writer = new StreamWriter($@"C:\Encryption\[Level] # High\{nickname}.encrypted"))
                {
                    writer.WriteLine(encrypt);
                }

                MessageBox.Show($@"Saved encryption string into C:\Encryption\[Level] # High\{nickname}.encrypted");
            }

            if (velocity == "extreme")
            {
                string encrypt = "";
                for (int iChar = 0; iChar < input.Length; iChar++)
                {
                    encrypt += (char)(input[iChar] + 9);
                }

                using (StreamWriter writer = new StreamWriter($@"C:\Encryption\[Level] # Extreme\{nickname}.encrypted"))
                {
                    writer.WriteLine(encrypt);
                }

                MessageBox.Show($@"Saved encryption string into C:\Encryption\[Level] # Extreme\{nickname}.encrypted");
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            string input = siticoneTextBox1.Text;
            string nickname = siticoneTextBox4.Text;
            string velocity = "none";

            if (low.Checked == true)
            {
                velocity = "low";
            }
            if (mid.Checked == true)
            {
                velocity = "medium";
            }
            if (high.Checked == true)
            {
                velocity = "high";
            }
            if (extreme.Checked == true)
            {
                velocity = "extreme";
            }

            if (velocity == "low")
            {
                string encrypt = "";
                for (int iChar = 0; iChar < input.Length; iChar++)
                {
                    encrypt += (char)(input[iChar] - 2);
                }

                using (StreamWriter writer = new StreamWriter($@"C:\Encryption\latest.decrypted"))
                {
                    writer.WriteLine(encrypt);
                }

                MessageBox.Show(@"Saved decrypted string into C:\Encryption\latest.decrypted");
            }

            if (velocity == "medium")
            {
                string encrypt = "";
                for (int iChar = 0; iChar < input.Length; iChar++)
                {
                    encrypt += (char)(input[iChar] - 4);
                }

                using (StreamWriter writer = new StreamWriter($@"C:\Encryption\latest.decrypted"))
                {
                    writer.WriteLine(encrypt);
                }

                MessageBox.Show(@"Saved decrypted string into C:\Encryption\latest.decrypted");
            }

            if (velocity == "high")
            {
                string encrypt = "";
                for (int iChar = 0; iChar < input.Length; iChar++)
                {
                    encrypt += (char)(input[iChar] - 6);
                }

                using (StreamWriter writer = new StreamWriter($@"C:\Encryption\latest.decrypted"))
                {
                    writer.WriteLine(encrypt);
                }

                MessageBox.Show(@"Saved decrypted string into C:\Encryption\latest.decrypted");
            }

            if (velocity == "extreme")
            {
                string encrypt = "";
                for (int iChar = 0; iChar < input.Length; iChar++)
                {
                    encrypt += (char)(input[iChar] - 9);
                }

                using (StreamWriter writer = new StreamWriter($@"C:\Encryption\latest.decrypted"))
                {
                    writer.WriteLine(encrypt);
                }

                MessageBox.Show(@"Saved decrypted string into C:\Encryption\latest.decrypted");
            }
        }
    }
}
