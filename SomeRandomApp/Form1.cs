using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeRandomApp
{
    public partial class SomeRandomApp : Form
    {
        Random rng = new Random();
        string[] words = new string[] { "Heya", "It's fine", "Just give up", "Really, stop." };
        Color[] palette = new Color[] { Color.Blue, Color.CadetBlue, Color.Green, Color.IndianRed };

        public SomeRandomApp()
        {
            InitializeComponent();
            SetRngProps();
        }

        private void BouncingButton_MouseEnter(object sender, EventArgs e)
        {
            SetRngProps();
        }
        private void SetRngProps()
        {
            Thread.Sleep(100);
            BouncingButton.Height = rng.Next(25, 100);
            BouncingButton.Width = rng.Next(50, 150);
            BouncingButton.Location = new Point(rng.Next(0 + BouncingButton.Width, MainPanel.Width - BouncingButton.Width),
                rng.Next(0 + BouncingButton.Height, MainPanel.Height - BouncingButton.Height));
            BouncingButton.Text = words[rng.Next(0, words.Length - 1)];
            BouncingButton.BackColor = palette[rng.Next(0, palette.Length - 1)];
            BouncingButton.ForeColor = palette[rng.Next(0, palette.Length - 1)];
        }
    }
}
