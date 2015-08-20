using UnityEngine;
using System.Collections;

public class GCScene1 : GameController {
	
	private int numSelected;
	public Transform[] choices;

	void Awake() {
		nextSceneString = "Pizza-Scene2";
		numSelected = 0;
		toFail = true;

		Data.Reset ();
	}

	// Update is called once per frame
	void Update () {}

	/**
	 * Function called when an ingredient is clicked.
	 * 
	 * @param Object ingredient
	 *   The Ingredient selected on click
	 */
	public void OnIngredientClick (GameObject ingredient) {
		
		Ingredient selected = ingredient.GetComponent<Ingredient>();
		selected.transform.position = choices[numSelected].transform.position;
		Data.AddPlayerChoice (selected);
		numSelected++;

		selected.Disable ();

		if (numSelected == 3) {
			this.LoadNextScene ();
		}
	}
}
