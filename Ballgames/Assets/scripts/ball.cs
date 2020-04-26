using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class ball : MonoBehaviourPun
{
    private PhotonView PhotonView;

    private Rigidbody2D Rigid;
    public float speed;
    public GameObject fotball;
    public bool point;
    public Transform spawn;
    public float T;





    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("point"))
        {
            Respawn();
            point = true;
        }
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider == true)
        {
            base.photonView.RequestOwnership();
        }
    }

    public void Start()
    {
        Rigid = GetComponent<Rigidbody2D>();

        point = false;

    }
    public void FixedUpdate()
    {
        if(speed > 0f)
        {
            speed /= -2;
        }
    }
    public void Update()
    {
        point = false;

	}

	public void Respawn()
    {
        fotball.transform.position = new Vector2(Random.Range(31.78323f, 31.78324f), transform.position.y);
        StartCoroutine(PauseMovement());

        Rigid.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        //if (M == true)
        //{

        //}


    }

    IEnumerator PauseMovement()
    {
        yield return new WaitForSeconds(T);
        //M = false;
        Rigid.constraints = RigidbodyConstraints2D.None; 
        Rigid.constraints = RigidbodyConstraints2D.FreezeRotation;
    }


}
