using Paragraph;

var items = new List<MenuItem>
{
    new("Эспрессо", 3.70),
    new("Двойной эспрессо", 4.20),
    new("Американо", 4.20),
    new("Австралийский лунго", 5.80)
};

var viewer = new ConsoleViewer();
viewer.AddToBasket(items[1], 2);
viewer.AddToBasket(items[3], 1);

Console.WriteLine($"\nИтого: {viewer.TotalPrice}");
