using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        transform.LookAt(player.transform);
        transform.position = new Vector3(player.transform.position.x, mainCamera.transform.position.y, player.transform.position.z - 3);
    }
}
