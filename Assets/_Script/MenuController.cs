using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Start_Click()
    {
        SceneManager.LoadScene("InstructionL1Scene");
    }
    public void Inst_Click()
    {
        SceneManager.LoadScene("InstructionScene");
    }
}
