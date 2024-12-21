namespace OnionAPI.Domain.Entities
{
    public class Product
    {
        public Product(int id,string name, decimal price)
        {
            // TODO: remove ID mapping id should be be param, should come from DB
            this.Id = id;
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
            {
                if(value <= 0)
                    throw new Exception("ID can't be 0 or less than 0");
                this.id = value; }
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
