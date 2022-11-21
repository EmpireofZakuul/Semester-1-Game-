using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    //public float followSpeed = 2f;
    //public float smoothSpeed = 10f;
    public float yOffset = 1f;
    

    /*[Header("Camera")]
    public Transform targetObject;
    public float smoothSpeed = 10f;
    public float yOffset = 1f;
    public Vector3 cameraOffset;
    */
    

    void Update()
    {
        transform.position = new Vector3(player.position.x, yOffset, transform.position.z);
      // Vector3 newPosition = new Vector3(player.position.x, player.position.y + yOffset, -10f );
      // transform.position = Vector3.Lerp(transform.position,newPosition,followSpeed * Time.deltaTime);
        // transform.postion means the position of the camera in world space
        // we are taking the cameras position and we are equaling it to the players position in world space on the x and y axis
    }
    

    void LateUpdate()
    {

        /*Vector3 desiredCameraPosition = targetObject.position + yOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredCameraPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;


        transform.LookAt(targetObject);
       */ 

      // Vector3 newPosition = new Vector3(player.position.x, player.position.y + yOffset, -20f );
       //transform.position = Vector3.Slerp(transform.position,newPosition,followSpeed * Time.deltaTime);
      

    }
    
}
