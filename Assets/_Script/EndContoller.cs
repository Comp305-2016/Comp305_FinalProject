using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndContoller : MonoBehaviour {
    public GameController gamecontroller;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void CheckEnd()
    {
        if (gamecontroller.KeyValue <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            CheckEnd();
            Debug.Log("end game");
            

        }
    }
}
