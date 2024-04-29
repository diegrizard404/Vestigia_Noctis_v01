using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    Rigidbody2D rb;
    [SerializeField] private float speed = 10;


    private void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        //"posicion inicial menos posicion final" = a Direccion
        Vector3 direction = (player.transform.position - transform.position).normalized;
        rb.velocity = direction * speed;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
