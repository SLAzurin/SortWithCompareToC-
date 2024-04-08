
using SortWithCompareTo;
class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = [645.41, 37.59, 76.41, 5.31, -34.23, 1.11, 1.10, 23.46, 635.47, -876.32, 467.83, 62.25];
        List<Person> people = [
            new Person{ Name = "Hal", Age = 20},
            new Person{ Name = "Susann", Age = 31},
            new Person{ Name = "Dwight", Age = 19},
            new Person{ Name = "Kassandra", Age = 21},
            new Person{ Name = "Lawrence", Age = 25},
            new Person{ Name = "Cindy", Age = 22},
            new Person{ Name = "Cory", Age = 27},
            new Person{ Name = "Mac", Age = 19},
            new Person{ Name = "Romana", Age = 27},
            new Person{ Name = "Doretha", Age = 32},
            new Person{ Name = "Danna", Age = 20},
            new Person{ Name = "Zara", Age = 23},
            new Person{ Name = "Rosalyn", Age = 26},
            new Person{ Name = "Risa", Age = 24},
            new Person{ Name = "Benny", Age = 28},
            new Person{ Name = "Juan", Age = 33},
            new Person{ Name = "Natalie", Age = 25}
        ];
        Console.WriteLine("\nCompare numbers in ascending order");
        numbers.Sort(CompareNumbersAscending);
        PrintNumbers(numbers);

        Console.WriteLine("\nCompare People by name alphabetically");
        people.Sort(ComparePeopleByName);
        PrintPeople(people);

        Console.WriteLine("\nCompare People by age alphabetically");
        people.Sort(ComparePeopleByAgeDescending);
        PrintPeople(people);
    }

    static int CompareNumbersAscending(double d1, double d2)
    {
        if (d1 == d2) return 0;
        if (d1 < d2) return -1;
        return 1;
    }
    static int ComparePeopleByName(Person p1, Person p2)
    {
        return string.Compare(p1.Name, p2.Name, comparisonType: StringComparison.Ordinal);
    }
    static int ComparePeopleByAgeDescending(Person p1, Person p2)
    {
        int comparison = 0;
        if (p1.Age < p2.Age) comparison = -1;
        if (p1.Age > p2.Age) comparison = 1;
        if (comparison == 0) return ComparePeopleByName(p1, p2);
        return comparison;
    }

    static void PrintNumbers(List<double> numbers)
    {
        Console.WriteLine("\nNumbers:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i].ToString());
        }
    }

    static void PrintPeople(List<Person> p)
    {
        Console.WriteLine("\nPeople:");
        for (int i = 0; i < p.Count; i++)
        {
            Console.WriteLine(p[i].Name + " " + p[i].Age.ToString());
        }
    }
}

