using System;


//This makes the class named Dog
namespace Dog
{
class bark
{
static void Main(string[] args)
{

//this creates the Dog Orian who is owned by Shawn 
Dog puppy = new Dog("Orian", "Shawn", 1, Gender.MALE); 

puppy.Bark(3); //Output will be Woof!Woof!Woof!

Console.WriteLine(puppy.GetTag());


//This creates the Dog Lileu who is owned by Dale
Dog myDog =  new Dog("Lileu", "Dale", 4, Gender.FEMALE); 

myDog.Bark(1); //Output will be Woof!

Console.WriteLine(myDog.GetTag());

Console.ReadLine();
}
}
}

namespace Dog

{
//used to declare male or female 
enum Gender { MALE, FEMALE};

//Class Dog class
class Dog

{
    //these are the public properties that are required
public string name;

public string owner;

public int age;

public Gender gender;

public Dog(string name,

string owner, int age, Gender gender)

{
this.name = name;

this.owner = owner;

this.age = age;

this.gender = gender;

}
//print woof number of times needed 
public void Bark(int n)

{

for (int index = 0; index < n; index++)

Console.Write("{0}", "Woof!");

Console.WriteLine();

}
//This retruns the owners name 
public String GetTag()

{
if (gender == Gender.MALE)

return String.Format("If lost, call {0}. His name is {1} and he is {2} year old.", owner, name, age);

else

return String.Format("If lost, call {0}. Her name is {1} and she is {2} year old.", owner, name, age);
}
}
}

