namespace Ecommerse_app_backend_app.Modals
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ProductCategpry ProductCategory { get; set; } = new ProductCategpry();
        public Offer Offer { get; set; } = new Offer();
        public double Price { get; set; }

        public int Qunatity { get; set; }

        public string ImageName { get; set; } = string.Empty; 
    }
}
