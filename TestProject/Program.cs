string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine($"Dear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be ¤{newProfit:N2}.\n");
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = string.Format("{0,-18}{1,8}   ${2,15:N2}\n{3,-18}{4,8}   ${5,15:N2}",
    currentProduct, (currentReturn * 100).ToString("F2") + "%", currentProfit,
    newProduct, (newReturn * 100).ToString("F2") + "%", newProfit);

// Your logic here

Console.WriteLine(comparisonMessage);