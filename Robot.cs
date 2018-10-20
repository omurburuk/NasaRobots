using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasaRobots
{
    interface Actions
    {
        void TurnLeft();
        void TurnRight();
        void Go();
    }
    abstract class BaseRobot
    {
        internal int Perspective = 90;
        int LocationX { get; set; }
        int LocationY { get; set; }
        public GroupBox RobotIcon { get; set; }
        public BaseRobot(int locationX, int locationY)
        {
            this.LocationX = locationX;
            this.LocationY = locationY;
        }
        public BaseRobot(int locationX, int locationY, GroupBox robotIcon)
        {
            this.LocationX = locationX;
            this.LocationY = locationY;
            this.RobotIcon = robotIcon;
        }
        public void SetLocations()
        {
            this.LocationX = RobotIcon.Location.X/March.stepWidth;
            this.LocationY = RobotIcon.Location.Y/ March.stepHeight;
            foreach (Control c in RobotIcon.Controls)
            {
                if (c.Tag != null)
                {
                    if (c.Tag.ToString() == "X")
                        c.Text = LocationX.ToString();
                    if (c.Tag.ToString() == "Y")
                        c.Text = LocationY.ToString();
                    if (c.Tag.ToString() == "Pers")
                        c.Text = Perspective == 0 ? "W" : (Perspective == 90 ? "S" : (Perspective == 180 ? "E" : "N"));
                }
            }
        }
    }
    internal class Robot : BaseRobot, Actions
    {
        public Robot(int locationX, int locationY, GroupBox robotIcon) : base(locationX, locationY, robotIcon)
        {
            SetLocations();
        }

        public void Go()
        {
            if (Perspective == 0) 
                RobotIcon.Location = new Point(
                        (RobotIcon.Location.X - March.stepWidth) < 0 ? 0 : RobotIcon.Location.X - March.stepWidth,
                        RobotIcon.Location.Y);
            else if (Perspective == 90)
                RobotIcon.Location = new Point(
                    RobotIcon.Location.X,
                    (RobotIcon.Location.Y + March.stepHeight > (250)) ? 250 : RobotIcon.Location.Y + March.stepHeight);
            else if (Perspective == 180)
                RobotIcon.Location = new Point(
                    (RobotIcon.Location.X + March.stepWidth > (500 )) ? 500 : RobotIcon.Location.X + March.stepWidth,
                    RobotIcon.Location.Y);
            else if (Perspective == 270)
                RobotIcon.Location = new Point(
                    RobotIcon.Location.X,
                   (RobotIcon.Location.Y - March.stepHeight) < 0 ? 0 : RobotIcon.Location.Y - March.stepHeight);
            SetLocations();
        }

        public void TurnLeft()
        {
            Perspective -= 90;
            if (Perspective < 0)
                Perspective = 270;
            SetLocations();
        }

        public void TurnRight()
        {
            Perspective += 90;
            if (Perspective > 270)
                Perspective = 0;
            SetLocations();
        }
    }
}
