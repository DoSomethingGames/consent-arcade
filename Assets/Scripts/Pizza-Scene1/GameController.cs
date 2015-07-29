using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private int numSelected = 0;

	public Transform[] choices;

	// Use this for initialization
	void Start () {
		Debug.Log ("GAME CONTROLLER STARTED");
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
		Debug.Log ("clicked");

		Ingredient selected = ingredient.GetComponent<Ingredient>();

		selected.transform.position = choices[numSelected].transform.position;

		Debug.Log("Ingredient clicked. type: " + selected.type + ", num selected: " + numSelected);
		numSelected++;
		//if(numSelected > 3) move to next scene;
	}
}
