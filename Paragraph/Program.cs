using Paragraph;

var items = new List<MenuItem>
{
    new("Espresso", 3.70),
    new("Double espresso", 4.20),
    new("Americano", 4.20),
    new("Lungo", 5.80)
};

var viewer = new ConsoleViewer();
viewer.AddToBasket(items[1], 2);
viewer.AddToBasket(items[3], 1);

Console.WriteLine($"\Total: {viewer.TotalPrice}");
