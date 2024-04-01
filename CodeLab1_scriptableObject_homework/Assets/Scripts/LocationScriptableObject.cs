using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(
    fileName = "New Location", 
    menuName = "New Location", 
    order = 0)
]

public class LocationScriptableObject : ScriptableObject
{
    public string locationName;
    public string locationDesc;

    // below allows us to assign (or view automatically assigned) locations
    // to the north, south, east, or west of the current location
    public LocationScriptableObject north;
    public LocationScriptableObject south;
    public LocationScriptableObject east;
    public LocationScriptableObject west;
    
    // print a string of our locaiton and description in the console
    public void PrintLocation()
    {
        string printStr = "\nLocation Name: " + locationName +
                          "\nLocation Description: " + locationDesc;
    
        Debug.Log(printStr);
    }

    // always update the text UI for location and description (in the game manager) to our current locaiton
    public void UpdateCurrentLocation(GameManager gm)
    {
        gm.titleUI.text = locationName;
        gm.descriptionUI.text = locationDesc;
        
        
    }
}


