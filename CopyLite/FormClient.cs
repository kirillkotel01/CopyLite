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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        void ShowClient()

        {
            listViewClient.Items.Clear();
            foreach (SotrsSet sortSet in Program.wftDb.SotrsSet)

            {
                ListViewItem item = new ListViewItem(new string[]

                {
                    sortSet.Id.ToString(),sortSet.FirstName, sortSet.MiddleName,
                    sortSet.LastName, sortSet.Phone, sortSet.DolsName
                });
                item.Tag = sortSet;
               listViewClient.Items.Add(item);

            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SotrsSet sotrsSet = new SotrsSet();
            sotrsSet.FirstName = textBoxFirstName.Text;
            sotrsSet.MiddleName = textBoxMiddleName.Text;
            sotrsSet.LastName = textBoxLastName.Text;
            sotrsSet.Phone = textBoxPhone.Text;
            sotrsSet.DolsName = textBoxDols.Text;
            Program.wftDb.SotrsSet.Add(sotrsSet);
            Program.wftDb.SaveChanges();
            ShowClient();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (listViewClient.SelectedItems.Count == 1)

            {
                SotrsSet sotrsSet = listViewClient.SelectedItems[0].Tag as SotrsSet;
                sotrsSet.FirstName = textBoxFirstName.Text;
                sotrsSet.MiddleName = textBoxMiddleName.Text;
                sotrsSet.LastName = textBoxLastName.Text;
                sotrsSet.Phone = textBoxPhone.Text;
                sotrsSet.DolsName = textBoxDols.Text;
                Program.wftDb.SaveChanges();
                ShowClient();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)

                {
                    SotrsSet clientSet = listViewClient.SelectedItems[0].Tag as SotrsSet;
                    Program.wftDb.SotrsSet.Remove(clientSet);
                    Program.wftDb.SaveChanges();
                    ShowClient();
                }

                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxDols.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                SotrsSet clientSet = listViewClient.SelectedItems[0].Tag as SotrsSet;
                textBoxFirstName.Text = clientSet.FirstName;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxLastName.Text = clientSet.LastName;
                textBoxPhone.Text = clientSet.Phone;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }
    }
}
