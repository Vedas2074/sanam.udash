
public class Person
{
    public string firstname {get; set;}

    public string SurName {get; set;}

    public string Address { get; set;}

    public char Gender {get; set;} = 'M';

    public double Salary {get; set;}

    public Person(string fname,string lname, string Address, char gender, double salary)
    {
        this.firstname = fname;
        this.SurName = lname;
        this .Address = Address;
        this.Gender = gender;
        this.Salary = salary;
    }

    
    
}