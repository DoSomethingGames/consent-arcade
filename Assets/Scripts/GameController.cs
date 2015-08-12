using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject timer;
	protected TimerController timerController;
	protected bool toFail;

	protected string nextSceneString;
	public static Ingredient[] playerChoices;
	private int curPlayerNum;

	public static Ingredient[] friendChoices;
	private int curFriendNum;

	public static Ingredient[] answerChoices;

	void Awake() {
		curPlayerNum = 0;
		curFriendNum = 0;
		toFail = false;
	}

	// Use this for initialization
	protected void Start () {
		if (playerChoices == null) {
			playerChoices = new Ingredient[3];
		}

		if (friendChoices == null) {
			friendChoices = new Ingredient[3];
		}

		timerController = timer.GetComponent<TimerController> ();

		if (timer) {
			Debug.Log(this.ToString());
			timerController.SetGameController(this);
			timerController.startTimer();
		}
	}
	
	// Update is called once per frame
	void Update () {}

	public void AddPlayerChoice(Ingredient ingredient) {
		playerChoices [curPlayerNum] = ingredient;
		curPlayerNum++;
	}

	public void AddFriendChoice(Ingredient ingredient) {
		friendChoices [curFriendNum] = ingredient;
		curFriendNum++;
	}

	public void NextScene () {
		Application.LoadLevel(nextSceneString);
	}

	public void FailScene() {
		Application.LoadLevel ("Fail-Scene");
	}
}
