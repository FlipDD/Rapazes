using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform tran;
    BoxCollider c;
    Rigidbody r;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        tran = transform;
        c = GetComponent<BoxCollider>();
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            r.AddForce(transform.forward * 7500 * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S)){
            r.AddForce(transform.forward * 7500 * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)){
            r.AddTorque(tran.up * 2000000 * Time.deltaTime);

        }
        if(Input.GetKey(KeyCode.D)){
            r.AddTorque(tran.up * -2000000 * Time.deltaTime);
        }
        
    }
}
