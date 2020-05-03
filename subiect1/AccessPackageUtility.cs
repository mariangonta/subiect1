using System;

namespace subiect1
{
    class AccessPackageUtility
    {
        public AccessPackage Convert(string record)
        {
            string[] items = record.Split('\t');

            if (items.Length != 3) return null;

            string idStr = items[0];
            string name = items[1];
            string priceStr = items[2];

            int id;
            double price;
            bool tryId = int.TryParse(idStr, out id);
            if (!tryId) return null;

            bool tryPrice = double.TryParse(priceStr, out price);
            if (!tryPrice) return null;

            return new AccessPackage(id, name, price);
        }
    }
}