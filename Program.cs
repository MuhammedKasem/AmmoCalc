// Welcome to my CPR Calculator! Made by: Muhammed Kasem
using Terminal.Gui;

Console.WriteLine("Welcome to my CPR Calculator! Never overpay for ammo again! \n What is the round count per box of ammo you are trying to buy?");
// string readCount = Console.ReadLine();
// double roundCount = double.Parse(readCount);
double roundCount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("How many boxes will you be buying?");
int ammoBoxes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Okay Cool! What is the price per box?");
double roundPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the shipping cost?");
double shipCost = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Does the website charge sales tax? Press 1 for yes and enter for no:");
double taxAmount = 0.00;

string? input = Console.ReadLine();
if (int.TryParse(input, out int salesTax))
{
    if (salesTax == 1) {
        taxAmount = 0.0715;
        Console.WriteLine("Okay! NC sales tax was added to your total!");
        Console.WriteLine($"Your sales tax rate is 7.15%.");
    }
    /*else if (salesTax ==2) {
        taxAmount = 0;
        Console.WriteLine("Awesome! No sales tax was added to your total!");
    } */
}

//double costPerRound = Math.Round((roundPrice / roundCount) * (taxAmount +1),2);
double total_cost = Math.Round(((roundPrice * ammoBoxes) * (taxAmount + 1) + shipCost), 2);
double total_rounds = ammoBoxes * roundCount;
double costPerRound = Math.Round((total_cost / total_rounds),2);


Console.WriteLine($"The cost per round is {costPerRound} cents per round!");
Console.WriteLine($"Your total cost is ${total_cost}");
