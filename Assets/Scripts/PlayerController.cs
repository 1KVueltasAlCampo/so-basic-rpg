using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float mSpeed = moveSpeed;
        if(Input.GetButton("Cancel")){
            move(moveSpeed*2);
        }
        else{
            move(moveSpeed);
        }
        
    }

    void move(float n){
        if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f){
            transform.Translate(new Vector3( Input.GetAxisRaw("Horizontal")*n*Time.deltaTime,0f,0f));
        }
        if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f){
            transform.Translate(new Vector3( 0f,Input.GetAxisRaw("Vertical")*n*Time.deltaTime,0f));
        }
        anim.SetFloat("MoveX",Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY",Input.GetAxisRaw("Vertical"));
    }
}
