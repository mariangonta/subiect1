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
    public partial class MainForm : Form
    {
        List<RegistrationContainer> registrations;
        AccessPackageLoader accessPackageLoader;

        RegistrationUtility registrationUtility;
        ListViewRegistrationUtility listViewRegistrationUtility;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string accessPackagesFile = "AccessPackages.txt";
            bool ignoreFirstRow = true;

            registrations = new List<RegistrationContainer>();
            accessPackageLoader = new AccessPackageLoader();

            string result = accessPackageLoader.Populate(accessPackagesFile, ignoreFirstRow);

            if (result.Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show(result, "Error", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
            }

            registrationUtility = new RegistrationUtility();
            listViewRegistrationUtility = new ListViewRegistrationUtility(lv_registrations, accessPackageLoader, registrations);
            
        }
        
        private void btn_register_Click(object sender, EventArgs e)
        {
            using (RegisterForm registerForm = new RegisterForm(accessPackageLoader.GetPackages(), registrations, 
                    listViewRegistrationUtility))
            {
                var dialogResult = registerForm.ShowDialog(this);

                if (dialogResult == DialogResult.Cancel || dialogResult == DialogResult.OK)
                {
                    registerForm.Close();
                }
            }
        }


        private void lv_registrations_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                String index = lv_registrations.SelectedItems[0].SubItems[0].Text;

                RegistrationContainer registration = registrationUtility.GetRegistrationById(registrations, index);

                if (registration == null) return;

                using (EditRegisterForm editRegisterForm = 
                    new EditRegisterForm(accessPackageLoader.GetPackages(), registration, listViewRegistrationUtility))
                {
                    var dialogResult = editRegisterForm.ShowDialog(this);

                    if (dialogResult == DialogResult.Cancel || dialogResult == DialogResult.OK)
                    {
                        editRegisterForm.Close();
                    }
                }
            }
        }
        
        private void lv_deleteRegistrations_Click(object sender, EventArgs e)
        {
            if (lv_registrations.SelectedItems.Count == 0) return;

            String index = lv_registrations.SelectedItems[0].SubItems[0].Text;
            var result = registrationUtility.RemoveId(registrations, index);

            if (result) listViewRegistrationUtility.Refresh();
        }
        
        private int GetListViewIndex(MouseEventArgs e) {
            for (int i = 0; i < lv_registrations.Items.Count; i++)
            {
                var rectangle = lv_registrations.GetItemRect(i);
                if (rectangle.Contains(e.Location)) return i;
            }
            return -1;
        }
    }
}
