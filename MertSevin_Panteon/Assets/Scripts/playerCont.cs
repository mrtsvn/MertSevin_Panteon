using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCont : MonoBehaviour
{
    public GameObject player;
    public float runSpeed = 0.1f;
    public float xMovementSpeed = 0.1f;
    public float border;

    private Rigidbody rb;

    public Animator animator;
    public bool pldead;

    GameManager gm;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        pldead = false;
        animator.SetBool("dead", pldead);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            pldead = true;
            gm.isDead = true;
            animator.SetBool("dead", pldead);
            
        }
    }
    void Update()
    {
        if (!pldead)
        {
            Movechar();
        }
    }
    void Movechar()
    {

            float zMovement = runSpeed * Time.deltaTime;
            transform.Translate(0, 0, zMovement);

            border = player.transform.position.z;
            if (border < 0.4f && border > -0.4f)
            {
                float xInput = Input.GetAxis("Horizontal");
                float xMovement = xInput * xMovementSpeed * Time.deltaTime;
                transform.Translate(xMovement, 0, 0);
            }
            else if (border >= 0.4f && Input.GetKeyDown(KeyCode.D))
            {
                float xMovementB1 = xMovementSpeed * Time.deltaTime;
                transform.Translate(xMovementB1, 0, 0);
            }
            else if (border <= -0.4f && Input.GetKeyDown(KeyCode.A))
            {
                float xMovementB2 = -xMovementSpeed * Time.deltaTime;
                transform.Translate(xMovementB2, 0, 0);
            }
        
        
    }

}

