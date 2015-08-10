using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject timer;
	protected string nextSceneString;
	private TimerController timerController;

	// Use this for initialization
	void Start () {
		timerController = timer.GetComponent<TimerController> ();

		if (timer) {
			Debug.Log(this.ToString());
			timerController.SetGameController(this);
			timerController.startTimer();
		}
	}
	
	// Update is called once per frame
	void Update () {}

	public void EndScene () {
		Application.LoadLevel(nextSceneString);
	}
}
