namespace LearningClasses
{
    internal class Person
    {
        //Default parameterlee contructor 

        public Person()
        {

        }
        public Person(string n, string add, byte a)
        {
            this.Name = n;
            this.Address = add;
            this.Age = a;


        

        
    }
    public string Name{get;set;}

    public string Address{get; set;}

    public byte Age { get; set;}

    public static string scientificName = "Homo-sapiens";
    }
}

