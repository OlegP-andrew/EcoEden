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
        m_Animator.SetBool("open", toggled);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void Toggle()
    {
        toggled = !toggled;
        m_Animator.SetBool("open", toggled);
    }
}
