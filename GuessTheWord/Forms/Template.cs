using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheWord.Forms
{
    public partial class Template : Form
    {
        private bool IsMouseDown = false;
        private Point LastLocation;

        public Template()
        {
            InitializeComponent();
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            LastLocation = e.Location;
        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if(IsMouseDown)
            {
                Location = new Point(this.Location.X + (e.Location.X - LastLocation.X), this.Location.Y + (e.Location.Y - LastLocation.Y));
            }
        }

        private void PanelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
