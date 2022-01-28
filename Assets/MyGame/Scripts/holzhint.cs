using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holzhint : MonoBehaviour
{
    private AudioSource chopping;

    // Start is called before the first frame update
    void Start()
    {
        chopping = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("working");

        if (other.gameObject.tag == "MainCam")
        {
            chopping.Play(0);
            Debug.Log ("working");
            

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "MainCam")
        {
            chopping.Pause();


        }
    }


}



