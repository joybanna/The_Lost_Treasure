using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCtalk : MonoBehaviour {
    public GameObject textBox;
    public AudioClip talksound;
    private AudioSource soundControll;
    public bool opener = false;
    private GameObject player;
    

	// Use this for initialization
	void Start () {
        PressE.show = false;
        textBox.SetActive(false);
        openGate.isGate = false;
        soundControll = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        print(PressE.show);
	}
    private void OnTriggerStay(Collider other)
    {
        PressE.show = true;
        if (Input.GetKeyUp(KeyCode.E))
        {
            soundControll.PlayOneShot(talksound);
            transform.LookAt(player.transform.position);
            textBox.SetActive(true);
            if (opener == true)
            {
                openGate.isGate = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PressE.show = false;
            textBox.SetActive(false);
        }
    }
}
