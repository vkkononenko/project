using UnityEngine;
using System.Collections;

public class weapon_fire : MonoBehaviour {

	public GameObject fire_position;
	public GameObject bullet;
	public int bullet_speed;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButton (0)) {
			GameObject bullet_fire = (GameObject)Instantiate (bullet, fire_position.transform.position, Quaternion.identity);
			bullet_fire.GetComponent<Rigidbody> ().AddForce (transform.forward * bullet_speed);
		}
	}
}
