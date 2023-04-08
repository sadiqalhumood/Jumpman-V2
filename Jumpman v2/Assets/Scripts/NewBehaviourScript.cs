using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public Rigidbody2D rb;
    public Transform GroundCheck;
    public float GroundCheckRadius;
    public LayerMask WhatIsGround;
    private bool onGround;

    public Transform GroundCheck2;
    public float GroundCheckRadius2;
    public LayerMask WhatIsGround2;
    private bool onGround2;

    public Transform GroundCheck3;
    public float GroundCheckRadius3;
    public LayerMask WhatIsGround3;
    private bool onGround3;

    public Transform GroundCheck4;
    public float GroundCheckRadius4;
    public LayerMask WhatIsGround4;
    private bool onGround4;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(7, rb.velocity.y);
        onGround = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
        onGround2 = Physics2D.OverlapCircle(GroundCheck2.position, GroundCheckRadius2, WhatIsGround2);
        onGround3 = Physics2D.OverlapCircle(GroundCheck3.position, GroundCheckRadius3, WhatIsGround3);
        onGround4 = Physics2D.OverlapCircle(GroundCheck4.position, GroundCheckRadius4, WhatIsGround4);

        if (Input.GetMouseButtonDown(0) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, 11);

        }
        if (Input.GetMouseButtonDown(0) && onGround2)
        {
            rb.velocity = new Vector2(rb.velocity.x, 11);

        }
        if (Input.GetMouseButtonDown(0) && onGround3)
        {
            rb.velocity = new Vector2(rb.velocity.x, 11);

        }
        if (Input.GetMouseButtonDown(0) && onGround4)
        {
            rb.velocity = new Vector2(rb.velocity.x, 11);

        }
    }
    public void Death()
    {
        rb.velocity = Vector3.zero;
        transform.position = new Vector2(-25, -5);

        }
}
