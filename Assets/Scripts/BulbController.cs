using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour {

    private Animator LightAnimator;
    public bool BulbOn;


     
   


    public void turnOn()
    {
        LightAnimator.SetBool("On", true);
        BulbOn = true;
    }

    public void turnOff()
    {
        LightAnimator.SetBool("On", false);
        BulbOn = false;
    }
    private void Awake()
    {
        LightAnimator = gameObject.GetComponent<Animator>();
        turnOff();
        

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
