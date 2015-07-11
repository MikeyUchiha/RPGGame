using UnityEngine;
using System.Collections;

public class TestLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LoadInformation.LoadAllInformation();
		Debug.Log("LOADED ALL INFORMATION");
		Debug.Log("Player Name: " + GameInformation.PlayerName);
		Debug.Log("Player Level: " + GameInformation.PlayerLevel);
		Debug.Log("Player Strength: " + GameInformation.Strength);
		Debug.Log("Player Agility: " + GameInformation.Agility);
		Debug.Log("Player Dexterity: " + GameInformation.Dexterity);
		Debug.Log("Player Vitality: " + GameInformation.Vitality);
		Debug.Log("Player Intelligence: " + GameInformation.Intelligence);
		Debug.Log("Player Luck: " + GameInformation.Luck);
		Debug.Log("Player Gold: " + GameInformation.Gold);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
