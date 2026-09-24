using Datastructures2026;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

Console.WriteLine("Hello, datastructures!");

//string n1 = "Oliver";
//string n2 = "Carl";

//int i1 = 102;
//int i2 = 21;
//int i3 = 45;



//int[] myArray = new int[3]; //Fixed size

//myArray[0] = 102;
//myArray[1] = 21;
//myArray[2] = 45;

//myArray[1] = 29;

//myArray[2] = myArray[1] + 10;

//Console.WriteLine(myArray[0] + " " + myArray[1] + " " + myArray[2]);
//int sum = myArray[0] + myArray[1] + myArray[2];
//Console.WriteLine("Summen er " + sum);


//for(int i = 0; i<3; i++)
//{
//    Console.Write(myArray[i] + " " );
//}
//Console.WriteLine();

//Console.WriteLine("Beregn summen af alle index positioner i myArray");

//int result=0; 
////for(int i =0; i < myArray.Length; i++)
////{
////    result = myArray[i] + result;
////}
//foreach( int num in myArray  )
//{
//    result = num + result; 
//}
//Console.WriteLine(" Summen er " + result);

////Console.WriteLine(myArray[3]);


//string[] names = new string[3];
//names[0] = "Oliver";
//names[1] = "Carl";
//names[2] = "Wiktor";

//foreach( string name in names)
//{
//    Console.WriteLine(name);
//}

//string searchName = "Ixping";
//bool testResult = false; 
//for(int i = 0; i<names.Length; i++)
//{
//    if (names[i] == searchName )
//    {
//        //Console.WriteLine($" {searchName} findes");
//        testResult = true; 
//        break;
//    }
//}
//if ( testResult )
//{
//    Console.WriteLine($" {searchName} findes");
//}
//else
//    Console.WriteLine($" {searchName} findes ikke");


List<int> myFirstList = new List<int>();

myFirstList.Add(10);
myFirstList.Add(15); //Tilføjer bagerst i listen
myFirstList.Add(27);
myFirstList.Insert(2, 45);
myFirstList.Remove(15);
myFirstList.RemoveAt(1);
myFirstList[1] = 13;

myFirstList.Add(97);


Console.WriteLine(myFirstList[1]);
foreach(int item in myFirstList)
{
    Console.Write(item + " ");
}
Console.WriteLine();

//int counter = 0;
//foreach(int item in myFirstList)
//{
//    Console.WriteLine($"{counter} : {item}");
//    counter++;

//}

for(int i = 0; i<myFirstList.Count; i++)
{
    Console.WriteLine($"{i} : {myFirstList[i]}");
}


List<string> names = new List<string>();

names.Add("Peter");
names.Add("Poul");
names.Insert(1, "Ole");

//names.Remove("Ole");

//Fjern alle forekomster af navnet Ole

//foreach(string name in names)
//{
//    if (name == "Ole")
//    {
//        names.Remove(name);
//    }
//}

for(int i = 0; i < names.Count; i++)
{
    if (names[i] == "Ole")
    {
        //names.Remove("Ole");
        names.RemoveAt(i);
        i--;
    }
}
Console.WriteLine("Efter fjernelse af Ole");
foreach(string n in names)
{
    Console.WriteLine(n);
}

List<Pizza> pizzas = new List<Pizza>();

//Lav 3 pizza objekter
Pizza p1 = new Pizza(1, "Magaritha", "Ost, Tomat", 90.5);
Pizza p2 = new Pizza(2, "Americano", "Kødsauce, tomat, ost", 88.5);
Pizza p3 = new Pizza(3, "Vegetarian", "Tomat, ost, rød peber, champingon", 74);

//Læg dem ind i listen

pizzas.Add(p1);
pizzas.Add(p2);
pizzas.Add(p3);

//skriv dem alle ud

foreach(Pizza aPizza in pizzas)
{
    Console.WriteLine(aPizza);
}

//find den samlede pris af alle pizzaer

double sum = 0;  
foreach(Pizza item in pizzas)
{
    sum = sum + item.Price;
}

Console.WriteLine($"Summen af alle pizzaer er {sum}");


//Find en pizza som indeholder champingon

foreach(Pizza pizza in pizzas)
{
    if ( pizza.Description.Contains("champingon") )
    {
        Console.WriteLine($"Der findes en pizza med champingon som er nummer {pizza.No}");
    }

}


Pizza? SearchPizza(int no)
{
    foreach(Pizza p in pizzas)
    {
        if (p.No == no)
        {
            return p;
        }
    }
    return null;
}

Pizza? foundPizza = SearchPizza(2);
if (foundPizza != null)
{
    Console.WriteLine($"fandt pizza med nummer 2 {foundPizza.ToString()}");
}

List<Pizza> FindAllPizzas(string ingridient)
{
    List<Pizza> foundPizzas = new List<Pizza>();

    //Loop og check om en pizza i pizzas indeholder en ingridient
    foreach(Pizza p in pizzas)
    {
        if (p.Description.Contains(ingridient))
        {
            foundPizzas.Add(p);
        }
    }
    return foundPizzas;
}

//Afprøv metoden FindAllPizzas
List<Pizza> pizzasWithIngridient = FindAllPizzas("Tomat");
Console.WriteLine("Alle pizzaer med tomat");
foreach(Pizza piz in pizzasWithIngridient)
{
    Console.WriteLine(piz);
}


Console.WriteLine("Udskrivning af bike");
Bicycle myBike = new Bicycle("1f34", "German classic", 7);
Bicycle myBike2 = new Bicycle("34gh", "CP Hipster", 11);
Bicycle myBike3 = new Bicycle("34gh", "Centurion", 18);
Console.WriteLine(myBike.ToString());

Dictionary<string, Bicycle> bicycles = new Dictionary<string, Bicycle>();//Key skal være unikt

bicycles.Add("1f34", myBike); //Alternativt kunne skrives bicycles.Add(myBike.SNO, myBike);

bicycles.Add("34gh", myBike2);//Adder en bicycle med givent SNO som key

//bicycles.Add("34gh", myBike3); //Ulovligt at added et objekt med samme key
bicycles["34gh"] = myBike3; //Overskriver det objekt der var på pladsen med key 34gh

Bicycle foundBike= bicycles["34gh"]; //returnerer bicycle

if (  !bicycles.ContainsKey("34gh")) //hvis der ikke findes et objekt med denne key
{
    bicycles.Add("34gh", myBike3);
}    