namespace CashRegister;

class Program   
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cash Register");

            Bin myBin = new("quarter", 40, (float)0.25);
            myBin.ModifyAmount(+6);
            Console.WriteLine(myBin.TotalValue());