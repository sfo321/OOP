namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using System;
    using Cosmetics.Common;
    using System.Text;

    internal abstract class Product : IProduct
    {
        private const int brandMinLength = 2;
        private const int nameMinLength = 3;
        private const int maxLength = 10;

        private string name;
        private string brand;
        public decimal Price { get; protected set; }
        public GenderType Gender { get; private set; }

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, maxLength, brandMinLength, String.Format(GlobalErrorMessages.InvalidStringLength,
                    "Product brand", brandMinLength, maxLength));
                this.brand = value;
            }
        }
      
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product name"));
                Validator.CheckIfStringLengthIsValid(value, maxLength, nameMinLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", nameMinLength, maxLength));
                this.name = value;
            }
        }

        public virtual string Print()
        {
            var result = new StringBuilder();
            result.AppendLine(String.Format("- {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(String.Format("  * Price: ${0}", this.Price));
            result.Append(String.Format("  * For gender: {0}", this.Gender));
            return result.ToString();
        }
    }
}
