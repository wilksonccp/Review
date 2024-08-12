using System.Globalization;

namespace ReviewStore;

public class Product
{
    public string Name;
    public double Price;
    public int Amount;

    public double StockValue()
    {
        return Price * Amount;
    }
    public void AddProdc(int quantity)
    {
        Amount += quantity;
    }
    public void RemvProdc(int quantity)
    {
        Amount -= quantity;
    }

    public override string ToString()
    {
        CultureInfo Culture = CultureInfo.InvariantCulture;
        return $"{Name} R$ {Price}, {Amount} unidades, Total R$ {StockValue().ToString("F2", Culture)}";
    }
}
