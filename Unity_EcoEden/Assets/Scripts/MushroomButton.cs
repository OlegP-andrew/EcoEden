using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomButton : IInteractable
{

    [SerializeField]
    public GameObject[] toggles;
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        foreach (GameObject i in toggles)
        {
            MushroomWall j = i.GetComponent<MushroomWall>();
            j.Toggle(); 
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            Interact();
            m_Animator.SetBool("press", true);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            m_Animator.SetBool("press", false);
        }
    }
}
