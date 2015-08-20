using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Data {

	public static Ingredient.INGREDIENT_TYPE[] playerChoices;
	public static int curPlayerNum = 0;
	
	public static Ingredient.INGREDIENT_TYPE[] friendChoices;
	public static int curFriendNum = 0;
	
	public static Ingredient.INGREDIENT_TYPE[] finalChoices;
	public static int curFinalNum = 0;
	
	public static Ingredient.INGREDIENT_TYPE[] answerChoices;
	public static int curAnswerNum = 0;

	public static void Reset() {
		playerChoices = new Ingredient.INGREDIENT_TYPE[3];
		curPlayerNum = 0;

		friendChoices = new Ingredient.INGREDIENT_TYPE[3];
		curFriendNum = 0;

		finalChoices = new Ingredient.INGREDIENT_TYPE[3];
		curFinalNum = 0;

		answerChoices = new Ingredient.INGREDIENT_TYPE[3];
		curAnswerNum = 0;
	}

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
		Debug.Log (">>>>>>" + finalChoices[curFinalNum] + "to FinalChoices");
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

		for (int i = 0; i < Data.playerChoices.Length; i++) {
			for (int j = 0; j < Data.friendChoices.Length; j++) {
				if (Data.playerChoices[i] == Data.friendChoices[j]) {
					Debug.Log("FOUND MATCH: " + playerChoices[i]);
					answerChoices[i] = playerChoices[i];
				}
			}
		}
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

		Debug.Log ("BEFORE");
		PrintArray (finalChoices);
		PrintArray (answerChoices);
		Array.Sort (finalChoices);
		Array.Sort (answerChoices);
		Debug.Log ("AFTER");
		PrintArray (finalChoices);
		PrintArray (answerChoices);
		
		for (int i = 0; i < answerChoices.Length; i++) {
			Debug.Log("COMPARING " + finalChoices[i] + " TO " + answerChoices[i]);
			if (finalChoices[i] != answerChoices[i]) return false;
		}

		return true;
	}

	private static void PrintArray(Ingredient.INGREDIENT_TYPE[] array) {
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array[i]);
		}
	}
}
