using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public Collider target;
    private int numberOfHits = 0;

    void OnCollisionEnter(Collision collisionInfo)
    {
        print("ÇARPIŞMA GERÇEKLEŞTİ: " + gameObject.name + " VE " + collisionInfo.collider.name);
        print("ÇARPIŞMA NOKTASI SAYISI: " + collisionInfo.contacts.Length );
        print("HIZ: " + collisionInfo.relativeVelocity);
    }

    void OnTriggerEnter(Collider cubeTrigger)
    {
        if (cubeTrigger == target)
        {
            numberOfHits += 1;
            print("ÇARPIŞMA: " + numberOfHits + " KEZ GERÇEKLEŞTİ");
            

        }
    }


    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;

    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(v, h, 0);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -0.1f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0f, 0.1f, 0f);
        }
    }
    
}
