using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideWall : MonoBehaviour
{
    public bool toggled = false;
    Vector3 tpos;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        tpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, tpos, step);
    }

    public void Toggle()
    {
        if (toggled){
            tpos.y -= 4.2f;
        }
        else {
            tpos.y += 4.2f;
        }
        toggled = !toggled;
    }
}
