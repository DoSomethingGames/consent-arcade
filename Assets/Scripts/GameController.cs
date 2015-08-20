using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject timer;
	protected TimerController timerController;
	public bool toFail;

	protected string nextSceneString;

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

	public void LoadNextScene () {
		Application.LoadLevel(nextSceneString);
	}

	public void LoadFailScene() {
		Application.LoadLevel ("Fail-Scene");
	}
}
