using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holzhint : MonoBehaviour
{
    public gamemanager Gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.Holzpickedup == true)
        {
            Destroy(gameObject);
        }
    }




}



