namespace CoffeeShopConsoleAppNet60;

public abstract class Coffee

{
    protected int Discount { get; private set; }
    public abstract string Strength();
    public virtual int price()
    {
        return 20 - Discount;
    }
    
    public Coffee()
        :this(0)
    {
    }
    
    public Coffee(int discount)
    {
        if (discount > 5)
            throw new ArgumentException("Not more than 5 dk in discount");

        if (discount < 0)
            throw new ArgumentException("discount may be between 1 and 5");

        this.Discount = discount;
    }
    
    public abstract string TypeOfCoffee();

    public override string ToString()
    {
        return $"I'm a {this.TypeOfCoffee()}, and my price is {this.price()}, and the strength of me is {this.Strength()}";
    }
    
}