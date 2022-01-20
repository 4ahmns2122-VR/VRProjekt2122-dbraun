using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public bool Eisenpickedup = false;
    public bool Holzpickedup = false;
    public GameObject pickaxe;
    private bool noPickaxe = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Eisenpickedup && Holzpickedup && noPickaxe)
        {
            Instantiate(pickaxe);
            noPickaxe = false;
        }
    }


}
