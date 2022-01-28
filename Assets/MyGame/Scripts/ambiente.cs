using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambiente : MonoBehaviour
{

    private AudioSource background;

    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<AudioSource>();
        background.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
