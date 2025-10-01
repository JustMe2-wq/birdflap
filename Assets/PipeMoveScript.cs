using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 450;
    public float deadZone = -45;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
