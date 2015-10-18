using UnityEngine;
using System.Collections;

public class RotatePlayer : MonoBehaviour {

	private Transform player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void RotatePlayerClick(){
		if(this.name == "RotateLeft"){
			player.Rotate(Vector3.up * 10);
		}
		if(this.name == "RotateRight"){
			player.Rotate(Vector3.down * 10);
		}
	}
}
