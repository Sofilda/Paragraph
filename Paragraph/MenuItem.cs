namespace Paragraph;

public class MenuItem
{
    public string Name { get; set; }
    public double Price { get; set; }

    public MenuItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString() => $"{Price} - {Name}";
}
