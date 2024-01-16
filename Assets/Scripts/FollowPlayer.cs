using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 cameraOffset= new Vector3(0, 5, -9.5f);
    private float verticalInput;
    private float horizontalInput;

    void Update()
    {
        CameraOffset();    //Abstraction
    }

    private void CameraOffset()
    {
        verticalInput = Input.GetAxis("CameraVertical");
        horizontalInput = Input.GetAxis("CameraHorizontal");

        transform.position = player.transform.position + cameraOffset;
    }
}
