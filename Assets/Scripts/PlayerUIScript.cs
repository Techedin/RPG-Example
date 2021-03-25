using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIScript : MonoBehaviour
{
    public GameObject PlayerUI;
    public GameObject PlayerInventory;

    public InventoryUI inventoryUI;
  

    private bool ItemBarActive;

    // Start is called before the first frame update
    void Awake()
    {
      
        PlayerInventory.SetActive(false);
        
       
    }

    // Update is called once per frame
    void Update()
    {
       
        ItemBarActive = PlayerInventory.activeInHierarchy;
        if(ItemBarActive == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                inventoryUI.UpdateUI();

                PlayerUIControl(ItemBarActive = false);

            }

        }
        else
        {
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                inventoryUI.UpdateUI();
                PlayerUIControl(ItemBarActive = true);
               
            }
        }

        
    }

    public void PlayerUIControl(bool ItemBarActive )
    {
        if (ItemBarActive == true)
        {
            PlayerInventory.SetActive(false);
        }
        else
        {
            PlayerInventory.SetActive(true);
        }


    }




}
