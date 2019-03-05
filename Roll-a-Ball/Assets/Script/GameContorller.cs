using System.Collections;
using UnityEngine;

public class GameContorller : MonoBehaviour 
{
    public UnityEngine.UI.Text scoreLabel;
	void Update () {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString();
	}
}
