using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomWall : MonoBehaviour
{
    public bool toggled = false;
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void Toggle()
    {
        if (toggled){
            m_Animator.SetBool("open", false);
        }
        else {
            m_Animator.SetBool("open", true);
        }
        toggled = !toggled;
    }
}
