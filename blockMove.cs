using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMove : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;


    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 8f;
        turnSpeed = 0.8f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * turnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.Translate(-moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
    }
}
