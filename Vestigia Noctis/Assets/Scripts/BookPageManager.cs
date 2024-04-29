using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPageManager : MonoBehaviour
{
    

    [SerializeField] private GameObject page0;
    [SerializeField] private GameObject page1;
    [SerializeField] private GameObject page2;
    [SerializeField] private GameObject page3;
    [SerializeField] private GameObject page4;

    private int list;

    public List<GameObject> pages = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        pages.Add(page0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
}
