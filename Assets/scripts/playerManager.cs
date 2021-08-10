using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    public GameObject playerCharacter;

    public Transform playerPos;

    public float hInput = 0.0f;
    public float jumpHeight = 0.0f;

    public bool isGrounded;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        playerCharacter = this.gameObject;
        rb = playerCharacter.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.W) && (isGrounded))
        {
            jump();
        }
        turn();
        if (rb.velocity.y == 0)
            isGrounded = true;
        transform.position += new Vector3(hInput * statManager.speed * Time.deltaTime, 0, 0);
    }

    void turn()
    {
        if(hInput > 0)
        {
            transform.rotation = new Quaternion(0,0,0,0);
        }
        if(hInput < 0)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }
    }

    void jump()
    {
        rb.velocity += new Vector3(0, jumpHeight, 0);
        isGrounded = false;
    }
}
