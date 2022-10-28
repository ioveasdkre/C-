using Example.Helper;
using Example.Model;

Person obj = new Person("Ron", 20);
var reflectionHelper = new ReflectionHelper();
var dog = reflectionHelper.Mapping<Animal, Person>(obj);

Console.WriteLine(dog);
Console.ReadLine();