using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    private GameObject collectOff;
    public Collectables collect;
   // public AudioSource collectable;
   // public AudioClip collectSound;
    //public int add = 1;
    // Start is called before the first frame update
    void Start()
    {
        //collectable = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
   {
        
        //if(collision.gameObject.tag == "Collectables")
        if (collision.gameObject.tag == "PlayerCollider")
                
       {
            //collect.counter += add;
            //collectable.PlayOneShot(collectSound);
            collect.counter +=1;
            gameObject.SetActive(false);
            
            //Destroy(this.gameObject);
            //Debug.Log(collect);
       }

       /*if(collision.gameObject.tag == "CollectablesCandyCane")
       {
           //collect.counter += add;
            collect.counter ++;
            Destroy(collision.gameObject);
       }
       */
       
   }
}
