using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float moveSpeed = 2f;

    private Vector3 nextPosition;

    void Start()
    {
        nextPosition = pointB.position;
    }

    void Update()
    {
        // Move platform
        transform.position = Vector3.MoveTowards(transform.position, nextPosition, moveSpeed * Time.deltaTime);

        // If reached the target point, switch to the other
        if (Vector3.Distance(transform.position, nextPosition) < 0.01f)
        {
            nextPosition = (nextPosition == pointA.position) ? pointB.position : pointA.position;
        }
    }
}
