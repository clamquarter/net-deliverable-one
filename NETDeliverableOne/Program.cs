// See https://aka.ms/new-console-template for more information
//declare variables for inventory current levels based on project guidelines starting stock
int sodaCurrentStock = 100;
int chipsCurrentStock= 40;
int candyCurrentStock = 60;

//declare variables for inventory restock levels based on project guidelines
int sodaRestockLevel = 40;
int chipsRestockLevel = 20;
int candyRestockLevel = 40;

//Soda Inventory Flow
//ask the user how many sodas have been bought
Console.WriteLine("How many Sodas have been sold today?");
//accept the users response and convert to an Int using int.Parse()
int purchasedSoda = int.Parse(Console.ReadLine());

//compare the user input to Sodas current stock, make updates to current stock if necessary, and advise the user
if (purchasedSoda > sodaCurrentStock)
//if the user input is greater than the current stock value, advise the user and don't update stock
{
    Console.WriteLine(purchasedSoda + " is too many! There are only " + sodaCurrentStock + " Sodas in stock.");

}else
//if the user input is less than the current stock value, update and advise the user of the updated stock
  {
    //subtract the purchased soda and update the sodaCurrentStock
    sodaCurrentStock -= purchasedSoda;
    Console.WriteLine("Thank you! There are now " + sodaCurrentStock + " Sodas left in stock.");

  }

//Chips Inventory Flow
//ask the user how many chips have been bought
Console.WriteLine("How many Chips have been sold today?");

//accept the users response and convert to an Int using int.Parse()
int purchasedChips = int.Parse(Console.ReadLine());

//compare the user input to Chips current stock, make updates to current stock if necessary, and advise the user
if (purchasedChips > chipsCurrentStock)
//if the user input is greater than the current stock value, advise the user and don't update stock
{
    Console.WriteLine(purchasedChips + " is too many! There are only " + chipsCurrentStock + " Chips in stock.");

}
else
//if the user input is less than the current stock value, update and advise the user of the updated stock
{
    //subtract the purchased soda and update the sodaCurrentStock
    chipsCurrentStock -= purchasedChips;
    Console.WriteLine("Thank you! There are now " + chipsCurrentStock + " Chips left in stock.");

}

//Candy Inventory Flow
//ask the user how much candy has been bought
Console.WriteLine("How many Candy have been sold today?");

//accept the users response and convert to an Int using int.Parse()
int purchasedCandy = int.Parse(Console.ReadLine());

//compare the user input to Candy current stock, make updates to current stock if necessary, and advise the user
if (purchasedCandy > candyCurrentStock)
//if the user input is greater than the current stock value, advise the user and don't update stock
{
    Console.WriteLine(purchasedCandy + " is too many! There are only " + candyCurrentStock + " Candy in stock.");

}
else
//if the user input is less than the current stock value, update and advise the user of the updated stock
{
    //subtract the purchased candy and update the candyCurrentStock
    candyCurrentStock -= purchasedCandy;
    Console.WriteLine("Thank you! There are now " + candyCurrentStock + " Candy left in stock.");

}

//Restock Flows


Console.WriteLine("Thank you for updating sales info. Here’s what needs to be restocked: ");
if (sodaCurrentStock < sodaRestockLevel)
{
    Console.WriteLine("Soda");
}

if (chipsCurrentStock < chipsRestockLevel)
{
    Console.WriteLine("Chips");
}

if (candyCurrentStock < candyRestockLevel)
{
    Console.WriteLine("Candy");
}




