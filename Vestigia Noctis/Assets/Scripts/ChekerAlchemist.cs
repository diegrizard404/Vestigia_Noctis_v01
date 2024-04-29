using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekerAlchemist : MonoBehaviour
{
     public AlchemistMenu checker;


   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Symbol_2"))
        {
            checker.check02 = true;
            
        }
        if (collision.gameObject.CompareTag("Symbol_1"))
        {
            checker.check01 = true;
        }
        
        else if (collision.gameObject.CompareTag("Symbol_3"))
        {

            checker.check03 = true;

        }

        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Symbol_1"))
        {
            checker.check01 = false;
            
        }
        else if (collision.gameObject.CompareTag("Symbol_2"))
        {
            checker.check02 = false;
            
        }
        else if (collision.gameObject.CompareTag("Symbol_3"))
        {

            checker.check03 = false;

        }
    }
}
