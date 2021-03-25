using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Allows for a global reference of Inventory 
    //but will break if another refernce is found



    public int space;
    public bool pickedUp;
    // Current list of items in inventory
    public List<Item> items = new List<Item>();
    public void Start()
    {
        space = 20;
        pickedUp = false;
    }
    public void AddItem(Item item)
    {
        if (items.Count >= space)
        {
            Debug.Log("Not enough room.");
            pickedUp = false;
        }
        else
        {
            Debug.Log("Picked Up");
            pickedUp = true;
            items.Add(item);
        } 
        
    }

    public void DeleteItem(Item item)
    {
        items.Remove(item);
        
    }
}
