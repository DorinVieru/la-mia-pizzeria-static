namespace la_mia_pizzeria_static.Models
{
    public class Pizze
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public float Price { get; set; }

        public Pizze() { }

        public Pizze(string name, string description, string img, float price)
        {
            this.Name = name;
            this.Description = description;
            this.Img = img;
            this.Price = price;
        }
    }
}
