namespace Paragraph;

public class MenuItem
{
    public string Name { get; }

    public double Price { get; }

    public MenuItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString() => $"{Price} - {Name}";
}
