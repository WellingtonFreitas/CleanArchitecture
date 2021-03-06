namespace CleanArchtecture.Application.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
    }
}
