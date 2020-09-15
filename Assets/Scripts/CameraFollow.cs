using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothness = 0.3f;

    private Vector3 velocity = Vector3.zero;


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3();
        pos.x = player.position.x;
        pos.z = player.position.z;
        pos.y = player.position.y;
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, smoothness);
    }
}
