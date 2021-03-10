using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSped;

    private void LateUpdate()
    {
        if (player.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
