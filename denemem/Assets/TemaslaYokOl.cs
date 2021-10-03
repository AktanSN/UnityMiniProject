using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TemaslaYokOl : MonoBehaviour
{
    public Text sayacText;
    int sayac=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "toplanan"){
            other.gameObject.SetActive(false);
            sayac++;

            sayacText.text= "Toplanan Obje= " + sayac;
            if(sayac==9){
                sayacText.text= "OYUN BİTTİ";
            }
        }
        
    }
}
