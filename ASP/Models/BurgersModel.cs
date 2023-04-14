namespace ASP.Models
{
    public class BurgersModel
    {
        public string ImageTitle { get; set; }
        public string BurgerName { get; set; }
        public double BasePrice { get; set; } = 2; 
        public bool Tomato { get; set; }
        public bool Cheese { get; set; }
        public bool Pickles { get; set; }
        public bool Salad { get; set; }
        public bool onion { get; set; }
        public bool Meat { get; set; }
        public bool VegeMeat { get; set; }
        public bool Mushroom { get; set; }
        public bool Ham { get; set; }
        public double FinalPrice { get; set; }
        public bool Cola { get; set; }

    }
}
