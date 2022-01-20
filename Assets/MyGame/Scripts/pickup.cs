using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour

{
    public gamemanager Gamemanager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Gamemanager.Eisenpickedup = true;
            Debug.Log("Es geht");
            Destroy(gameObject);

        }
    }

}
