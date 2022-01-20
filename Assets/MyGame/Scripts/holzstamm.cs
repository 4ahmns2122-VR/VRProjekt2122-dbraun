using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holzstamm : MonoBehaviour

{
    public gamemanager Gamemanager;
    public int timeshit = 0;
    private AudioSource chop1;


    // Start is called before the first frame update
    void Start()
    {
        chop1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeshit == 1) 
        
        {
            chop1.enabled = true;
        }

        if (timeshit == 2)

        {
         
        }

        if (timeshit >= 3)
        {
            chop1.Play(0);
            Gamemanager.Holzpickedup = true;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "axt")
        {
            chop1.Play(0);
            Debug.Log("Holz geht");
            timeshit++;

        }
    }

}
