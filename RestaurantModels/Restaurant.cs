using System;
using System.Collections.Generic;
namespace RestaurantModels;

public class Restaurant
{
    public string Name { get; set; }
    private double _Rating;

    //rating
    public double Rating
    {
        get => _Rating;
        set
        {
            if (value <= 5.0)
                _Rating = value;
            else
            {
                throw new Exception("Rating invalid");
            }
        }
        
    }
    
    //
    
    
}