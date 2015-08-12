using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GCScene2 : GameController {

	public Ingredient[] choices;

	void Awake() {
		nextSceneString = "Pizza-Scene3";
	}

	protected void Start() {
		base.Start ();

		this.populateChoices ();
	}

	// Update is called once per frame
	void Update () {
		
	}

	//returns true if something is in choices 
	private bool IsInChoices(Ingredient.INGREDIENT_TYPE other) {
		for (int i = 0; i < choices.Length; i++) {
			if (other == choices[i].GetType()) {
				return true;
			}
		}
		return false;
	}

	public void populateChoices() {
		for (int i = 0; i < choices.Length; i++) {
			Ingredient.INGREDIENT_TYPE randType = Ingredient.GetRandomType();

			//prevents duplicate ingredients of the same type THERE MAY BE A BETTER SOLUTION
			while (this.IsInChoices(randType)) {
				randType = Ingredient.GetRandomType();
			}

			choices[i].SetType(randType);

			Text choiceText = choices[i].text;
			choiceText.text = choices[i].GetText(randType);

			Texture2D choiceImage = choices[i].GetComponent<Texture2D>();
			choiceImage = choices[i].GetAsset(randType);
			Debug.Log(choiceImage);

			this.AddFriendChoice(choices[i]);
		}
	}
}
