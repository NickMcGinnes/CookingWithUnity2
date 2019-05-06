using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollide : MonoBehaviour
{

	public bool Gib = false;
	public GameObject[] Gibs;

	public float ExplosionForce = 100f;
	public float SpawnRadius = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnCollisionEnter(Collision collision)
	{
		if (Gib)
		{
			foreach (GameObject gib in Gibs)
			{
				GameObject instance = Instantiate(gib, transform.position + Random.insideUnitSphere * SpawnRadius, transform.rotation);
				instance.GetComponent<Rigidbody>().AddExplosionForce(ExplosionForce, transform.position, SpawnRadius);
			}
		}
	
		Destroy(gameObject);
	}
}
