using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    // public Transform player;
    // public float yOffset = 1f;

    //public float followSpeed = 2f;
    //public float smoothSpeed = 10f;


    private Vector3 velocity = Vector3.zero;
    public Transform player;
    public float smoothTime = 0.3f;
    

 
    
    

    void Update()
    {
        // transform.position = new Vector3(player.position.x, yOffset, transform.position.z);



        // Vector3 newPosition = new Vector3(player.position.x, player.position.y + yOffset, -10f );
        // transform.position = Vector3.Lerp(transform.position,newPosition,followSpeed * Time.deltaTime);
        // transform.postion means the position of the camera in world space
        // we are taking the cameras position and we are equaling it to the players position in world space on the x and y axis
      
    }
 

    void LateUpdate()
    {
        
    }



     void FixedUpdate()
      {
        /* // calculate the target position
         Vector3 desiredPosition = target.position + offset;

         // limit the y position to between 0 and 2
         desiredPosition.y = Mathf.Clamp(desiredPosition.y, 0f, 2f);

         // smoothly move the camera to the desired position
         Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

         // update the camera's position
         transform.position = smoothedPosition;

       */

        Vector3 targetPosition = player.TransformPoint(new Vector3(1, 0, -10));
        targetPosition.y = Mathf.Clamp(targetPosition.y, 0, 2);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);


    }
  


}
