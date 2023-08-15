# Structs, Enumerations
## Enum
To declare an enum, use this :
```
public enum Rating
{
    Good,
    Great,
    Excellent
}
```
In this example, to read the values of a Rating rating, use :
```
Rating rating;

        rating = Rating.Great;

        Console.WriteLine(""rating);
        Console.WriteLine("(int)rating);
```
Output :
```
Great
1
```

## Structs
To declare a simple struct, use : 
```
struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
}
```

The constructor of a struct is called everytime a new struct instance is created using the keyword `new`.<br>
A constructor looks like this:
```
public Dog(string aName, float aAge, string aOwner)
    {
        name = aName;
        age = aAge;
        owner = aOwner;
    }
```
To call the constructor, use:
```
Dog dog1 = new Dog(args);
```

To override the `ToString` method in your class or struct:<br>
* Declare a ToString method with the following modifiers and return type:
```
public override string ToString()
{

}
```
* Implement the method so that it returns a string. For example:
```
public override string ToString()
{
    return "Person: " + Name + " " + Age;
}
```