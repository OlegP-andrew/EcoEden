using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafBoat : MonoBehaviour
{
    private Animator anim;
    
    public GameObject player;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void StartOff()
    {
        anim.SetTrigger("boat");

    }
}
