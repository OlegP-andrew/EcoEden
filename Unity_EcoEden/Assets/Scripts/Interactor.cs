using System.Collections;
using System.Collections.Generic;
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
        }
        itr.action.Enable();
        itr.action.performed += Inter;
        Debug.Log(listing.Count);
    }

    // Update is called once per frame
    void Update()
    {
        Transform closest = null;
        float closestDistanceSqr = 20f;
        Vector3 currentPosition = transform.position;
        foreach(IInteractable i in listing)
        {
            Transform potentialTarget = i.GetComponentInParent<Transform>();
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            Debug.Log(dSqrToTarget);
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
        Debug.Log(current);

    }

    void Inter(InputAction.CallbackContext context)
    {
        if (current != null)
        {
            current.Interact();
        }
    }
}
