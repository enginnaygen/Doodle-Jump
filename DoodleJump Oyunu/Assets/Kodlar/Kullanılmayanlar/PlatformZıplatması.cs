using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformZıplatması : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    public float zıplamaHızı;
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="karakter")
        {
            rb.AddForce(new Vector2(0, zıplamaHızı));
         
        }
    }
}
