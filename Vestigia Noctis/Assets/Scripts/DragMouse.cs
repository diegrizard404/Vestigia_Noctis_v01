using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMouse : MonoBehaviour
{
    Rigidbody2D selectedRb;
    [SerializeField] private float speedMouse = 500f;
    

    void FixedUpdate()
    {
        if (selectedRb) 
        {
            Vector3 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - selectedRb.transform.position;
            selectedRb.velocity = dir * speedMouse * Time.fixedDeltaTime;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selectedRb = GetRigidbodyFromMouse();
           
           
        }

        if (Input.GetMouseButtonUp(0))
        {
            selectedRb = null;
            
        }

        
    }

    Rigidbody2D GetRigidbodyFromMouse()
    {
        Vector2 clickPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(clickPoint, Vector2.zero);

        if (hit)
        {
            
            if (hit.collider.gameObject.GetComponent<Rigidbody2D>() && hit.collider.transform.CompareTag("Puzzles"))
            {
                return hit.collider.gameObject.GetComponent<Rigidbody2D>();
               
            }
        }

        return null;
    }

    //Codigo sacado de: https://youtu.be/ww27noh4wRU?si=cwU6cWufpHLEU7Yk

}
