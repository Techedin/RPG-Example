using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemBarScript : MonoBehaviour
{

    public Image[] itemBar;
    
    public Sprite selected;
    public Sprite unselected;
    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     private void Update()
    {
        ButtonActivation();
        
    }

    


    public void ButtonUpdate()
    {
        for (int i = 0; i < itemBar.Length; i++)
        {
            itemBar[i].sprite = unselected;
        }
    }

    public void ButtonActivation()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ButtonUpdate();
            itemBar[0].sprite = selected;


        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ButtonUpdate();
            itemBar[1].sprite = selected;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ButtonUpdate();
            itemBar[2].sprite = selected;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ButtonUpdate();
            itemBar[3].sprite = selected;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            ButtonUpdate();
            itemBar[4].sprite = selected;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            ButtonUpdate();
            itemBar[5].sprite = selected;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            ButtonUpdate();
            itemBar[6].sprite = selected;
        }
    }


}
