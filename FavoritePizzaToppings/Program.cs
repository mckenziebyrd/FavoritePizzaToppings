using FavoritePizzaToppings;
using Newtonsoft.Json;

//A pizza chain wants to know which topping combinations are most popular for Build Your Own pizzas.

//Given the sample of orders at [http://files.olo.com/pizzas.json](http://files.olo.com/pizzas.json), write an application (in C# or JavaScript)
//to output the top 20 most frequently ordered pizza configurations, listing the toppings for each along with the number of times that pizza configuration has been
//ordered.

//Check this link [to read a JSON file] (https://www.newtonsoft.com/json/help/html/DeserializeWithJsonSerializerFromFile.htm) in c#.
//You'll need to install the Newtonsoft.Json nuget package, and create a class that represents the pizzas.


//one possible way to deserialize JSON
// read file into a string and deserialize JSON to a type
string result = File.ReadAllText("C:\\Users\\Neal\\source\\repos\\E18\\FavoritePizzaToppings\\FavoritePizzaToppings\\pizzas (1).json");
var pizzas = JsonConvert.DeserializeObject<List<Pizza>>(result);

//another possible way
// deserialize JSON directly from a file
using (StreamReader file = File.OpenText(@"C:\Users\Neal\source\repos\E18\FavoritePizzaToppings\FavoritePizzaToppings\pizzas (1).json"))
{
    JsonSerializer serializer = new JsonSerializer();
    var pizzas2 = serializer.Deserialize(file, typeof(List<Pizza>)) as List<Pizza>;
}

Console.ReadLine();