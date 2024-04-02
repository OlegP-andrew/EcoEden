using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : IInteractable
{

    [SerializeField]
    public GameObject[] toggles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        foreach (GameObject i in toggles)
        {
            SlideWall j = i.GetComponent<SlideWall>();
            j.Toggle();
        }
    }
}
