using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomPop : MonoBehaviour
{
    public bool toggled = false;
    [SerializeField]
    public GameObject[] toggles;
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.transform.parent.GetComponent<Animator>();
        if (toggled)
        {
            m_Animator.SetBool("sink", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "PlayerBod")
        {
            Interact();
            m_Animator.SetBool("sink", true);
        }
    }

    public void Interact()
    {
        foreach (GameObject i in toggles)
        {
            MushroomPop j = i.GetComponent<MushroomPop>();
            j.Toggle(); 
        }
    }

    public void Toggle()
    {
        m_Animator.SetBool("sink", false);
    }
}
