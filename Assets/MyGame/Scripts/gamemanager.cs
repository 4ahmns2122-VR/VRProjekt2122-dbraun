using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public bool Eisenpickedup = false;
    public bool Holzpickedup = false;
    public GameObject pickaxe;
    private bool noPickaxe = true;
    public GameObject character;
    private Transform spawnPos;

    void Start()
    {
        Debug.Log("Hello from the other side");
        spawnPos = character.transform;
    }

    void Update()
    {

        if (Eisenpickedup && Holzpickedup && noPickaxe)
        {
            Instantiate(pickaxe, spawnPos.position, Quaternion.identity);
            noPickaxe = false;
        }
    }


}
