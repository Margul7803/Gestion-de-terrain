using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projet_T_T
{
    public partial class Form1 : Form
    {
        private static Form1 instance;
        public static Form1 Instance
        {
            get 
            {
                if (instance == null)
                    instance = new Form1();
                return instance;
            }
        }

        public Panel pnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm logForm = new LoginForm();
            logForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(logForm);
        }
    }
}
