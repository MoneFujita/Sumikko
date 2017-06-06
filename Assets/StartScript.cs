using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {
	public ChangeScript changeScript;
	Vector3 poss;


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (this.transform.position.x < -6 || this.transform.position.x > 12) {
			poss = changeScript.Pos;
			this.transform.position = poss;
		}
		if (this.transform.position.y < -2 || this.transform.position.y > 8) {
			poss = changeScript.Pos;
			this.transform.position = poss;
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
