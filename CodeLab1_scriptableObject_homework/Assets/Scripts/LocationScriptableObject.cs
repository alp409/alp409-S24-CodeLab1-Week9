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

    public ItemScriptableObject item;
    
    // print a string of our locaiton and description in the console
    public void PrintLocation()
    {
        string printStr = "\nLocation Name: " + locationName +
                          "\nLocation Description: " + locationDesc;
    
        //Debug.Log(printStr);
    }

    // always update the text UI for location and description (in the game manager) to our current location
    public void UpdateCurrentLocation(GameManager gm)
    {
        gm.titleUI.text = locationName;
        gm.descriptionUI.text = locationDesc;
        
        // check if there is a location to the north, south, east, and west
        // if not, turn off that button so that it can't be pressed, else turn it back on 
        
        // ALSO set the location "behind" (ie south to north, east to west) to location "this"
        // this will help automatically populate the map locations in relation to each other
        
        // NORTH
        if (north == null)
        {
            gm.buttonNorth.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonNorth.gameObject.SetActive(true);
            north.south = this;
        }

        // SOUTH
        if (south == null)
        {
            gm.buttonSouth.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonSouth.gameObject.SetActive(true);
            south.north = this;
        }
        
        // EAST
        if (east == null)
        {
            gm.buttonEast.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonEast.gameObject.SetActive(true);
            east.west = this;
        }

        // WEST
        if (west == null)
        {
            gm.buttonWest.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonWest.gameObject.SetActive(true);
            west.east = this;
        }
    }
}


