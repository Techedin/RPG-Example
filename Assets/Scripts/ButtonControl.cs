﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonControl : MonoBehaviour
{
    // Start is called before the first frame update

    public ItemBarScript itemBar;
    public Button button;

   
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(itemBar.ButtonUpdate);
        button.onClick.AddListener(ButtonClicked);
       
    }

    public void ButtonClicked()
    {
        button.image.sprite = itemBar.selected;
    }
}
