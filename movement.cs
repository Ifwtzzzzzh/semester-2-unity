using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public int kecepatan;
    Rigidbody2D lompat;
    public int kekuatanlompat;
    public int pindah;
    public bool balik;
    public int nyawa;
    public bool ulang;
    Vector2 mulai;

    // Start is called before the first frame update
    void Start()
    {
        lompat = GetComponent<Rigidbody2D>();
        mulai = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (ulang == true) {
            transform.position = mulai;
            ulang = false;
        }

        if (nyawa <= 0) {
            Destroy(gameObject);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
            pindah = 1;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right *- kecepatan * Time.deltaTime);
            pindah = -1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            lompat.AddForce(new Vector2(0, kekuatanlompat));
        }

        if (pindah < 0 && !balik)
        {
            balikbadan();
        }

        else if (pindah > 0 && balik)
        {
            balikbadan();
        }
    }

    void balikbadan()
    {
        balik = !balik;
        Vector3 karakter = transform.localScale;
        karakter.x *= -1;
        transform.localScale = karakter;
    }
}
