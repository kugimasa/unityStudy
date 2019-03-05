using System.Collections;
using UnityEngine;

public class Item : MonoBehaviour {
    private void OnTriggerEnter (Collider hit)
    {
        if (hit.CompareTag ("Player")){

            Destroy(gameObject);
        }
    }
}
