using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subiect1
{
    public class RegistrationContainer
    {
        public String Id { get; set; }

        public string CompanyName
        {
            get { return registration.CompanyName; }
            set { registration.CompanyName = value; }
        }
        public int NoOfPasses
        {
            get { return registration.NoOfPasses; }
            set { registration.NoOfPasses = value; }
        }
        public int AccessPackageId
        {
            get { return registration.AccessPackageId; }
            set { registration.AccessPackageId = value; }
        }
        
        Registration registration;

        public RegistrationContainer(Registration registration)
        {
            this.Id = Guid.NewGuid().ToString();
            this.registration = registration;
        }

        public RegistrationContainer(string companyName, int noOfPasses, int accessPackageId)
            : this(new Registration(companyName, noOfPasses, accessPackageId))
        {
                
        }
    }
}
