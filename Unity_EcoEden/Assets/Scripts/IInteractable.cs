using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public abstract class IInteractable: MonoBehaviour
{

    public GameObject hint;
    public abstract void Interact();

    public void HighlightOn()
    {
        if (hint != null) hint.SetActive(true);
        gameObject.GetComponent<Outline>().enabled = true;
    }

    public void HighlightOff()
    {
        if (hint != null) hint.SetActive(false);
        gameObject.GetComponent<Outline>().enabled = false;
    }
}
