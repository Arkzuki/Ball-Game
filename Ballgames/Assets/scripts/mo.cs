using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class mo : MonoBehaviour
{
    private PhotonView PhotonView;


    public float speed;
    private Rigidbody2D rb;
    private Vector2 mv;
    public GameObject P;
    public ball ball;
    public Transform Pspawn;
    public GameObject Player;

    public float moveSpeed;
    
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + mv * Time.fixedDeltaTime);
        //move();
        Vector2 mi = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        mv = mi.normalized * speed;
    }

    void move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed * Time.fixedDeltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(moveSpeed * Time.fixedDeltaTime, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0, moveSpeed * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0, -moveSpeed * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {

        }
    }
    public void Respawn()
    {
        Player.transform.position = Pspawn.position;
    }
}
