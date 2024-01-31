using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temizleyici : MonoBehaviour
{
    //public Transform zemin1, zemin2, zemin3, zemin4;
    //public float yukarý1,yukarý2, yukarý3,yukarý4;
    private void OnTriggerEnter2D(Collider2D temas)
    {
        float xPozisyonu = Random.Range(-6, 7);

        if (temas.tag == "ultrazýplatýcý")

            temas.gameObject.transform.position = new Vector2(xPozisyonu, temas.transform.position.y + 50);


        if (temas.tag=="zemin")
        {
            //yukarý1 += Random.Range(11, 13);
            temas.gameObject.transform.position = new Vector2(xPozisyonu, temas.transform.position.y+Random.Range(11.5f,12.4f));

        }

        /*if (collision.tag=="zemin1")
        {
            yukarý1 += Random.Range(11,13);
            zemin1.position=new Vector2 (xPozisyonu, yukarý1);
        }
        if (collision.tag == "zemin2")
        {
            yukarý2 += Random.Range(11, 13);
            zemin2.position = new Vector2(xPozisyonu, yukarý2);
        }
        if (collision.tag == "zemin3")
        {
            yukarý3 += Random.Range(11, 13);
            zemin3.position = new Vector2(xPozisyonu, yukarý3);
        }
        if (collision.tag == "zemin4")
        {
            yukarý4 += Random.Range(11, 12.5f);
            zemin4.position = new Vector2(xPozisyonu, yukarý4);
        }*/

    }

    /*private void FixedUpdate()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.up*2;
    }*/
}
