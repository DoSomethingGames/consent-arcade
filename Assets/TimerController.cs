using UnityEngine;
using System.Collections;

public class TimerController : MonoBehaviour {

	private GameController gameController;
	private Transform timer;

	private bool countingDown = false;
	private float timeRemaining = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeRemaining > 0) {
			timeRemaining -= Time.deltaTime;
			float percent = transform.localScale.x-(1*timeRemaining/5);
			transform.localScale -= new Vector3(percent, 0, 0);
		} else if (countingDown) {
			//signal GameController
			countingDown = false;
			gameController.endScene();
		}
	}

	public void setGameController(GameController gc) {
		if (gc) {
			gameController = gc;
		}
	}

	public void startTimer() {
		countingDown = true;
	}
}
