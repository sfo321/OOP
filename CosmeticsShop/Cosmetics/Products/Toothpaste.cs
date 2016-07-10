namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using System;
    using Cosmetics.Common;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Toothpaste : Product, IProduct, IToothpaste
    {
        private const int minLength = 4;
        private const int maxLength = 12;


        private IList<string> ingredients;


        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            if (ingredients.Any(x => x.Length > maxLength || x.Length < minLength))
            {
                throw new IndexOutOfRangeException
                    (String.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", minLength, maxLength));
            }
            this.ingredients = ingredients;
        }


        public string Ingredients
        {
            get
            {
                return string.Join(", ", this.ingredients);
            }
        }

        public override string Print()
        {
            var result = new StringBuilder();
            result.AppendLine(base.Print());
            result.Append(String.Format("  * Ingredients: {0}", this.Ingredients));
            return result.ToString();
        }
    }
}
