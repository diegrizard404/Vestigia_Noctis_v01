using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerMenuGameplay : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject optionsMenu;
    [SerializeField] GameObject bookMenu;
    [SerializeField] PlayerMovement playerMove;
    [SerializeField] DragMouse dragMouse;
    [SerializeField] private bool marca = false;
    [SerializeField] public bool dragMode = false;

    private float timer = 0f;
    private float limit = .1f;
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            marca = !marca;
            pauseMenu.SetActive(marca);
            if (marca)
            {
                playerMove.moveSpeed = 0;
               

                timer = Time.deltaTime;

                if (timer == limit)
                {
                    playerMove.enabled = false;


                    timer = 0f;


                }
                if (dragMouse.enabled == true)
                {
                    dragMouse.enabled = false;
                    dragMode = true;
                }
            }
            else if (!marca)
            {
                playerMove.enabled = true;
                playerMove.moveSpeed = 10f;
                if (dragMode == true)
                {
                    dragMouse.enabled = true;
                }
                
            }
          
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            
            bookMenu.SetActive(true);
        }
    }
    public void Resume()
    {
        marca = !marca;
        pauseMenu.SetActive(false);
        playerMove.enabled = true;
        playerMove.moveSpeed = 10f;

        if (dragMode == true)
        {
            dragMouse.enabled = true;
        }

    }

    public void OptionsMenuOpen()
    {
        optionsMenu.SetActive(true);
    }
    public void OptionsMenuClose()
    {
        optionsMenu.SetActive(false);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BookMenuClose()
    {
        bookMenu.SetActive(false); 
    }

}
