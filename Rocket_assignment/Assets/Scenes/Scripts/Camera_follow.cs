using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    public Transform target;
    private Vector3 upwards = new Vector3(0, 1, 0);
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
    }
}
