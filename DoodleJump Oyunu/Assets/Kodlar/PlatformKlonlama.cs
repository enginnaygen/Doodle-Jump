using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformKlonlama : MonoBehaviour
{
    [SerializeField] GameObject Platform,UltraPlatform;
    public int platformsay�s�,ultraplatformsay�s�;
    

    private void Start()
    {
        for(int i=0; i<ultraplatformsay�s�;i++)
        {
            Vector2 ultraz�plat�c�klon = new Vector2(Random.Range(-6, 7), Random.Range(0, 100));
            Instantiate(UltraPlatform, ultraz�plat�c�klon, transform.rotation);
        }
        

        for (int i = 0;i<platformsay�s�; i++)

        {
            Vector2 klonpozisyonu = new Vector2(Random.Range(-6, 7), Random.Range(0, 100));
            Instantiate(Platform, klonpozisyonu, transform.rotation);
        }


    }
}
        
     
    

  

