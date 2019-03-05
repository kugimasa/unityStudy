using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour {
    private void OnCollisionEnter(Collision hit)
    {
        if(hit.gameObject.CompareTag ("Player")){
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

}
