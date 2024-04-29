using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] GameObject optionsMenu;
    [SerializeField] GameObject buttonMenu;
    public Animator animatorTitle;
    public Animator animatorButtons;

    private void Awake()
    {
        buttonMenu.SetActive(false);
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey) 
        {
            animatorTitle.SetBool("PressStart", true);
            buttonMenu.SetActive(true);
            animatorButtons.SetBool("PressStartB", true);
        }
    }


    public void StarGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OptionMenuOpen()
    {
        optionsMenu.SetActive(true);
    }
    public void OptionMenuClose()
    {
        optionsMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
