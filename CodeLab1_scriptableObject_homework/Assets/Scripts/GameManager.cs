using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI titleUI;
    public TextMeshProUGUI descriptionUI;

    public LocationScriptableObject currentLocation;
    
    // public ItemScriptableObject inventory;

    public Button buttonNorth;
    public Button buttonSouth;
    public Button buttonEast;
    public Button buttonWest;
    
    // Start is called before the first frame update
    void Start()
    {
        currentLocation.PrintLocation();
        currentLocation.UpdateCurrentLocation(this);
    }

    public void MoveDir(string dirChar)
    {
        switch (dirChar)
        {
            case "N":
                currentLocation = currentLocation.north;
                break;
            case "S":
                currentLocation = currentLocation.south;
                break;
            case "E":
                currentLocation = currentLocation.east;
                break;
            case "W":
                currentLocation = currentLocation.west;
                break;
            default:
                Debug.Log("Nope");
                break;
        }
        
        currentLocation.UpdateCurrentLocation(this);
    }
}
