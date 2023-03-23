using Paragraph;

var items = new List<MenuItem>
{
    new("Эспрессо", 3.70),
    new("Двойной эспрессо", 4.20),
    new("Американо", 4.20),
    new("Австралийский лунго", 5.80)
};

Console.WriteLine(string.Join('\n', items));
