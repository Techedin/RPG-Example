using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Interactable interactable1;
    
    Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

             RaycastHit2D ray = Physics2D.GetRayIntersection(cam.ScreenPointToRay(Input.mousePosition));


            if (ray.collider != null)
            {
               
                Interactable interactable = ray.collider.GetComponent<Interactable>();
                if(interactable != null)
                {
                  
                    interactable.clicked = true;
                }
               
                
            }
            else
            {
             
                Debug.Log("FUCKIN HELL MAN");
            }

            

        }
    }

    
}
