using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.AddForce(x, 0, z);
    }
}
