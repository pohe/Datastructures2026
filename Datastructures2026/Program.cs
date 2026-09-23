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
