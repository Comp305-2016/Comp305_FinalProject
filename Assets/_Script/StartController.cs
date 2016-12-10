using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour {
    private string _scene;
    // Use this for initialization
    void Start () {
        Scene _curScene = SceneManager.GetActiveScene();
        _scene = _curScene.name;
        Debug.Log(this._scene);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Start_Click()
    {
        if (this._scene == "InstructionL1Scene")
        {
            SceneManager.LoadScene("Game");
        } else if
            (this._scene =="InstructionL2Scene")
        {
            Debug.Log("Button pressed");
            SceneManager.LoadScene("Game2");
        }
    }
}
