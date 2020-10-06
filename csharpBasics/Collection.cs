
using System.Collections.Generic;
public class Collection
{
    public void LearnAboutList()
    {
        List<string> names  = new List<string>() {"ram", "binod", "james"};

;        names.Add("sanam");
        names.Add("sanam");
        names.Add("sanam");
        names.Add("sanam");
        names.Sort();

    }

    public void LearnAboutDictionary()
    {
        // holds key value pair 
        // key must be unique 
        // initialization in first
        Dictionary<string,string> countryCapital = new Dictionary<string,string>()
        {
            ["japan"] = "tokyo",
            ["America"] = "Washigton"

        };
        
        countryCapital.Add("Nepal","kathmandu");
        countryCapital.Add("India","Delhi");
        countryCapital.Add("Bhutan","Dhaka");

    }
    



}