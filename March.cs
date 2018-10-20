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
        static int boardWith = 0;
        static int boardHeight = 0;
        public static int stepWidth = 0;
        public static int stepHeight = 0;
        public March()
        {
            InitializeComponent();
        }

        private void March_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyPress +=
                new KeyPressEventHandler(KeyListener); 
            this.Width = 650;
            this.Height = 450;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            _robot1.Location = new Point(50, 250);
            _robot2.Location = new Point(500, 250);
            getBoardSizes();
            this.Hide();
        }
        public void setConfiguration()
        { 
            Robot1 = new Robot(50, 250, _robot1);
            Robot2 = new Robot(500, 250, _robot2);
        }
        public void getBoardSizes()
        { 
            inputForm = new InputForm();
            inputForm.Show(); 
            inputForm.title.Text = "Enter board size Ex:10 5";
            inputForm.note.Text = "Please enter board size for x,y locations";
            inputForm.button1.Click += GetBoardSizes;
        }
        private void GetBoardSizes(object sender, EventArgs e)
        {
            try
            {
                string[] sizes = inputForm.enteredText.Trim().Split(' ');
                boardWith = int.Parse(sizes[0]);
                boardHeight = int.Parse(sizes[1]);
                stepWidth = 500 / boardWith;
                stepHeight = 250 / boardHeight;
                inputForm.Close();
                Visible = true;
                setConfiguration();
                enterFirstLocation();
            }
            catch (Exception ex)
            {
                new InvalidOperationException("Please enter board size for x,y locations");
                MessageBox.Show("Please enter board size for x,y locations Ex:10 5","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Write(ex.Message);
            }
        }

        public void enterFirstLocation()
        {
           
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
                MessageBox.Show("Please select robot and enter first location as true Ex: 3 2", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new InvalidOperationException(ex.Message);
                Console.Write(ex.Message);
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
            catch (Exception ex)
            {
                new InvalidOperationException("Please enter commands as true Ex:LLRRMMRM");
                MessageBox.Show("Invalid commands! Please enter commands as true Ex:LLRRMMRM", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
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

        private void March_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
