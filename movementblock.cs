using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementblock : MonoBehaviour {

    public float speed = .5f;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        float horizinput = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(horizinput * speed *Time.deltaTime,0,0);
	}
}
