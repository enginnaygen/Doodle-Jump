using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temizleyici : MonoBehaviour
{
    //public Transform zemin1, zemin2, zemin3, zemin4;
    //public float yukar�1,yukar�2, yukar�3,yukar�4;
    private void OnTriggerEnter2D(Collider2D temas)
    {
        float xPozisyonu = Random.Range(-6, 7);

        if (temas.tag == "ultraz�plat�c�")

            temas.gameObject.transform.position = new Vector2(xPozisyonu, temas.transform.position.y + 50);


        if (temas.tag=="zemin")
        {
            //yukar�1 += Random.Range(11, 13);
            temas.gameObject.transform.position = new Vector2(xPozisyonu, temas.transform.position.y+Random.Range(11.5f,12.4f));

        }

        /*if (collision.tag=="zemin1")
        {
            yukar�1 += Random.Range(11,13);
            zemin1.position=new Vector2 (xPozisyonu, yukar�1);
        }
        if (collision.tag == "zemin2")
        {
            yukar�2 += Random.Range(11, 13);
            zemin2.position = new Vector2(xPozisyonu, yukar�2);
        }
        if (collision.tag == "zemin3")
        {
            yukar�3 += Random.Range(11, 13);
            zemin3.position = new Vector2(xPozisyonu, yukar�3);
        }
        if (collision.tag == "zemin4")
        {
            yukar�4 += Random.Range(11, 12.5f);
            zemin4.position = new Vector2(xPozisyonu, yukar�4);
        }*/

    }

    /*private void FixedUpdate()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.up*2;
    }*/
}
