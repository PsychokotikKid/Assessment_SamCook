using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;
    public bool jumpPressed;
    private Rigidbody rigid;

    private bool wPressed;
    private bool aPressed;
    private bool sPressed;
    private bool dPressed;

	// Use this for initialization
	void Start () {

        moveSpeed = 0.5f;
        jumpForce = 350f;
        rigid = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

        jumpPressed = Input.GetKeyDown(KeyCode.Space);
        wPressed = Input.GetKey(KeyCode.W);
        aPressed = Input.GetKey(KeyCode.A);
        sPressed = Input.GetKey(KeyCode.S);
        dPressed = Input.GetKey(KeyCode.D);
    }
    public void FixedUpdate()
    {
        if (jumpPressed == true)
            rigid.AddForce(Vector3.up * jumpForce);
        if (wPressed == true)
            transform.Translate(Vector3.forward * moveSpeed);
        if (aPressed == true)
            transform.Translate(Vector3.left * moveSpeed);
        if (sPressed == true)
            transform.Translate(Vector3.back * moveSpeed);
        if (dPressed == true)
            transform.Translate(Vector3.right * moveSpeed);
    }
}
//Comment
// I would make it so I have a time limit on jumping in order to make the playerObject only jump from the ground, in opposition to the use of raycasting.