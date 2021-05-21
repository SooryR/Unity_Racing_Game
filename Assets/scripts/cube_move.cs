using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_move : MonoBehaviour
{
    public float move_v;
    public float move_a;
    public float jump_v;
    public float jump_f;
    public float top_speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        move_v = 10;
        move_a = 0.05F;
        jump_v = 1;
        top_speed = 40;
    }

    bool IsGrounded() {
        return Physics.Raycast(transform.position, -Vector3.up, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (move_v < .05 && move_v > -.05)
        {
            move_v = 0;
        }

        if ((move_v < top_speed && move_v > -top_speed) && Input.GetAxis("Vertical") != 0)
        {
            if (Input.GetAxis("Vertical")>0)
            {
                move_v += move_a;
            }
            else if(Input.GetAxis("Vertical")<0)
            {
                move_v -= move_a;
            }
            
            if (move_v > top_speed)
            {
                move_v = top_speed;
            }
            else if (move_v < -top_speed)
            {
                move_v = -top_speed;
            }
        }
        else if(Input.GetAxis("Vertical") <= 0 && move_v > 0)
        {
            move_v -= (float).25 + Input.GetAxis("Vertical");
        }
        else if(Input.GetAxis("Vertical") >= 0 && move_v < 0)
        {
            move_v += (float).25 + Input.GetAxis("Vertical");
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jump_f, ForceMode.Impulse);
        }

        transform.Translate(0f, 0f, move_v*Time.deltaTime);
        transform.Rotate(0f, Input.GetAxis("Horizontal")*100*Time.deltaTime, Input.GetAxis("Rotate")*200*Time.deltaTime);
    }
}
