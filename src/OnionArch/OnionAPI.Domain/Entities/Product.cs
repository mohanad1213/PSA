namespace OnionAPI.Domain.Entities
{
    public class Product
    {

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        private int id;

        private string name;

        private decimal price;

        public int Id
        {
            get
            { return id; }
            set
            { this.id = value; }
        }


        public string Name
        {
            get
            { return name; }
            set
            {
                if (value.Length > 20)
                    throw new Exception("Product Name can't be more than 20 chars");
                else
                    this.name = value;
            }
        }


        public decimal Price
        {
            get
            { return price; }
            set
            { this.price = value; }
        }
    }

}
