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