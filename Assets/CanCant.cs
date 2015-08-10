using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CanCant : MonoBehaviour {
	private Text result;

	// Use this for initialization
	void Start () {
		result = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {}

	public void setString(string str) {
		result.text = str;
	}
}
