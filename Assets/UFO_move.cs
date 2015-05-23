using UnityEngine;
using System.Collections;

public class UFO_move : MonoBehaviour {

	//public void Translate (float x, float y, float z);
	bool x = false; 
	bool z = false;

	// Use this for initialization
	void Start () {

		this.transform.Translate (0, 1, 0);

	}
	
	// Update is called once per frame
	void Update () {

		float speed = 0.05f;

		//if (this.transform < this.transform.Translate (0, 1, 0)) {

		
			if (Input.GetKey (KeyCode.DownArrow)) {
				this.transform.position += this.transform.forward * -1 * speed;

			} else if (Input.GetKey (KeyCode.LeftArrow) && x == false) {
				this.transform.position += this.transform.forward * -1 * speed;
				x = true;
			} else if (Input.GetKey (KeyCode.UpArrow)) {
				this.transform.Translate (this.transform.up * -1 * speed);
			} else if (Input.GetKey (KeyCode.RightArrow)) {
				this.transform.position += this.transform.right * -1 * speed;
			}
		//}
	}
}
