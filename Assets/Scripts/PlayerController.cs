using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    private Animator anim;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        bool doubleSpeed = Input.GetButton("Cancel");

        if(horizontal != 0 || vertical != 0){
            if(doubleSpeed){
                moveSpeed *= 2;
            }
            Vector2 velocity = new Vector2(horizontal,vertical).normalized * moveSpeed;
            rb.velocity = velocity;
            anim.SetFloat("MoveX",horizontal);
            anim.SetFloat("MoveY",vertical);
            anim.SetBool("Moving",true);
        }

        else{
            anim.SetBool("Moving",false);
            rb.velocity = Vector2.zero;
        }
        
    }

}