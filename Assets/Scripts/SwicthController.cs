using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool switchOn;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switchOn = true;
            Debug.Log("Automatic Switch On hun xx");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && switchOn == true)
        {
            switchOn = false;

            Debug.Log("Wake up hun, automatic switch is off!");
        }
    }
}
