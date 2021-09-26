using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PathThroughObjects : MonoBehaviour
{
    public GameObject[] pathpoints;
    public float speed;
    private int _currentPathIndex;
    private Vector3 _movementDirection;
    
    
    
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position //where we are 
        //pathpoints[0].transform.position  //where we are going
        _movementDirection = (pathpoints[0].transform.position - transform.position).normalized;

        transform.position += _movementDirection * (speed * Time.deltaTime);

    }
}