using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public Joystick joy;
    public Rigidbody2D rb;

    Vector2 mov;

    public float velPlayer;
    public float movement;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        velPlayer = 2f;
    }
    private void Update()
    {
        //  movement = joy.Horizontal * velPlayer;
        mov.x = joy.Horizontal;
        mov.y = joy.Vertical;

        // print(joy.Horizontal);
        // print(mov.x);
        anim.SetFloat("Horizontal", mov.x);
        anim.SetFloat("Vertical", mov.y);
        anim.SetFloat("Vel", mov.sqrMagnitude);

        // anim.SetFloat("Pos Y", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.y));
        // rb.MovePosition(rb.position + mov *velPlayer  * Time.deltaTime);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //WALK
        rb.velocity = mov * velPlayer ;
       // rb.MovePosition(rb.position + mov * velPlayer * Time.fixedDeltaTime);
     }
}
