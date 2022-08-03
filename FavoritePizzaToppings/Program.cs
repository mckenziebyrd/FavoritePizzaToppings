using FavoritePizzaToppings;
using Newtonsoft.Json;

//A pizza chain wants to know which topping combinations are most popular for Build Your Own pizzas.

//Given the sample of orders at [http://files.olo.com/pizzas.json](http://files.olo.com/pizzas.json), write an application (in C# or JavaScript)
//to output the top 20 most frequently ordered pizza configurations, listing the toppings for each along with the number of times that pizza configuration has been
//ordered.

//Check this link [to read a JSON file] (https://www.newtonsoft.com/json/help/html/DeserializeWithJsonSerializerFromFile.htm) in c#.
//You'll need to install the Newtonsoft.Json nuget package, and create a class that represents the pizzas.

//another possible way
// deserialize JSON directly from a file
//using (StreamReader file = File.OpenText(@"C:\Users\mckenziebyrd\source\repos\FavoritePizzaToppings\FavoritePizzaToppings\pizzas.json"))
//{
  //  JsonSerializer serializer = new JsonSerializer();
    //var pizzas2 = serializer.Deserialize(file, typeof(List<Pizza>)) as List<Pizza>;
//}

//one possible way to deserialize JSON
// read file into a string and deserialize JSON to a type
string jsonText = File.ReadAllText("C:\\Users\\mckenziebyrd\\source\\repos\\FavoritePizzaToppings\\FavoritePizzaToppings\\pizzas.json");
var pizzas = JsonConvert.DeserializeObject<List<Pizza>>(jsonText);


//for (int i = 0; i < pizzas.Count; i++)
//{
 //   Console.WriteLine(pizzas[i]);
//}


Dictionary<string, int> toppingCounter = new Dictionary<string, int>();

pizzas.ForEach(pizza =>
{
    string toppingsAsString = String.Join(",", pizza.Toppings.OrderByDescending(x => x));
    if (!toppingCounter.ContainsKey(toppingsAsString))
    {
        toppingCounter[toppingsAsString] = 1;
    }
    else
    {
        toppingCounter[toppingsAsString]++;
    }
});

var mostPopularPizza = toppingCounter.OrderByDescending(toppingCombo => toppingCombo.Value).Take(1).FirstOrDefault();
var mostTimesOrdered = toppingCounter.Max(item => item.Value);

Console.WriteLine($"The most popular pizza was ordred {mostTimesOrdered} times");
Console.WriteLine($"The most popular pizz is {mostPopularPizza.Key} and it was ordered {mostPopularPizza.Value} times");

Console.ReadLine();






