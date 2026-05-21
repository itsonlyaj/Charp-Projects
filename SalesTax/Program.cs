namespace SalesTax;

class Program
{
    static void Main(string[] args)
    {
        double purchase;
        double stateSalesTax;
        double countyTax;
        double stateSalesTaxAmt;
        double countyTaxAmt;
        double taxTotal;
        double total;

        // What the sales and state tax will be when claculating.
        stateSalesTax = 0.30;
        countyTax =  0.23;

        Console.Write("What was your purchase amount: ");
        purchase = Convert.ToDouble(Console.ReadLine());

        // Calculations.
        stateSalesTaxAmt = purchase * stateSalesTax;
        countyTaxAmt = purchase * countyTax;
        taxTotal = stateSalesTaxAmt + countyTaxAmt;
        total = purchase + taxTotal;

        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Purchase: {purchase}$");
        Console.WriteLine($"Sales Tax: {stateSalesTaxAmt}$");
        Console.WriteLine($"County Tax: {countyTaxAmt}$");
        Console.WriteLine($"Total: {total}$");
        Console.WriteLine("---------------------------------");
    }
}
