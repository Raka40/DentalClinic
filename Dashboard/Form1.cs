using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        Controller.UserControlPendaftaran udpendaftaran = new Controller.UserControlPendaftaran();
        Controller.UserControlDashboard uddashboard = new Controller.UserControlDashboard();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uddashboard);
            uddashboard.Dock = DockStyle.Fill;

        }

        private void btnPendaftaran_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(udpendaftaran);
            udpendaftaran.Dock = DockStyle.Fill;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uddashboard);
            uddashboard.Dock = DockStyle.Fill;
        }

    
    }
}
