using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YenidenBaslatıcı : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="karakter")
        {
            SceneManager.LoadScene(0);
        }

    }
}
