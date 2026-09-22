Console.WriteLine("Hello, datastructures!");

string n1 = "Oliver";
string n2 = "Carl";

int i1 = 102;
int i2 = 21;
int i3 = 45;

int[] myArray = new int[3]; //Fixed size

myArray[0] = 102;
myArray[1] = 21;
myArray[2] = 45;

myArray[1] = 29;

myArray[2] = myArray[1] + 10;

Console.WriteLine(myArray[0] + " " + myArray[1] + " " + myArray[2]);
int sum = myArray[0] + myArray[1] + myArray[2];
Console.WriteLine("Summen er " + sum);


for(int i = 0; i<3; i++)
{
    Console.Write(myArray[i] + " " );
}
Console.WriteLine();

Console.WriteLine("Beregn summen af alle index positioner i myArray");

int result=0; 
for(int i =0; i < 3; i++)
{
    result = myArray[i] + result;
}
Console.WriteLine(" Summen er " + result);