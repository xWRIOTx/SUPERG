using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float Speed = 10.0f;
    
    void FixedUpdate()
    {
        rigidbody.velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.right * Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.left * Speed * Time.deltaTime;

    
        
        /*
                float translation = Input.GetAxis("Horizontal") * Speed;

                translation *= Time.deltaTime;

                //Rigidbody transform;
                transform.Translate(translation *-1,0,0);
              */
    }
}