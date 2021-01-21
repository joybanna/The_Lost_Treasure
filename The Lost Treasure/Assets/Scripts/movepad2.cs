using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepad2 : MonoBehaviour {
    
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private GameObject pad;
    
    
    [SerializeField] private float moveSpeed = 2f;
    private bool move = false;
    private int waypointIndex = 0;
    

    // Use this for initialization
    private void Start()
    {
      

    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }


    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1&&move==true)
        {
            
            pad.transform.position = Vector3.MoveTowards(pad.transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);

            if (pad.transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
                
            }           
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
           
            move = true;
        }
    }
}
