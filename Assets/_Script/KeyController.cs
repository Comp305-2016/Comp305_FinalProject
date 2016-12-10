using UnityEngine;
using System.Collections;

public class KeyController : MonoBehaviour {
    public GameController gamecontroller;

    public AudioSource pickup;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            this.gamecontroller.KeyValue -= 1;
            Destroy(this.gameObject);
            this.pickup.Play();
        }
    }
}
