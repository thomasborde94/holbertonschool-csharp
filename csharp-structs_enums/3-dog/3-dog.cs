using System;

public enum Rating
{
    Good,
    Great,
    Excellent
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string aName, float aAge, string aOwner, Rating aRating)
    {
        name = aName;
        age = aAge;
        owner = aOwner;
        rating = aRating;
    }

    public override string ToString()
    {
        return "Dog Name: " + name + "\nAge: " + age + "\nOwner: " + owner + "\nRating: " + rating;
    }
}