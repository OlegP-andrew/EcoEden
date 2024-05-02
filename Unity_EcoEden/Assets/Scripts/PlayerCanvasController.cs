using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class PlayerCanvasController : MonoBehaviour
{
    [SerializeField] Canvas playerCanvas;
    [SerializeField] bool canvasOn;
    private ThirdPersonController script;

    // Start is called before the first frame update
    void Start()
    {
        playerCanvas.GetComponent<Canvas>().enabled = false;
        script = GetComponent<ThirdPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        ShowCanvas();
    }

    private void ShowCanvas()
    {
        if (Input.GetKeyDown("tab"))
        {
            if (script != null) script.enabled = canvasOn;
            canvasOn = !canvasOn;
            playerCanvas.GetComponent<Canvas>().enabled = canvasOn;
            SoundManager.S.UI1();
        }
    }
}
