using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public static float healthAmmount;

    private void Start()
    {
        healthAmmount = 1.904f;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        ProcessInputs();

        if (healthAmmount <= 0)
            Destroy(gameObject);
    }
    void FixedUpdate()
    {
        Move();
    }
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY);
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Chicken"))
            healthAmmount -= 0.3f;
    }

}
