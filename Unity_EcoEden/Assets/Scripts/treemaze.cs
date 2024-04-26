using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treemaze : MonoBehaviour
{
    public int interval;
    public int min;
    public int max;
    // Start is called before the first frame update
    void Start()
    {
        interval = Random.Range(min, max);
    }

    // Update is called once per frame
    void Update()
    {
        interval -= 1;
        if (interval == 0)
        {
            GetComponent<Animator>().SetTrigger("switch");
            interval = Random.Range(min, max);
        }
    }
}
