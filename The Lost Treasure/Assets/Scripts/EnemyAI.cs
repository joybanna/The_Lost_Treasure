using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

    
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float rangtarget = 3.0f;
    public AudioClip monsS;

    float xmove;
    float zmove;
    private AudioSource conM;
    private bool detectplayer = true;
    private int waypointIndex = 0;
    private int maxwayIndex = 0;    
    private Transform player;
    private NavMeshAgent nav;
    private Animator anim;


    // Use this for initialization
    void Start ()
    {
        maxwayIndex = waypoints.Length;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        conM = GetComponent<AudioSource>();
        anim.SetBool("isRun", false);
        anim.SetBool("isBite",false);

    }
	
	// Update is called once per frame
	void Update ()
    {        
            //Move();                                         
    }

    private void Move()
    {       
        if (waypointIndex <= waypoints.Length - 1)
        {
            nav.SetDestination(waypoints[waypointIndex].position);
            anim.SetBool("isRun", true);

            Vector3 Point = transform.position- waypoints[waypointIndex].position;
            
            Debug.Log(Point.x);
            Debug.Log( Point.z);
            if (Point.x>=-0.5f&& Point.x <= 0.5f)
            {
                 xmove = 0f;
            }
            if (Point.z >= -0.5f && Point.z <= 0.5f)
            {
                 zmove = 0f;
            }

            if (xmove==0f&&zmove==0f)
            {
                waypointIndex += 1;
                
            }
            if (maxwayIndex == waypointIndex)
            {
                waypointIndex = 0;
               
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            conM.PlayOneShot(monsS);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            transform.LookAt(player);
            nav.SetDestination(player.position);
            anim.SetBool("isRun", true);

            RaycastHit hit;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * rangtarget, Color.yellow);
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, rangtarget) && detectplayer == true)
            {
                anim.SetBool("isBite", true);
            }
            else
            {
                anim.SetBool("isBite", false);
            }
                                    
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("isBite", false);
            anim.SetBool("isRun", false);
        }

    }
}
