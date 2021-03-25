using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPIckup : Interactable
{
	public Item item;   // Item to put in the inventory on pickup
	public override void Interact()
    {
        base.Interact();

        PickUp();
    }

	public void PickUp()
	{
		
		 inv.AddItem(item);

		if(inv.pickedUp == true)
        {
			Destroy(gameObject);
        }
			  
	}
}
