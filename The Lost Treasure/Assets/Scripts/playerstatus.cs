using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerstatus : MonoBehaviour {

    
    public SimpleHealthBar healthBar;
   
    static public int currenthealt;
    private int maxhealt = 100;
    

    // Use this for initialization
    void Start () {
        
        currenthealt = 100;
	}
   
    // Update is called once per frame
    void Update () {
        healthBar.UpdateBar(currenthealt, maxhealt);
    }
    static public void takedamage(int damage)
    {
        
        currenthealt -= damage;
    }
    
  
}
