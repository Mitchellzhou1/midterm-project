using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static Player instance;
    public float speed = 6;
    public float jumpForce = 300;

    public LayerMask ground;
    bool isGrounded = false;
    public Transform feet;

    private Rigidbody2D rb;

    private void Awake(){
        instance = this;
    }

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
    
        float xSpeed = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);
      

    }

    void Update(){
        if (Input.GetButtonDown("Jump")){
            print("trying to jump");
            print("ont the ground?" + isGrounded);
            if (isGrounded){
                rb.AddForce(new Vector2(0, jumpForce));
                isGrounded = false;
            }
        }
    }

    public void onFloor(){
        isGrounded = true;
        print(isGrounded);
    }
}
