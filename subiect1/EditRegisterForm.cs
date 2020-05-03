using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subiect1
{
    public partial class EditRegisterForm : Form
    {
        string invalidNameMessage = "Company name field must not be empty";
        string invalidPackageMessage = "You need to select a valid access package";

        List<AccessPackage> packages;
        RegistrationContainer registration;
        ListViewRegistrationUtility listViewRegistrationUtility;

        public EditRegisterForm(List<AccessPackage> packages, RegistrationContainer registration, ListViewRegistrationUtility listViewRegistrationUtility)
        {
            this.packages = packages;
            this.registration = registration;
            this.listViewRegistrationUtility = listViewRegistrationUtility;

            InitializeComponent();
            
            tb_companyName.Text = registration.CompanyName;
            nm_numberOfPasses.Value = registration.NoOfPasses;
            
            if (cb_accessPackage.Items.Count == 0)
            {
                for (int i = 0; i < packages.Count; i++)
                {
                    var item = packages[i];
                    cb_accessPackage.Items.Add("#" + item.Id + " | Name: " + item.Name + ", Price: " + item.Price);

                    if(item.Id == registration.AccessPackageId) {
                        cb_accessPackage.SelectedIndex = i;
                    }
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (tb_companyName.Text.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show(invalidNameMessage, "Error", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK) return;
            }

            if (cb_accessPackage.SelectedIndex < 0)
            {
                DialogResult dialogResult = MessageBox.Show(invalidPackageMessage, "Error", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK) return;
            }

            registration.CompanyName = tb_companyName.Text;
            registration.NoOfPasses = (int)nm_numberOfPasses.Value;
            registration.AccessPackageId = packages[cb_accessPackage.SelectedIndex].Id;
            
            tb_companyName.Focus();
            listViewRegistrationUtility.Refresh();
            this.Owner.Refresh();
        }

        private void back_manager_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public RegistrationContainer GetRegistrations()
        {
            return registration;
        }
    }
}
