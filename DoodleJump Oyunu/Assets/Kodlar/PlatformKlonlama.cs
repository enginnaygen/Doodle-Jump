using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformKlonlama : MonoBehaviour
{
    [SerializeField] GameObject Platform,UltraPlatform;
    public int platformsayýsý,ultraplatformsayýsý;
    

    private void Start()
    {
        for(int i=0; i<ultraplatformsayýsý;i++)
        {
            Vector2 ultrazýplatýcýklon = new Vector2(Random.Range(-6, 7), Random.Range(0, 100));
            Instantiate(UltraPlatform, ultrazýplatýcýklon, transform.rotation);
        }
        

        for (int i = 0;i<platformsayýsý; i++)

        {
            Vector2 klonpozisyonu = new Vector2(Random.Range(-6, 7), Random.Range(0, 100));
            Instantiate(Platform, klonpozisyonu, transform.rotation);
        }


    }
}
        
     
    

  

