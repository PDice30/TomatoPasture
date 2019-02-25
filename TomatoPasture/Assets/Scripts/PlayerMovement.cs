using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rigidBody.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.W)) {
            rigidBody.AddForce(new Vector3(0, 0, 10), ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A)) {
            rigidBody.AddForce(new Vector3(-10, 0, 0), ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S)) {
            rigidBody.AddForce(new Vector3(0, 0, -10), ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D)) {
            rigidBody.AddForce(new Vector3(10, 0, 0), ForceMode.Force);
        }
    }
}
