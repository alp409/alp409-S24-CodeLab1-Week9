using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "New Item",
    menuName = "New Item",
    order = 0)
]
public class ItemScriptableObject : ScriptableObject
{
    //public string itemName;
    
    public ItemScriptableObject item;
    public Sprite itemImage;
    
    public void UpdateInventory(GameManager gm)
    {
        if (item == null)
        {
            gm.buttonItem.gameObject.SetActive(false);
        }
        else
        {
            gm.buttonItem.gameObject.SetActive(true);
        }
    }
}


    
