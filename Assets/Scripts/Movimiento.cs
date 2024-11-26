using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed;
    public float horizontal;
    public float force;

    [SerializeField] Rigidbody2D rig;

    [SerializeField]Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
       
        if (horizontal > 0.99)
        {
            MovimientoBola();
            animator.SetBool("Right", true);

            animator.SetBool("Idle", false);

        }
        else if(horizontal < -0.99) {
            MovimientoBola();
            animator.SetBool("Left", true);

            animator.SetBool("Idle", false);

        }
        else {

            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
            animator.SetBool("Idle", true);
        }

        if (Input.GetKeyDown(KeyCode.W)) {
            Debug.Log("aaa");
            rig.AddForce(Vector2.up * force);
        }

    }

    public void MovimientoBola() {
        this.transform.Translate(Vector2.right * horizontal * speed * Time.deltaTime, Space.World);

    }
}
