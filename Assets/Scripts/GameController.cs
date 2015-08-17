using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject timer;
	protected TimerController timerController;
	protected bool toFail;

	protected string nextSceneString;

	void Awake() {

		toFail = false;
	}

	// Use this for initialization
	protected void Start () {

		timerController = timer.GetComponent<TimerController> ();

		if (timer) {
			Debug.Log("STARTING TIMER @ " + this.ToString());
			timerController.SetGameController(this);
			timerController.startTimer();
		}
	}
	
	// Update is called once per frame
	void Update () {}

	public void NextScene () {
		Application.LoadLevel(nextSceneString);
	}
}
