using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CanCant : MonoBehaviour {
	public Text result;

	// Use this for initialization
	void Start () {
		result = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {}

	public bool isSuccessfulPizza(bool b) {
		if (b) {
			result.text = "CAN";
		} else {
			result.text = "CAN'T";
		}

		return b;
	}
}
