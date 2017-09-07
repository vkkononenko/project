using UnityEngine;
using System.Collections;

public class Daytime : MonoBehaviour {
	
	// Use this for initialization
	public Light sun;
	public float time;
	bool day;
	void Start () {
		day = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (day) {
			sun.intensity -= Time.deltaTime / time;
			day = !(sun.intensity == 0);
		} else {
			sun.intensity += Time.deltaTime / time;
			day = (sun.intensity >= 1);
		}
		Debug.Log (day);
	}
}