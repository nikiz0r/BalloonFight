using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    private float speed = 7;
    private float jumpForce = 5;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Move();

        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
	}

    void Move()
    {
        var direction = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);

        if (transform.position.x < -7.8f)
            transform.position = new Vector2(7.8f, transform.position.y);
        else if (transform.position.x > 7.8f)
            transform.position = new Vector2(-7.8f, transform.position.y);
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}
