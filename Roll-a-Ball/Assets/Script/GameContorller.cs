using System.Collections;
using UnityEngine;

public class GameContorller : MonoBehaviour 
{
    public UnityEngine.UI.Text scoreLabel;
    public GameObject winnerLabelObject;
    void Update () {
        int count = GameObject.FindGameObjectsWithTag ("Item").Length;
        scoreLabel.text = count.ToString ();
        if(count == 0){
            winnerLabelObject.SetActive (true);
            scoreLabel.text = null;
        }
	}
}
