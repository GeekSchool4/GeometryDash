using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Camera : MonoBehaviour
{
    public Transform player;
    public Speeds CurrentSpeed;

    private float startFollowXPosition = 0;
    public Vector3 offset;

    float[] SpeedValues = { 8.6f, 10.4f, 12.96f, 15.6f, 19.27f };



    private bool _isFollowing = false;

    // Update is called once per frame
    void Update()
    {
        if(!_isFollowing && player != null) 
        {
            if(player.position.x >= startFollowXPosition) 
            {
                _isFollowing = true;
            }
        }

        if(_isFollowing && player != null) 
        {

            //transform.position += Vector3.right * SpeedValues[(int)CurrentSpeed] * Time.deltaTime;
            var desiredPosition = player.position + offset;
            var smoothedPosition = Vector3.Lerp(a: transform.position, desiredPosition, SpeedValues[(int)CurrentSpeed]);

            var freezeYPosition = new Vector3(smoothedPosition.x, transform.position.y, transform.position.z);

            transform.position = freezeYPosition;
        }

        
    }
}
