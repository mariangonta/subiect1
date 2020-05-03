using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subiect1
{
    public class Registration
    {
        public string CompanyName { get; set; }
        public int NoOfPasses { get; set; }
        public int AccessPackageId { get; set; }

        public Registration(string companyName, int noOfPasses, int accessPackageId)
        {
            this.CompanyName = companyName;
            this.NoOfPasses = noOfPasses;
            this.AccessPackageId = accessPackageId;
        }
    }
}
