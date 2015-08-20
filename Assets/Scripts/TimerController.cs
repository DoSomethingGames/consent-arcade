using UnityEngine;
using System.Collections;

public class TimerController : MonoBehaviour {

	private GameController gameController;
	private Transform timer;

	private bool countingDown;
	public static int START_TIME = 5;
	private float timeRemaining = START_TIME;

	void Awake() {
		countingDown = false;
		timeRemaining = START_TIME;
	}

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		if (timeRemaining > 0 && countingDown) {
			timeRemaining -= Time.deltaTime;
			float percent = transform.localScale.x-(1*timeRemaining/START_TIME);
			transform.localScale -= new Vector3(percent, 0, 0);
		} else if (countingDown) {
			countingDown = false;
			if (gameController.toFail) {
				gameController.LoadFailScene();
			} else {
				gameController.LoadNextScene();
			}

		}
	}

	public void SetGameController(GameController gc) {
		gameController = gc;
	}

	public void startTimer() {
		countingDown = true;
	}
}
