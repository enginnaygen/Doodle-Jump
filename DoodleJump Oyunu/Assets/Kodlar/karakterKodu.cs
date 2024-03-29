using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class karakterKodu : MonoBehaviour
{
    Rigidbody2D rb;
    public float zıplamaHızı;
    public float ultrazıplama;
    public float hareket;
    public float harekethızı;
    SpriteRenderer sr;
    public int skor, rekor;
    public Text skorYazısı, rekorYazısı;
    //public Transform[] foots;
    public Transform foot;
    public float distance;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        if (PlayerPrefs.HasKey("rekor"))
        {
            rekor = PlayerPrefs.GetInt("rekor");
            rekorYazısı.text = "rekor: " + rekor;

        }
        else
        { rekor = 0; }
    }

     private void OnCollisionEnter2D(Collision2D collision)
     {
         if (rb.velocity.y<=0 &&collision.gameObject.tag=="ultrazıplatıcı")
         {
             rb.velocity = new Vector2(0, ultrazıplama);
             skor += 20;

             if(rekor<skor)
             {

                     rekor = skor;
                     PlayerPrefs.SetInt("rekor", rekor);
             }
         }

         if (collision.relativeVelocity.y >= 0 && collision.gameObject.tag == "zemin" || collision.gameObject.tag == "zemin2" || collision.gameObject.tag == "zemin3" || collision.gameObject.tag == "zemin4")
         {
             rb.velocity = new Vector2(0, zıplamaHızı);
             skor += 5;


             if(rekor<skor)
             {
                 rekor = skor;
                 PlayerPrefs.SetInt("rekor", rekor);
             }

         }

         if(collision.gameObject.tag =="yenidenbaslatıcı")
         {
             SceneManager.LoadScene(0);
         }
     }

    private void Update()
    {
        hareket = Input.GetAxisRaw("Horizontal");
        //rb.velocity = new Vector2(harekethızı * hareket * Time.deltaTime, rb.velocity.y);

        rb.transform.Translate(hareket*harekethızı*Time.deltaTime, 0, 0);

        if(hareket<0)
        {
            sr.flipX = true;
        }
        else if(hareket>0)
        {
            sr.flipX = false;
        }
        skorYazısı.text = "skor: " + skor;
        rekorYazısı.text = "rekor: " + rekor;

        
        
    }
   /* private void FixedUpdate()
    {
        RaycastHit2D hit2D = Physics2D.Raycast(foot.position, Vector2.down, distance);
        //RaycastHit2D hit12D = Physics2D.Raycast(foots[1].position, Vector2.down, distance);
        // RaycastHit2D hit22D = Physics2D.Raycast(foots[2].position, Vector2.down, distance);


        Debug.DrawRay(foot.position, Vector2.down * distance, Color.green);
        if (hit2D.collider != null && rb.velocity.y <= 0)
        {
            rb.velocity = new Vector2(0, zıplamaHızı);
            skor += 5;


        }
        /* Debug.DrawRay(foots[1].position, Vector2.down * distance, Color.green);
         if (hit2D.collider != null && rb.velocity.y <= 0)
         {
             rb.velocity = new Vector2(0, zıplamaHızı);
             skor += 5;


         }
         Debug.DrawRay(foots[2].position, Vector2.down * distance, Color.green);
         if (hit2D.collider != null && rb.velocity.y <= 0)
         {
             rb.velocity = new Vector2(0, zıplamaHızı);
             skor += 5;

    a
         }*/


        /*hareket = Input.GetAxisRaw("Horizontal");
        //rb.velocity = new Vector2(harekethızı * hareket * Time.deltaTime, rb.velocity.y);

        rb.transform.Translate(hareket * harekethızı * Time.deltaTime, 0, 0);

        if (hareket < 0)
        {
            this.gameObject.transform.localScale = new Vector2(-1, 1);
            //sr.flipX = true;
        }
        else if (hareket > 0)
        {
            this.gameObject.transform.localScale = new Vector2(1, 1);

            //sr.flipX = false;
        }
        //if (hit2D.collider.gameObject.tag == "temizleyici")
        //{ SceneManager.LoadScene(0); }
    }*/


}
