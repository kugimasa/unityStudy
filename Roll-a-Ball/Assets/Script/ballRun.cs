using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballRun : MonoBehaviour
{
    private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var dir = Vector3.zero;

        dir.x = Input.acceleration.x;
        dir.z = Input.acceleration.y;

        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;

        transform.Translate(dir * speed);
    }
}
