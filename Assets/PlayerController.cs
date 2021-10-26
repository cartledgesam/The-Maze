using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

     void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
     
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "bullet") // this string is your newly created tag
        {
            // TODO: anything you want
            // Even you can get Bullet object
            GameObject strikingBullet = collider.gameObject;
        }
    }
}
