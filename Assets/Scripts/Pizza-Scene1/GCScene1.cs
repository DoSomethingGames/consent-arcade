using UnityEngine;
using System.Collections;

public class GCScene1 : GameController {
	
	private int numSelected = 0;

	public Transform[] choices;
	public GameObject pizzaPrefs;

	void Awake() {
		if (!pizzaPrefs) {
			DontDestroyOnLoad (pizzaPrefs.transform);
		} else {
			Destroy(pizzaPrefs);
		}

		nextSceneString = "Pizza-Scene2";
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
		//pizzaPrefs.SetPlayerIngredient ();
		numSelected++;
		if(numSelected == 3) this.EndScene();
	}

}
