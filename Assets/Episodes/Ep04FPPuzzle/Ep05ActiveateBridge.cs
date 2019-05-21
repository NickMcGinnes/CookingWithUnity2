using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ep05ActiveateBridge : MonoBehaviour
{
	public GameObject Bridge;
	public GameObject Key;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == Key)
		{
			Bridge.SendMessage("ObjectActivate");
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject == Key)
		{
			Bridge.SendMessage("ObjectDeactivate");
		}
	}
}
