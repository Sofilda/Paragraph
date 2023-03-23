namespace Paragraph;

public class ConsoleViewer
{
    private List<MenuItem> _basket = new();

    public double TotalPrice => _basket.Sum(i => i.Price);

    public void AddToBasket(MenuItem item, int count)
    {
        for (var i = 0; i < count; i++)
        {
            _basket.Add(item);
        }

        Console.WriteLine($"{item.Name} добавлено в корзину {count} раз.");
    }
}
