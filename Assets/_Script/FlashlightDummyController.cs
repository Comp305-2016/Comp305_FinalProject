using UnityEngine;
using System.Collections;

public class FlashlightDummyController : MonoBehaviour {
    public AudioSource pickup;
    public GameObject flashlight;
    public GameController gamecontroller;
    
    // Use this for initialization
    void Start () {
        this._check = false;
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("flashlight hit");
            flashlight.SetActive(true);
            this.gameObject.SetActive(false);
            this.gamecontroller.onTime();

            this.pickup.Play();
            
            


        }
    }
}
