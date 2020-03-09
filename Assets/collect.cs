using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    public AudioSource collectSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collectSound.Play();
            
            //Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       // collectSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
