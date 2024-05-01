using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public abstract class IInteractable: MonoBehaviour
{
    public abstract void Interact();

    public void HighlightOn()
    {
        gameObject.GetComponent<Outline>().enabled = true;
    }

    public void HighlightOff()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }
}
