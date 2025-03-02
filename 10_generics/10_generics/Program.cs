var cats = new List<Cat>();

cats.Add(new Cat { Name = "Fluffy" });
cats.Add(new Cat { Name = "Whiskers" });

Console.WriteLine($"Count of cats is: {cats.Count}");

foreach (var cat in cats)
{
    Console.WriteLine($"The name of the cat is: {cat.Name}");
}

public class Cat
{
    public string Name { get; set; }
}












//var logger = new Logger();

//var cat = new Cat { Name = "Fluffy", Age = "2" };
//var dog = new Dog { Name = "Rex", Breed = "Golden Retriever" };

//logger.Log(cat);
//Console.WriteLine();

//logger.Log(dog);
//Console.WriteLine();

//logger.Log<Dog>(dog);
//Console.WriteLine();

//public class Logger
//{
//    public void Log(Cat animal)
//    {
//        Console.WriteLine($"The name is: {animal.Name}");
//        Console.WriteLine("The animal is: Cat");
//    }

//    public void Log(Dog animal)
//    {
//        Console.WriteLine($"The name is: {animal.Name}");
//        Console.WriteLine("The animal is: Dog");
//    }

//    public void Log<TAnimal>(TAnimal animal) where TAnimal : Animal
//    {
//        Console.WriteLine($"This method uses generic type");
//        Console.WriteLine($"The name is: {animal.Name}");
//        Console.WriteLine($"The animal is: {typeof(TAnimal)}");
//    }
//}

//public class Dog : Animal
//{
//    public string Breed { get; init; }
//}

//public class Cat : Animal
//{
//    public string Age { get; init; }
//}

//public abstract class Animal
//{
//    public string Name { get; init; }
//}












//var logger = new AnimalLogger();

//var cat = new Cat { Name = "Fluffy", Age = "2" };
//var dog = new Dog { Name = "Rex", Breed = "Golden Retriever" };

//logger.Log<Cat, string>(cat, "test");
//logger.Log<Dog, int>(dog, 123);

//public class AnimalLogger
//{
//    public void Log<TFirst, TSecond>(TFirst animal, TSecond value) where TFirst : Animal
//    {
//        Console.WriteLine($"The name is: {animal.Name}");
//        Console.WriteLine($"The type of value is: {value.GetType()}");
//    }
//}

//public class Dog : Animal
//{
//    public string Breed { get; init; }
//}

//public class Cat : Animal
//{
//    public string Age { get; init; }
//}

//public abstract class Animal
//{
//    public string Name { get; init; }
//}

















//var logger = new AnimalLogger();

//var cat = new Cat { Name = "Fluffy", Age = "2" };
//var dog = new Dog { Name = "Rex", Breed = "Golden Retriever" };

//logger.Log<Cat>(cat);
//logger.Log<Dog>(dog);

//public class AnimalLogger
//{
//    public T Log<T>(T animal) where T : Animal
//    {
//        Console.WriteLine($"The type is: {typeof(T)}");
//        Console.WriteLine($"The name is: {animal.Name}");

//        return animal;
//    }
//}

//public class Dog : Animal
//{
//    public string Breed { get; init; }
//}

//public class Cat : Animal
//{
//    public string Age { get; init; }
//}

//public abstract class Animal
//{
//    public string Name { get; init; }
//}












//var cats = new List<Cat>();
//var dogs = new List<Dog>();

//cats.Add(new Cat { Name = "Fluffy" });
//cats.Add(new Cat { Name = "Whiskers" });

//dogs.Add(new Dog { Species = "Canis lupus familiaris" });

//Console.WriteLine($"Count of cats: {cats.Count}");
//Console.WriteLine($"Count of dogs: {dogs.Count}");

//foreach (var cat in cats.GetItems())
//{
//    Console.WriteLine($"A name of the cat is: {cat.Name}");
//}

//foreach (var dog in dogs.GetItems())
//{
//    Console.WriteLine($"A species of the dog is: {dog.Species}");
//}

//public class List<T>
//{
//    public int Count { get; private set; }

//    private T[] _items = new T[1000];

//    public T[] GetItems()
//    {
//        var arr = new T[Count];
//        Array.Copy(_items, arr, Count);

//        return arr;
//    }

//    public void Add(T item)
//    {
//        if (Count < 1000)
//        {
//            _items[Count] = item;
//            Count++;
//        }
//    }
//}

//public class Cat
//{
//    public string Name { get; set; }
//}

//public class Dog
//{
//    public string Species { get; set; }
//}












//var cats = new CatList();

//cats.Add(new Cat { Name = "Fluffy" });
//cats.Add(new Cat { Name = "Whiskers" });

//Console.WriteLine($"Count of elements: {cats.Count}");

//foreach (var cat in cats.GetItems())
//{
//    Console.WriteLine($"A name of the cat is: {cat.Name}");
//}

//public class CatList
//{
//    public int Count { get; private set; }

//    private Cat[] _items = new Cat[1000];

//    public Cat[] GetItems()
//    {
//        var arr = new Cat[Count];
//        Array.Copy(_items, arr, Count);

//        return arr;
//    }

//    public void Add(Cat item)
//    {
//        if (Count < 1000)
//        {
//            _items[Count] = item;
//            Count++;
//        }
//    }
//}

//public class Cat
//{
//    public string Name { get; set; }
//}

//public class Dog
//{
//    public string Species { get; set; }
//}











//var list = new List();

//list.Add(new Cat { Name = "Fluffy" });
//list.Add(new Cat { Name = "Whiskers" });
//list.Add(new Dog { Species = "Canis lupus familiaris" });

//Console.WriteLine($"Count of elements: {cats.Count}");

//foreach (var animal in list.GetItems())
//{
//    Console.WriteLine($"{animal.GetType()}");
//}

//public class List
//{
//    public int Count { get; private set; }

//    private object[] _items = new object[1000];

//    public object[] GetItems()
//    {
//        var arr = new object[Count];
//        Array.Copy(_items, arr, Count);

//        return arr;
//    }

//    public void Add(object item)
//    {
//        if (Count < 1000)
//        {
//            _items[Count] = item;
//            Count++;
//        }
//    }
//}

//public class Cat
//{
//    public string Name { get; set; }
//}

//public class Dog
//{
//    public string Species { get; set; }
//}
