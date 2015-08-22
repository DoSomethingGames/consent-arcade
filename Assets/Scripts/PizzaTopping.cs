using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PizzaTopping : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.SetActive(false);
	}

	public void SetImage(IngredientData.INGREDIENT_TYPE type) {
		Image choiceImage = this.GetComponent<Image>();
		choiceImage.sprite = IngredientData.GetOnPizzaAsset(type);
		this.gameObject.SetActive(true);
	}
}
