using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altarManager : MonoBehaviour
{

    [SerializeField] GameObject key2;

    [SerializeField] GameObject vela1;
    [SerializeField] GameObject vela2;
    [SerializeField] GameObject vela3;
    [SerializeField] GameObject vela4;
    [SerializeField] GameObject vela5;
    
    private bool maracas1 = false;
    private bool maracas2 = false;
    private bool maracas3 = false;
    private bool maracas4 = false;
    private bool maracas5 = false;

    private void Update()
    {
        if (vela1.activeSelf == true && vela2.activeSelf == false && vela3.activeSelf == true && vela4.activeSelf == true && vela5.activeSelf == true)
        {
            key2.SetActive(true);
        }    
    }


    public void Fire1()
    {
        maracas1 = !maracas1;
        vela1.SetActive(maracas1);
    }

    public void Fire2()
    {
        maracas2 = !maracas2;
        vela2.SetActive(maracas2);
    }

    public void Fire3()
    {
        maracas3 = !maracas3;
        vela3.SetActive(maracas3);
    }

    public void Fire4()
    {
        maracas4 = !maracas4;
        vela4.SetActive(maracas4);
    }

    public void Fire5()
    {
        maracas5 = !maracas5;
        vela5.SetActive(maracas5);
    }

}
