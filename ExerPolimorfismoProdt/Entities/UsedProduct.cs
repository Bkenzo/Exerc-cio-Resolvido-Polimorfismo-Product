using System;
using System.Globalization;

namespace ExerPolimorfismoProdt.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }

        UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manuFactureDate)
        {
            ManuFactureDate = manuFactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (manufacture date: "
                + ManuFactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
