using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObj : MonoBehaviour
{
    [SerializeField] GameObject puzzleMenu;
    [SerializeField] PlayerMovement playerMove;
    [SerializeField] DragMouse dragMouse;
    [SerializeField] ManagerMenuGameplay dragmManager;
    [SerializeField] private bool inside = false;

    private float timer = 0f;
    private float limit = 0.2f;

    
    private void Update()
    {
        if (inside)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {

                playerMove.moveSpeed = 0f;
                puzzleMenu.SetActive(true);
                dragMouse.enabled = true;
                dragmManager.dragMode = true;


                timer = Time.deltaTime;

                if (timer == limit ) 
                {
                    playerMove.enabled = false;
                    

                    timer = 0f;

                   
                }
                
                
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            print("Colision");
            inside = true;
        }
        

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            print("exit");
            inside = false;
        }
    }

    public void ResetMenu()
    {
        playerMove.enabled = true;
        puzzleMenu.SetActive(false);
        playerMove.moveSpeed = 10;
        dragMouse.enabled = false;
        dragmManager.dragMode = false;
    }
}
