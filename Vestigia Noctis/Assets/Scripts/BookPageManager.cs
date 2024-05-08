using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPageManager : MonoBehaviour
{
    

    
    [SerializeField] private GameObject page1;
    [SerializeField] private GameObject page2;
    [SerializeField] private GameObject page3;
    [SerializeField] private GameObject page4;
    [SerializeField] private GameObject page5;

    private int paginaActual = 1;
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (paginaActual == 1)
        {
            page1.SetActive(true);
            page2.SetActive(false);

        }
        else if (paginaActual == 2)
        {
            page2.SetActive(true);
            page1.SetActive(false);
            page3.SetActive(false);
        }
        else if (paginaActual == 3)
        {
            page3.SetActive(true);
            page2.SetActive(false);
            page4.SetActive(false);

        }
        else if (paginaActual == 4)
        {
            page4.SetActive(true);
            page3.SetActive(false);
            page5.SetActive(false);
        }
        else if (paginaActual == 5)
        {
            page5.SetActive(true);
            page4.SetActive(false);
            
        }

        if (paginaActual <= 0)
            paginaActual = 1;
        else if (paginaActual >= 6)
            paginaActual = 5;

    }


    public void NextPage()
    {
        paginaActual++;
    }

    public void PrevPage() 
    { 
        paginaActual--;
    }
    /*
    public void ListaDeHojas()
    {
        pages.Add(page1);
        pages.Add(page2);
    }

    public void HojaActual()
    {
        foreach (GameObject go in pages) {print(go);}
        if (pages.Count == 0)
        {
            page0.SetActive(true);
            
        }
        else if (pages.Count == 1)
        {
            page1.SetActive(true);
            
        }
        else if (pages.Count == 2)
        {
            page2.SetActive(true);
            
        }
    }
    */
}
