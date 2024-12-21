namespace OnionAPI.Domain.Entities
{
    public class Product
    {
        Product(string name, decimal price)
        {

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
            { this.name = value; }
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
