
int iSodaStockVal = 100;
int iChipsStockVal = 40;
int iCandyStockVal = 60;

int iSodaRestockVal = 40;
int iChipsRestockVal = 20;
int iCandyRestockVal = 40;

int iSodaInput;
int iChipsInput;
int iCandyInput;

string sHighValueEntry = "That value is too high. Stock not adjusted\n";
string sItemNeedsRestock = "";
int iRemainingStock = 0;

Console.WriteLine("Welcome to the restocking tool.\n");

//Soda
Console.WriteLine("How many Sodas have been sold today? " + iSodaStockVal + " are in stock");
if (int.TryParse(Console.ReadLine(), out iSodaInput))
{
    if (iSodaInput < iSodaStockVal)
    {
        //calculate soda stock
        if ((iSodaStockVal - iSodaInput) <= iSodaRestockVal)
        {
            sItemNeedsRestock = sItemNeedsRestock + "Soda needs to be restocked\n";
        }
        iRemainingStock = iSodaStockVal - iSodaInput;
        Console.WriteLine("There are " + iRemainingStock + " Sodas left\n");
    }
    else
    {
        //Input to high
        Console.WriteLine(sHighValueEntry);
    }
}
else
{
    //input exception do nothing
    //must not be a valid number entry
}

//Chips
Console.WriteLine("How many Chips have been sold today? " + iChipsStockVal + " are in stock");
if (int.TryParse(Console.ReadLine(), out iChipsInput))
{
    if (iChipsInput < iChipsStockVal)
    {
        //calculate chips stock
        if ((iChipsStockVal - iChipsInput) <= iChipsRestockVal)
        {
            sItemNeedsRestock = sItemNeedsRestock + "Chips needs to be restocked\n";
        }
        iRemainingStock = iChipsStockVal - iChipsInput;
        Console.WriteLine("There are " + iRemainingStock + " Chips left\n");
    }
    else
    {
        //Input to high
        Console.WriteLine(sHighValueEntry);
    }
}
else
{
    //input exception do nothing
    //must not be a valid number entry
}

//Candy
Console.WriteLine("How many Candy have been sold today? " + iCandyStockVal + " are in stock");
if (int.TryParse(Console.ReadLine(), out iCandyInput))
{
    if (iCandyInput < iCandyStockVal)
    {
        //calculate candy stock
        if ((iCandyStockVal - iCandyInput) <= iCandyRestockVal)
        {
            sItemNeedsRestock = sItemNeedsRestock + "Candy needs to be restocked\n";
        }
        iRemainingStock = iCandyStockVal - iCandyInput;
        Console.WriteLine("There are " + iRemainingStock + " Candys left\n");
    }
    else
    {
        //Input to high
        Console.WriteLine(sHighValueEntry);
    }

}
else
{
    //input exception do nothing
    //must not be a valid number entry
}

Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");
//results from each entry get displayed here.
if (sItemNeedsRestock != "")
{
    Console.WriteLine(sItemNeedsRestock);
}

Console.WriteLine("\nGoodbye!");
Console.ReadKey();
