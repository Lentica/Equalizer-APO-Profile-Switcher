using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EQAPO_Profile_Switcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int scrollValue;
        static string path = @"C:\Program Files\EqualizerAPO\config";

        string[] lines = File.ReadAllLines(path + @"\config.txt");
        bool isEnabled = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            scrollValue = vScrollBar1.Value;
            this.Width += 15;
            refreshMethod();
        }

        private void refreshMethod()
        {
            bool allDisabled = false;
            for (int i = 0; i < lines.Length; i++)
            {
                if (!lines[i].Contains("#"))
                {
                    if (lines[i].Contains("Include"))
                    {
                        allDisabled = true;
                    }
                }
            }
            if (allDisabled)
            {
                disableAll.BackColor = Color.Gray;
            }
            else
            {
                disableAll.BackColor = Color.Green;
            }
            foreach (Button btn in panel1.Controls)
            {
                if (btn.Name != "disableAll")
                {
                    btn.Dispose();
                }
            }
            string[] inactiveIncludes = new string[lines.Length];
            int ctr = 0, top = 10, left = 222, ctrAll = 0;bool setScrollMax = true;
            foreach (string line in lines)
            {
                //MessageBox.Show(ctrAll.ToString());
                bool isActive = false;
                if (line.Contains("Include"))
                {
                    ctr++;
                    string buttonText = "";
                    if (line.Contains("#"))
                    {
                        isActive = false;
                        int inactiveIndex = line.IndexOf(":");
                        buttonText = line.Substring(inactiveIndex + 1);
                        //MessageBox.Show(buttonText);
                    }
                    else
                    {
                        isActive = true;
                        int activeIndex = line.IndexOf(":");
                        buttonText = line.Substring(activeIndex + 1);
                        //MessageBox.Show(buttonText);
                    }
                    Button btn = new Button();
                    //MessageBox.Show(ctrAll.ToString());
                    btn.Name = (ctrAll).ToString();
                    btn.Width = 200;
                    btn.Height = 200;
                    btn.Top = top;
                    btn.Left = left;
                    btn.Text = buttonText;
                    btn.Anchor = (AnchorStyles.Top|AnchorStyles.Left);
                    btn.Font = new Font(this.Font.FontFamily, 12);
                    //btn.Click += new EventHandler(btnClick);

                    btn.Click += (s, x) =>
                    {
                        //MessageBox.Show(btn.Name);
                        string toSwitch = lines[Convert.ToInt32(btn.Name)];
                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (!lines[i].Contains("#"))
                            {
                                lines[i] = "#" + lines[i];
                            }
                        }
                        toSwitch = toSwitch.Substring(toSwitch.IndexOf("#") + 1);
                        //  MessageBox.Show(toSwitch);
                        lines[Convert.ToInt32(btn.Name)] = toSwitch;
                        if (File.Exists(path + @"\config.txt"))
                        {
                            File.Delete(path + @"\config.txt");
                            File.WriteAllLines(path + @"\config.txt", lines);
                        }

                        foreach (Button buttons in panel1.Controls)
                        {
                            buttons.BackColor = Color.Gray;
                            if (buttons.Name == btn.Name)
                            {
                                buttons.BackColor = Color.Green;
                            }
                        }
                    };
                    if (isActive)
                    {
                        btn.BackColor = Color.Green;
                    }
                    else
                    {
                        btn.BackColor = Color.Gray;
                    }

                    panel1.Controls.Add(btn);
                    left += 202;
                    if (left >= 626)
                    {
                        //MessageBox.Show(ctr+"");
                        if (ctr>1)
                        {
                            if (setScrollMax)
                            {
                                vScrollBar1.Maximum = 10;
                                setScrollMax = false;
                            }
                            vScrollBar1.Maximum += 1;
                            //MessageBox.Show(vScrollBar1.Maximum.ToString());
                        }
                        left = 20;
                        top += 202;
                        panel1.Height += 202;
                        //MessageBox.Show(left + "");
                    }
                }
                ctrAll++;
                //MessageBox.Show(ctrAll.ToString());
            }
        }

        private void disableAll_Click(object sender, EventArgs e)
        {
            disableAllProfiles();
        }

        private void disableAllProfiles()
        {
            isEnabled = true;
            if (isEnabled)
            {
                disableAll.BackColor = Color.Green;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (!lines[i].Contains("#"))
                    {
                        if (lines[i].Contains("Include"))
                        {
                            lines[i] = "#" + lines[i];
                            //MessageBox.Show(lines[i]);
                        }
                    }
                }
                foreach (Button btn in panel1.Controls)
                {
                    if (btn.Name != "disableAll")
                    {
                        btn.BackColor = Color.Gray;
                    }
                }
                if (File.Exists(path + @"\config.txt"))
                {
                    File.Delete(path + @"\config.txt");
                    File.WriteAllLines(path + @"\config.txt", lines);
                }
            }
            else
            {
                disableAll.BackColor = Color.Gray;
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int scrollValueChanged = vScrollBar1.Value;
            if (scrollValueChanged>scrollValue)
            {
                panel1.Top -= 200;
                scrollValue = scrollValueChanged;
            }
            else if (scrollValueChanged<scrollValue)
            {
                panel1.Top += 200;
                scrollValue = scrollValueChanged;
            }
        }

        private void disableAllProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disableAllProfiles();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right)
            {
                //contextMenuStrip1.Top = e.Y;
                //contextMenuStrip1.Left = e.X;
                //contextMenuStrip1.Show();
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void refreshConfigsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshMethod();
        }
    }
}
