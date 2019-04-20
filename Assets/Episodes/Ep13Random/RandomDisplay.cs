using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDisplay : MonoBehaviour
{
    private string _outputString = "0";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUILayout.Label(_outputString);

    }
}
