using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	//Private Variables 
	private int _livesValue; 
	private int _scoreValue;
    private int _keyValue;
    private float _timer;
    private int minutes;
    private int seconds;

    [Header("UI Objects")]
	public Text LivesLabel;
	public Text ScoreLabel;
    public Text KeyLabel;
	//public Text GameOverLabel; 
	//public Text FinalScoreLabel; 
    public Text TimerLabel;
    /*
    public Button RestartButton; 
	public GameObject Player; 
	public GameObject Enemy; 
*/
	public int LivesValue {
		get {
			return this._livesValue;
		}

		set {
			this._livesValue = value;
			if (this._livesValue <= 0) {
				this.EndMenu(); 
			} else {
				this.LivesLabel.text = "Lives: " + this._livesValue;
			}
		}
	}

	public int ScoreValue {
		get {
			return this._scoreValue;
		}

		set {
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}
    public int KeyValue
    {
        get
        {
            return this._keyValue;
        }

        set
        {
            this._keyValue = value;
            this.KeyLabel.text = "Key(s) Needed: " + this._keyValue;
        }
    }

    // Use this for initialization
    void Start () {
		this.LivesValue = 5; 
		this.ScoreValue = 0;
        this.KeyValue = 2;
        this._timer = 600.00f;
        this.TimerLabel.gameObject.SetActive(false);
        /*
		this.GameOverLabel.gameObject.SetActive (false);
		this.FinalScoreLabel.gameObject.SetActive (false);
		this.RestartButton.gameObject.SetActive (false);*/
	}

	// Update is called once per frame
	void Update () {
        if (this._timer > 1)
        {
            onTime();
        }
        else
        {
            this.EndMenu();
        }
    }

    //Method displays final score and restart button once game is over 
    /*private void _gameOver(){
		this.GameOverLabel.gameObject.SetActive (true); 
		this.FinalScoreLabel.text = "FINAL SCORE: " + this.ScoreValue; 
		this.FinalScoreLabel.gameObject.SetActive (true); 
		this.RestartButton.gameObject.SetActive (true); 


		//will not be displayed on screen 
		this.ScoreLabel.gameObject.SetActive (false); 
		this.LivesLabel.gameObject.SetActive (false);
        this.KeyLabel.gameObject.SetActive(false);
	}
    */

    public void onTime()
    {
        this.TimerLabel.gameObject.SetActive(true);
        _timer -= Time.deltaTime;
        minutes = Mathf.FloorToInt(_timer / 60F);
        seconds = Mathf.FloorToInt(_timer - minutes * 60);
        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        TimerLabel.text = "Remaining Time: " + niceTime;
    }
    //Method opens gameover scene when player dies
    public void EndMenu()
    {
        SceneManager.LoadScene("GameOverScene");
    }

}
