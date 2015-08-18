using UnityEngine;
using System.Collections;

public class SatisfactionController : MonoBehaviour {
	
	public int growScale;
	public Vector3 growthRate;
	
	void Awake() {
		growScale = Random.Range (3, 5);
		growthRate = new Vector3 (0,growScale,0);
	}

	void Update() {

	}
}
