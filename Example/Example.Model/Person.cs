namespace Example.Model
{
    /// <summary>人類</summary>
    public class Person
    {
        /// <summary>名字</summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>年齡</summary>
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}