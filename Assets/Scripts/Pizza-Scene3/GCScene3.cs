using UnityEngine;
using System.Collections;

public class GCScene3 : GameController {

	void Awake () {
		nextSceneString = "Pizza-Scene4";
	}

	protected void Start () {
		base.Start ();

		answerChoices = new Ingredient[this.AmtInCommon ()];
	}

	// Update is called once per frame
	void Update () {
	
	}

	public int AmtInCommon() {
		int count = 0;
		for (int i = 0; i < playerChoices.Length; i++) {
			for (int j = 0; j < friendChoices.Length; j++) {
				if (playerChoices[i].GetType().Equals(friendChoices[j].GetType())) {
					count++;
				}
			}
		}
		return count;
	}
}