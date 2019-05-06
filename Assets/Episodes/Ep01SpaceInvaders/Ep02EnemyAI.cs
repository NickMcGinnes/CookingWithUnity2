using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ep02EnemyAI : MonoBehaviour
{
	public float Speed = 2f;

	private int direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 newPosition = transform.position;
		newPosition.x += Speed * Time.deltaTime;
		transform.position = newPosition;
    }
}
