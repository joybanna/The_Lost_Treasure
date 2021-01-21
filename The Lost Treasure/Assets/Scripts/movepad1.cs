using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepad1 : MonoBehaviour {

    
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private bool infiniemove;
    [SerializeField] private float moveSpeed = 2f;
    
    private int waypointIndex = 0;
    private int maxwayIndex = 0;

    // Use this for initialization
    private void Start()
    {
        maxwayIndex = waypoints.Length;

    }

    // Update is called once per frame
    private void Update()
    {       
        Move();
    }

   
    private void Move()
    {      
        if (waypointIndex <= waypoints.Length - 1)
        {          
            transform.position = Vector3.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);   
            
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
            if (maxwayIndex == waypointIndex&&infiniemove==true)
            {
                waypointIndex = 0;
            }
        }
    }
}
