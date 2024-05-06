using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy : MonoBehaviour
{
    movement KomponenGerak;
    // Start is called before the first frame update
    void Start()
    {
        KomponenGerak = GameObject.Find("human").GetComponent<movement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.tag == "Player") {
            KomponenGerak.nyawa--;
            KomponenGerak.balik = true;
        }
    }
}