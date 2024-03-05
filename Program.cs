namespace OOP_Ex2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Card card1 = new Card("Red", 5);
            Console.WriteLine("Card\nColor: {0}. Number: {1}", card1.GetColor(), card1.GetNumber());

            Lamp lamp1 = new Lamp(true, "Green", 18000);
            Console.WriteLine("Lamp\nIs it on?: {0}. Color: {1}. Electric power: {2}kW", lamp1.GetIsOn(), lamp1.GetColor(), lamp1.GetPower());
        }
    }
}