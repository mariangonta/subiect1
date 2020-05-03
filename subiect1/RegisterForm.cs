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
    public partial class RegisterForm : Form
    {
        string invalidNameMessage = "Company name field must not be empty";
        string invalidPackageMessage = "You need to select a valid access package";

        List<AccessPackage> packages;
        List<RegistrationContainer> registrations;
        ListViewRegistrationUtility listViewRegistrationUtility;

        public RegisterForm(List<AccessPackage> packages, List<RegistrationContainer> registrations, ListViewRegistrationUtility listViewRegistrationUtility)
        {
            this.packages = packages;
            this.registrations = registrations;
            this.listViewRegistrationUtility = listViewRegistrationUtility;


            InitializeComponent();

            if (cb_accessPackage.Items.Count == 0)
            {
                foreach (var item in packages)
                {
                    cb_accessPackage.Items.Add("#" + item.Id + " | Name: " + item.Name + ", Price: " + item.Price);
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_companyName.Text.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show(invalidNameMessage, "Error", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK) return;
            }

            if (cb_accessPackage.SelectedIndex < 0) {
                DialogResult dialogResult = MessageBox.Show(invalidPackageMessage, "Error", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK) return;
            }
            
            registrations.Add(new RegistrationContainer(tb_companyName.Text, (int)nm_numberOfPasses.Value, packages[cb_accessPackage.SelectedIndex].Id));
           
            tb_companyName.Text = "";

            listViewRegistrationUtility.Refresh();
            tb_companyName.Focus();
            this.Owner.Refresh();
        }
        
        private void back_manager_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public List<RegistrationContainer> GetRegistrations()
        {
            return registrations;
        }
    }
}
