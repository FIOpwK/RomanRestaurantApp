using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq.Expressions;
namespace RestaurantModels;
public class Roman
{
    
    
    private Dictionary<Restaurant> _restDictionary;

    public Dictionary<Restaurant> Restaurant
    {
        get => _restDictionary;
        set
        {
            if (value.Count > 0) 
                // System.Console.WriteLine($"bool is: {value}");
                _restDictionary = value;
            else
                throw new ArgumentException("Reference Needed for this operation");


        }
    }

}
