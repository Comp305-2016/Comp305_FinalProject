using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameOverController : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Start_Click()
    {
        SceneManager.LoadScene("Game");
    }
}
