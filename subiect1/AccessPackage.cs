using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subiect1
{
    public class AccessPackage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public AccessPackage(int id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
    }
}
