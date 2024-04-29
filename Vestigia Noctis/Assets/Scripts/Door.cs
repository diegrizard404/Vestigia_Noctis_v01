using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] GameObject key;
    [SerializeField] GameObject door;

    public bool inside = false;

    private void Update()
    {


        if (inside && key.activeSelf == true)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {

                Destroy(key);
                door.SetActive(false);

            }

          
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            inside = true;
        }   
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            inside = false;
        }

    }


}
