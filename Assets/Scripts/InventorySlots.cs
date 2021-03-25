using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventorySlots : MonoBehaviour
{
	public Inventory inventory;
	public InventoryUI inventoryUI;

	public Image icon;          // Reference to the Icon image
	public Button removeButton; // Reference to the remove button

	Item item;  // Current item in the slot

    public void Awake()
    {
		
    }

    public void Update()
    {

		
    }

    // Add item to the slot
    public void AddItem(Item newItem)
	{
		item = newItem;

		icon.sprite = item.icon;
		icon.enabled = true;
		removeButton.interactable = true;
	}

	public void ClearSlot()
	{
		icon.sprite = null;
		icon.enabled = false;
		removeButton.interactable = false;
		item = null;
		
		
	}

	public void RemoveItem()
    {
		inventory.DeleteItem(item);
		inventoryUI.UpdateUI();
    }

	

}
