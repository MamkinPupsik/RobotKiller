using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("явл€емс€ ли мы на земле?")]
    public bool Ground;

    private float _moveSpeed = 3f;
    private float _LRSpeed = 3f;

    private float vInput;
    private float hInput;
    private float xInput;

    public float jumpVelocity = 2f;

    private Rigidbody _rb;
   
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {   //Speed boost character 
        
        Move();
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (Ground == true)
            {
                _rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
            }

        }
    }
    
    void Move()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            vInput = Input.GetAxis("Vertical") * _moveSpeed + 2f;
            xInput = Input.GetAxis("Horizontal") * _LRSpeed;
            this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
            this.transform.Translate(Vector3.left * -xInput * Time.deltaTime);

        }
        else if (!Input.GetKey(KeyCode.LeftShift))
        {
            vInput = Input.GetAxis("Vertical") * _moveSpeed;
            xInput = Input.GetAxis("Horizontal") * _LRSpeed;
            this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
            this.transform.Translate(Vector3.left * -xInput * Time.deltaTime);
        }

       
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Ground = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Ground = false;
        }
    }
}
