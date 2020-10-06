class Person1
{
    public string name;
    byte age=23;
    // age variable with properties
    public byte Age
    {
        get
        {
            return age;

        }

        set 
        {
            if(value > 20 &&  value < 30)
                age = value;
        }

    }
    // Autoimplemented property
    public string Name {get; set;}
    // read only property
    public string Address {get;}



}