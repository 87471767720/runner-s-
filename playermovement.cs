using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {

    public float jumpForce = 5f;
    public float forwardForce = 0f;
    private Rigidbody2D myRB;
    private bool canJump;

	// Use this for initialization
	void Start () {
        myRB = GetComponent<Rigidbody2D> ();
       

	}

    // Update is called once per frame
    public void Jump()
    {
        if (canJump)

        {
            canJump = false;

            if(transform.position.x < 0)
            {
                forwardForce = 1f;
            }
            else
            {
                forwardForce = 0f;
            }
            myRB.velocity = new Vector2(forwardForce, jumpForce);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        canJump = true;
    }
}
