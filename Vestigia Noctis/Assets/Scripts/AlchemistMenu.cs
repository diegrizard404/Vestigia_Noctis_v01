using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AlchemistMenu : MonoBehaviour
{
    [SerializeField] GameObject ruleta1;
    [SerializeField] GameObject ruleta2;
    [SerializeField] GameObject ruleta3;

    [SerializeField] GameObject key;
    ChekerAlchemist cheker;

    public bool check01;
    public bool check02;
    public bool check03;

    public bool drop;

    private void Start()
    {
       drop = false;
    }
    // Update is called once per frame
    void Update()
    {

        if (check01 && check02 && check03 && !drop)
        {
           key.SetActive(true);
            drop = true;
            
            check01 = false;
            check02 = false;
            check03 = false;
        }
    }

    public void RotationButton1()
    {
        if (!drop)
        ruleta1.transform.rotation = ruleta1.transform.rotation * Quaternion.Euler(0f, 0f, 120f);
    }

    public void RotationButton2()
    {
        if (!drop)
        ruleta2.transform.rotation = ruleta2.transform.rotation * Quaternion.Euler(0f, 0f, 120f);
    }

    public void RotationButton3()
    {
        if (!drop)
        ruleta3.transform.rotation = ruleta3.transform.rotation * Quaternion.Euler(0f, 0f, 120f);
    }

    

}
