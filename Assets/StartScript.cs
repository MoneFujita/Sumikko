using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x < -6 || this.transform.position.x > 12) {
			this.transform.position = new Vector3 (2.0f,4.0f,0);
		}
		if (this.transform.position.y < 0 || this.transform.position.y > 8) {
			this.transform.position = new Vector3 (2.0f,4.0f,0);
		}
	}
		
	void OnMouseDrag(){
		Vector3 objectPointInScreen
			= Camera.main.WorldToScreenPoint (this.transform.position);

		Vector3 mousePointInScreen
			= new Vector3 (Input.mousePosition.x,Input.mousePosition.y,objectPointInScreen.z);

		Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint (mousePointInScreen);
		mousePointInWorld.z = this.transform.position.z;
		this.transform.position = mousePointInWorld;
	}
}
