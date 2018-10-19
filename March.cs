using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasaRobots
{
    public partial class March : Form
    {
        Robot Robot1;
        Robot Robot2;
        Robot onRobot = null;
        InputForm inputForm = null;
        public March()
        {
            InitializeComponent();
        }

        private void March_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyPress +=
                new KeyPressEventHandler(KeyListener);
            _robot1.Location = new Point(50, 250);
            _robot2.Location = new Point(500, 250);
            Robot1 = new Robot(50, 250, _robot1);
            Robot2 = new Robot(500, 250, _robot2);
            this.Width = 650;
            this.Height = 450;
            enterFirstLocation();
        }
        void KeyListener(object sender, KeyPressEventArgs e)
        {
            if (onRobot != null)
            {
                if (Convert.ToChar(e.KeyChar).ToString().ToUpper() == "L")
                {
                    onRobot.TurnLeft();
                }
                else if (Convert.ToChar(e.KeyChar).ToString().ToUpper() == "R")
                {
                    onRobot.TurnRight();
                }
                else if (Convert.ToChar(e.KeyChar).ToString().ToUpper() == "M")
                {
                    onRobot.Go();
                }
            }
            else
            {
                MessageBox.Show("Please select the robot ago");
            }
        }
     
        public void enterFirstLocation()
        {
            Hide();
            inputForm = new InputForm();
            inputForm.Show();
            inputForm.title.Text = "Enter robot first location Ex:3 2";
            inputForm.note.Text = "Please enter robot location between 0 and 10 for X and between 0 and 5 for Y. After you can do mouse hover on any robot for select";
            inputForm.button1.Click += GetFirstLocation;
        }
        private void GetFirstLocation(object sender, EventArgs e)
        {
            try
            {
                string[] locations = inputForm.enteredText.Split(' ');
                _robot1.Location = new Point(int.Parse(locations[0]) * 50, int.Parse(locations[1]) * 50);
                Robot1.SetLocations();
                _robot1_MouseHover(sender, e);
                inputForm.Close();
                Show();
            }
            catch (Exception ex)
            {
                new InvalidOperationException("Please enter first location as true Ex: 3 2");
            }
        }

        private void _robot1_MouseHover(object sender, EventArgs e)
        {
            onRobot = Robot1;
            onRobot.RobotIcon.Text = "Selected";
            Robot2.RobotIcon.Text = ".";
        }

        private void _robot2_MouseHover(object sender, EventArgs e)
        {
            onRobot = Robot2;
            onRobot.RobotIcon.Text = "Selected";
            Robot1.RobotIcon.Text = ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputForm = new InputForm();
            inputForm.title.Text = "Enter Bulk Katar Commands";
            inputForm.note.Text = "Commands format Ex : LMRMLM";
            inputForm.Show();
            inputForm.button1.Click += GetKatars_Click;
        }
        private void GetKatars_Click(object sender, EventArgs e)
        {
            try
            {
                if (onRobot != null)
                {
                    inputForm.Close();
                    string commands = inputForm.enteredText.Trim();
                    char[] keys = commands.ToCharArray();
                    foreach (char k in keys)
                    {
                        KeyListener(sender, new KeyPressEventArgs(k));
                    }
                }
                else
                {
                    MessageBox.Show("Please select the robot ago");
                }
            }
            catch (Exception)
            {
                new InvalidOperationException("Please enter commands as true Ex:LLRRMMRM");
            }
        }
    }
}
