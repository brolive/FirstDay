using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1.0f;
    public float jumpForce = 1.0f;

    private bool grounded = false;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TEST!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position,
                           Vector3.down,
                           2))
        {
            grounded = true;
		
        }
        else
        {
            grounded = false;
        }
        anim.SetBool("grounded", grounded);
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Debug.Log(horizontalInput);

        /*transform.position = new Vector3(transform.position.x + horizontalInput,
                                         transform.position.y,
                                           transform.position.z);*/

        Rigidbody rb = GetComponent<Rigidbody>();

        rb.velocity = new Vector3(horizontalInput * speed,
                                  rb.velocity.y,
                                  verticalInput * speed);

        if(Input.GetButtonDown("Jump"))
        {
            GameManager.instance.DoThing();

            rb.velocity = new Vector3(rb.velocity.x,
                                      jumpForce,
                                      rb.velocity.z);
	    //anim.SetTrigger("jump");
        }
    }
}
