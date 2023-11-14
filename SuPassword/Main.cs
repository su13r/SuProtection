using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuPassword
{
    public partial class Main : Form
    {
        public static Main Instance;
        public static String MAIN_KEY = "";
        public Main()
        {
            InitializeComponent();
        }
        public Enter enter = new Enter();
        private void Main_Load(object sender, EventArgs e)
        {
            Instance = this;
            enter.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(enter);
        }


        public static class Style
        {
            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            public static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
        }

    }
}
