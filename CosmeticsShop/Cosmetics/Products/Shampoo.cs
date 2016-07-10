namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using System;
    using Cosmetics.Common;
    using System.Text;

    class Shampoo : Product, IShampoo, IProduct
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint mililiters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = mililiters;
            this.Usage = usage;
            this.Price *= mililiters;
        }

        public uint Milliliters { get; private set; }
        

        public UsageType Usage { get; private set; }
       

        public override string Print()
        {
            var result = new StringBuilder();

            result.AppendLine(base.Print());
            result.AppendLine(String.Format("  * Quantity: {0} ml", this.Milliliters));
            result.Append(String.Format("  * Usage: {0}", this.Usage));

            return result.ToString();
        }
    }
}
