using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnInvisible : MonoBehaviour
{
	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
