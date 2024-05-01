using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsCCMove03 : MonoBehaviour
{
    public float movSpeed = 5.0f;
    public float rotSpeed = 120.0f;

    CharacterController controller;
    Vector3 moveDirection;

    float jumpSpeed = 10.0f;
    float gravity = 20.0f;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            h = h * rotSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up * h);

            moveDirection = new Vector3(0, 0, v * movSpeed);
            moveDirection = transform.TransformDirection(moveDirection);

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }

        }
        //지면에 닿을 때까지 추락
        moveDirection.y -= gravity * Time.deltaTime;
        
        controller.Move(moveDirection * Time.deltaTime);

    }
}
