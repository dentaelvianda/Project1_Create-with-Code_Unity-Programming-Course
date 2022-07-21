using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5f, -7f);
    private Vector3 backCameraRotation = new Vector3(20.636f, 0.314f, 0.115f);
   
    public Camera firstPersonCam;
    public string switchCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* LateUpdate akan mengupdate method Camera Setelah method Update Player selesai.
    sehingga membuat pergerakan player menjadi lebih mulus. Kalau tidak di late update akan menyebabkan
    pergerakan player menjadi stutter karena overlap dengan update Camera*/
    void LateUpdate()
    {
        //If button pressed, Switch Camera
        if (Input.GetKey(switchCamera))
        {
            //Transform Camera Position to First Camera Position
            transform.position = firstPersonCam.transform.position + player.transform.position;
            //Follow Camera Rotation into Player Rotation
            transform.rotation = player.transform.rotation;
        }
        //If button released
        else
        {
            //Turn back camera position into Back Camera
            transform.position = offset + player.transform.position;
            //Turn back Camera rotation into Back camera rotation
            transform.rotation = Quaternion.Euler(backCameraRotation);
        }
        
    }
}
