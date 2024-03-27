class Person
{
    // Properties are auto-implemented.
    public string Name { get; set; }
    public int Age { get; set; }
}

// List initialization can be simplified using 'var' keyword.
var people = new List<Person>
{
    new Person { Name = "John", Age = 30 },
    new Person { Name = "Mary", Age = 25 },
    new Person { Name = "Bob", Age = 40 },
    new Person { Name = "Alice", Age = 35 },
};

// Grouping by age and projecting to a new type for better structure and readability.
var groupedPeople = people
    .GroupBy(p => p.Age)
    .Select(group => new 
    {
        Age = group.Key,
        Persons = group.ToList()
    }).ToList();

// Now 'groupedPeople' is a list of anonymous types with 'Age' and 'Persons' properties.
