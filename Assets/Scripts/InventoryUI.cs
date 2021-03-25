using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{


    public GameObject inventoryUI;  // The entire UI
    public Transform itemsParent;   // The parent object of all the items
    


    public Inventory inventory;	// Our current inventory



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateUI()
    {
        InventorySlots[] slots = GetComponentsInChildren<InventorySlots>();

        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }

    }


}
