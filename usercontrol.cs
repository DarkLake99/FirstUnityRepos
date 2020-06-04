using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usercontrol : MonoBehaviour {

    public float jump = 8f;
    float horiMove = .9f;
    public Rigidbody2D myRigidBody;
    public bool onGround = true;
    public float speed = .5f;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.position = transform.position +
            new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        if (Input.GetButtonDown("Jump")&&onGround==true)
        {
            myRigidBody.AddForce(new Vector2(0,jump), ForceMode2D.Impulse);
            onGround = false;
            Debug.Log("onGround to false");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("it enters the OnCollisionEnter method");
        if (collision.gameObject.tag == "ground" && onGround==false)
        {
            onGround = true;
            Debug.Log("onGround to true");
        }
       
    }
}
