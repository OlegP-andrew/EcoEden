using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    ChordsBassdemoHelper chordsBassdemoHelper;
    ChordsBassdemoHandle mychordsBassdemoPlugin;

    const int instanceIndex = 1;
    
    readonly System.Int32 verbsizeParam = (int)ChordsBassdemoHandle.GetParamIndexById("verbsize");

    // This creates a field in Unity's inspector where we can set the value to pass to our metronomeParam
    [SerializeField] double verbsizeOn = 1;
    
    
    // Start is called before the first frame update
    void Start()
    {
        chordsBassdemoHelper = ChordsBassdemoHelper.FindById(instanceIndex);
        mychordsBassdemoPlugin = chordsBassdemoHelper.Plugin;

        mychordsBassdemoPlugin.SetParamValue(verbsizeParam, verbsizeOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
