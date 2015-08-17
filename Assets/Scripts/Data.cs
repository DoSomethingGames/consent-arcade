using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Data {

	public static Ingredient.INGREDIENT_TYPE[] playerChoices = new Ingredient.INGREDIENT_TYPE[3];
	public static int curPlayerNum = 0;
	
	public static Ingredient.INGREDIENT_TYPE[] friendChoices = new Ingredient.INGREDIENT_TYPE[3];
	public static int curFriendNum = 0;
	
	public static Ingredient.INGREDIENT_TYPE[] finalChoices = new Ingredient.INGREDIENT_TYPE[3];
	public static int curFinalNum = 0;
	
	public static Ingredient.INGREDIENT_TYPE[] answerChoices;
	public static int curAnswerNum = 0;

	public static void AddPlayerChoice(Ingredient ingredient) {
		if (curPlayerNum > playerChoices.Length) {
			Debug.Log("OUT OF ARRAY");
			return;
		}
		playerChoices [curPlayerNum] = ingredient.GetType();
		Debug.Log (">>>>>> " + playerChoices[curPlayerNum] + " to PlayerChoices");
		curPlayerNum++;
	}
	
	public static void AddFriendChoice(Ingredient ingredient) {
		if (curPlayerNum > playerChoices.Length) {
			Debug.Log("OUT OF ARRAY");
			return;
		}
		friendChoices [curFriendNum] = ingredient.GetType();
		Debug.Log (">>>>>> " + friendChoices[curFriendNum] + " to FriendChoices");
		curFriendNum++;
	}
	
	public static void AddFinalChoice(Ingredient ingredient) {
		if (curFinalNum > finalChoices.Length) {
			Debug.Log("OUT OF ARRAY, LENGTH " + finalChoices.Length);
			return;
		}
		finalChoices [curFinalNum] = ingredient.GetType();
		Debug.Log (">>>>>>" + finalChoices[curFinalNum]);
		curFinalNum++;
	}
	
	public static void AddAnswerChoice(Ingredient ingredient) {
		if (curPlayerNum > playerChoices.Length) {
			Debug.Log("OUT OF ARRAY");
			return;
		}
		answerChoices [curAnswerNum] = ingredient.GetType();
		curAnswerNum++;
	}

	public static void SetAnswerChoices() {
		if (Data.playerChoices.Length != Data.friendChoices.Length) {
			Debug.Log("Arrays are not the same length");
			return;
		}

		List<Ingredient.INGREDIENT_TYPE> list = new List<Ingredient.INGREDIENT_TYPE>();

		for (int i = 0; i < Data.playerChoices.Length; i++) {
			for (int j = 0; j < Data.friendChoices.Length; j++) {
				if (Data.playerChoices[i] == Data.friendChoices[j]) {
					Debug.Log("FOUND MATCH: " + playerChoices[i]);
					list.Add(playerChoices[i]);
				}
			}
		}
		answerChoices = list.ToArray ();
		Debug.Log ("LENGTH: " + answerChoices.Length);
	}

	public static bool IsInChoices(Ingredient.INGREDIENT_TYPE other) {
		for (int i = 0; i < answerChoices.Length; i++) {
			if (other == answerChoices[i]) {
				return true;
			}
		}
		return false;
	}

	public static bool CompareChoices() {

//		if (finalChoices.Length != answerChoices.Length)
//			return false;

		Array.Sort (finalChoices);
		Array.Sort (answerChoices);

		for (int i = 0; i < answerChoices.Length; i++) {
			if (finalChoices[i] != answerChoices[i]) return false;
			else Debug.Log(finalChoices[i]);
		}

		return true;
	}
}
