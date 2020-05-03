using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace subiect1
{
    public class ListViewRegistrationUtility
    {
        AccessPackageLoader accessPackageLoader;
        private ListView listview;
        List<RegistrationContainer> registrations;

        string[] registrationArr = {
            "Id", "Name", "Passes", "Package","Price","Total"
        };

        public ListViewRegistrationUtility(
            ListView listview,
            AccessPackageLoader accessPackageLoader,
            List<RegistrationContainer> registrations)
        {
            this.listview = listview;
            this.accessPackageLoader = accessPackageLoader;
            this.registrations = registrations;

            Init();
        }

        void Init()
        {
            listview.Columns.AddRange(new ColumnHeader[] {
                new ColumnHeader(), new ColumnHeader(),
                new ColumnHeader(), new ColumnHeader(),
                new ColumnHeader(), new ColumnHeader() });

            int i = 0;

            listview.Columns[i].Text = registrationArr[i++];
            listview.Columns[i].Text = registrationArr[i++];
            listview.Columns[i].Text = registrationArr[i++];
            listview.Columns[i].Text = registrationArr[i++];
            listview.Columns[i].Text = registrationArr[i++];
            listview.Columns[i].Text = registrationArr[i];

            listview.View = View.Details;
        }

        void Add(string id, string name, int passes, string package, double price)
        {
            ListViewItem listLiewItem = new ListViewItem();
            listLiewItem.SubItems[0].Text = id;
            listLiewItem.SubItems.Add(name);
            listLiewItem.SubItems.Add(passes.ToString());
            listLiewItem.SubItems.Add(package);
            listLiewItem.SubItems.Add(price.ToString());
            listLiewItem.SubItems.Add((passes * price).ToString());

            listview.Items.Add(listLiewItem);
        }

        public void Refresh()
        {
            listview.Items.Clear();

            var packages = accessPackageLoader.GetPackages();

            int registrationsCount = registrations.Count;
            for (int i = 0; i < registrationsCount; i++)
            {
                var item = registrations[i];

                foreach (var package in packages)
                {
                    if (item.AccessPackageId != package.Id) continue;
                    Add(item.Id, item.CompanyName, item.NoOfPasses, package.Name, package.Price);
                    break;

                }
            }
        }


    }
}