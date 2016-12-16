using UnityEngine;
using System.Collections;

public class GunTriggerController : MonoBehaviour {
    public GameController _gameController;
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
            Debug.Log("gun hit");
           
            this.gameObject.SetActive(false);
            this._gameController.WeaponValue -= 1;

            this.pickup.Play();




        }
    }
}
