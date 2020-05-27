using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "Sotr") buttonOpenSotr.Enabled = false;
            if (FormAuthorization.users.type == "chet") buttonOpenClient.Enabled = false;
        }

        private void buttonOpenSotr_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenYcet_Click(object sender, EventArgs e)
        {
            Form clientSet = new ClientSet();
            clientSet.Show();
        }

        private void buttonActive_Click(object sender, EventArgs e)
        {
            Form ActZakaz = new ActZakaz();
            ActZakaz.Show();
        }
    }
}