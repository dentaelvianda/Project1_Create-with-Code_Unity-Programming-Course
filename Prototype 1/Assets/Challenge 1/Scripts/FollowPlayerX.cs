using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    
    //Set Offset for Position
    private Vector3 offset = new Vector3(40f, 0, 0);
    // Set Offset for Rotation
    private Vector3 rotationOffset = new Vector3(0,-90f,0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Set Position relative to Camera with Position Offset
        transform.position = plane.transform.position + offset;
        // Set Rotation of the Camera with Rotation Offset
        transform.rotation = Quaternion.Euler(rotationOffset);
        // You can Combine 2 Scripts above to the one below
        //transform.SetPositionAndRotation(plane.transform.position + offset,Quaternion.Euler(rotationOffset));
        
    }
}
