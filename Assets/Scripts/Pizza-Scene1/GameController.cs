using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private int numSelected = 0;

	public GameObject timer;
	private TimerController timerController;

	public Transform[] choices;

	// Use this for initialization
	void Start () {
		timerController = timer.GetComponent<TimerController> ();

		if (timer) {
			timerController.setGameController(this);
			timerController.startTimer();
			Debug.Log ("timer called");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/**
	 * Function called when an ingredient is clicked.
	 * 
	 * @param Object ingredient
	 *   The Ingredient selected on click
	 */
	public void OnIngredientClick (GameObject ingredient) {

		Ingredient selected = ingredient.GetComponent<Ingredient>();

		selected.transform.position = choices[numSelected].transform.position;

		numSelected++;
		//if(numSelected > 3) move to next scene;
	}

	public void endScene () {
		Debug.Log ("end scene");
		Application.LoadLevel("Pizza-Scene3");
		// go to next scene
	}
}
