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
            m_Animator.SetBool("press", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && other.transform.position.y - gameObject.transform.position.y > 2f)
        {
            Interact();
            m_Animator.SetBool("press", true);
            Debug.Log("goo");
        }
    }

    /*
    void OnTriggerExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && collision.transform.position.y - gameObject.transform.position.y > 2f)
        {
            
            m_Animator.SetBool("press", false);
            Debug.Log("down");
        }
    }
    */

    public void Interact()
    {
        foreach (GameObject i in toggles)
        {
            MushroomRaise j = i.GetComponent<MushroomRaise>();
            j.Interact(); 
        }
    }
}
