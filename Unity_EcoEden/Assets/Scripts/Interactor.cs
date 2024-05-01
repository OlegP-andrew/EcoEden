using System.Collections;
using System.Collections.Generic;
using cakeslice;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
    [SerializeField]
    public GameObject[] ints;
    public List<IInteractable> listing;
    IInteractable current;
    public InputActionReference itr;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject i in ints)
        {
            listing.Add(i.GetComponent<IInteractable>());
            i.GetComponent<Outline>().enabled = false;
        }
        itr.action.Enable();
        itr.action.performed += Inter;
    }

    // Update is called once per frame
    void Update()
    {
        IInteractable old = current;
        Transform closest = null;
        float closestDistanceSqr = 20f;
        Vector3 currentPosition = gameObject.transform.position;
        foreach(IInteractable i in listing)
        {
            Transform potentialTarget = i.GetComponentInParent<Transform>();
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if(dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                closest = potentialTarget;
    	        current = i;
            }
        }
        if (closest == null)
        {
            current = null;
        }
        if (current != old && old != null)
        {
            old.HighlightOff();
        }
        if (current != null) current.HighlightOn();
    }

    void Inter(InputAction.CallbackContext context)
    {
        if (current != null)
        {
            current.Interact();
        }
    }
}
