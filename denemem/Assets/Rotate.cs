using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float hiz = 10.0f;
    void Update()
    {
        transform.Rotate(0, hiz * Time.deltaTime, 0);
    }
    
}
