using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public gamemanager Gamemanager;
    private AudioSource crush;
    public Renderer rend;
    Collider m_Collider;


    // Start is called before the first frame update
    void Start()
    {
        crush = GetComponent<AudioSource>();
        rend = GetComponent<Renderer>();
        m_Collider = GetComponent<Collider>();
        m_Collider.enabled = true;
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.Eisenpickedup && Gamemanager.Holzpickedup)
        {

        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pickaxe")
        {
            crush.Play(0);
            rend.enabled = false;
            m_Collider.enabled = false;

        }
    }




}
