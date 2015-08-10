using UnityEngine;
using System.Collections;

public class PizzaPrefs : MonoBehaviour {

	public Ingredient[] playerIngredients;
	private int curPlayerIngredient = 0;

	public Ingredient[] friendIngredients;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SetPlayerIngredient(Ingredient ingredient) {
		if (curPlayerIngredient < 3)
			playerIngredients [curPlayerIngredient] = ingredient;
	}

	void SetFriendIngredient(Ingredient ingredient) {
		for (int i = 0; i < 3; i++) {
			if (i == 0) {
				//selects ingredient from pizza person prefs
			} else {
				//selects ingredient from enumeration of ingredients
			}
		}
	}
}
