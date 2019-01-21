using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour {

    private Animator LightAnimator;
    private bool BulbOff = true; 

     
   




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
