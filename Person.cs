namespace HelloApp
{
    public class Person
    {
        public Person()
        {

        }
        public Person(string id,string name, int age )
        {
            Name = name;
            Age = age;
            Id = id;
        }
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public int Age { get; set; }

    }
}
