namespace CoffeeShopConsoleAppNet60;

public class Cortado : Coffee, IMilk
{
        public Cortado()
            :base()
        {
        }

        public Cortado(int discount) 
            : base(discount)
        {
        }

        public int MlMilk()
        {
            return 40;
        }

        public override string TypeOfCoffee()
        {
            return "Cortado";
        }

        public override int price()
        {
            return 25 - base.Discount;
        }

        public override string Strength()
        {
            return "Medium";
        }
}