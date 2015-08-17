using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GCScene2 : GameController {

	public Ingredient[] choices;

	void Awake() {
		nextSceneString = "Pizza-Scene3";

		this.populateChoices ();
	}

	protected void Start() {
		base.Start ();

		Data.SetAnswerChoices ();
	}

	// Update is called once per frame
	void Update () {}

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

		// place at least one ingredient from playerChoices into friendChoices
		Ingredient.INGREDIENT_TYPE fromPlayer = Data.playerChoices [Random.Range (0, Data.playerChoices.Length)];
		int rand = Random.Range (0, Data.playerChoices.Length);

		for (int i = 0; i < choices.Length; i++) {
			if (i == rand && !this.IsInChoices(fromPlayer)) {
				choices[i].SetType(fromPlayer);
			} else {
				Ingredient.INGREDIENT_TYPE randType = Ingredient.GetRandomType();
				while (this.IsInChoices(randType)) {
					randType = Ingredient.GetRandomType();
				}

				choices[i].SetType(randType);
			}
			
			Text choiceText = choices[i].text;
			choiceText.text = choices[i].GetText(choices[i].GetType());
			
			Image choiceImage = choices[i].GetComponent<Image>();
			choiceImage.sprite = choices[i].GetAsset(choices[i].GetType());

			Data.AddFriendChoice(choices[i]);
			choices[i].Disable();
		}
	}
}
