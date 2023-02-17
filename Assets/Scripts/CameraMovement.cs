using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y + 8, target.position.z - 8);
    }
}
