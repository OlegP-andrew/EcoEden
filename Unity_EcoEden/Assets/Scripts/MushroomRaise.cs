using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomRaise : MonoBehaviour
{

    Animator m_Animator;
    public bool toggled = false;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        if (toggled)
        {
            m_Animator.SetBool("grow", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        toggled = !toggled;
        m_Animator.SetBool("grow", true);
        SoundManager.S.MushroomGrow(this.gameObject);
    }
}
