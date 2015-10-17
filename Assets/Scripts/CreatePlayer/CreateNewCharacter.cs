using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {

	private BasePlayer newPlayer;
	private string playerName = "Enter Name";
	public GameObject ClassCreatePanel;
	private Toggle squireClassToggle;
	private Toggle mageClassToggle;
	private InputField playerNameInput;

	// Use this for initialization
	void Start () {
		CreateUI();
		newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void CreateUI(){
		GameObject canvas = GameObject.Find("Canvas");
		GameObject classCreate = Instantiate(ClassCreatePanel) as GameObject;
		RectTransform myTransform = classCreate.GetComponent<RectTransform>();
		myTransform.SetParent(canvas.transform, false);
		Button createCharacter = GameObject.Find("createCharacter").GetComponent<Button>();
		createCharacter.onClick.AddListener(() => {CreateCharacter();});
		Button loadCharacter = GameObject.Find("loadCharacter").GetComponent<Button>();
		loadCharacter.onClick.AddListener(() => {LoadCharacter();});
		squireClassToggle = GameObject.Find("isSquireClass").GetComponent<Toggle>();
		mageClassToggle = GameObject.Find("isMageClass").GetComponent<Toggle>();
		squireClassToggle.isOn = true;
	}

	void CreateCharacter(){
		CreateNewPlayer();
		StoreNewPlayerInfo();
		SaveInformation.SaveAllInformation();
		Debug.Log("Player Name: " + newPlayer.PlayerName);
		Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
		Debug.Log("Player Level: " + newPlayer.PlayerLevel);
		Debug.Log("Player Strength: " + newPlayer.Strength);
		Debug.Log("Player Agility: " + newPlayer.Agility);
		Debug.Log("Player Dexterity: " + newPlayer.Dexterity);
		Debug.Log("Player Vitality: " + newPlayer.Vitality);
		Debug.Log("Player Intelligence: " + newPlayer.Intelligence);
		Debug.Log("Player Luck: " + newPlayer.Luck);
		Debug.Log("Player Gold: " + newPlayer.Gold);
	}

	void LoadCharacter(){
		Application.LoadLevel("Test");
	}

	private void StoreNewPlayerInfo(){
		GameInformation.PlayerName = newPlayer.PlayerName;
		GameInformation.PlayerLevel = newPlayer.PlayerLevel;
		GameInformation.PlayerClass = newPlayer.PlayerClass;
		GameInformation.Strength = newPlayer.Strength;
		GameInformation.Agility = newPlayer.Agility;
		GameInformation.Dexterity = newPlayer.Dexterity;
		GameInformation.Vitality = newPlayer.Vitality;
		GameInformation.Intelligence = newPlayer.Intelligence;
		GameInformation.Luck = newPlayer.Luck;
		GameInformation.Gold = newPlayer.Gold;
	}

	private void CreateNewPlayer(){
		if(squireClassToggle.isOn){
			newPlayer.PlayerClass = new BaseSquireClass();
		}else if(mageClassToggle.isOn){
			newPlayer.PlayerClass = new BaseMageClass();
		}
		playerName = GameObject.Find("playerName").GetComponent<InputField>().text;
		newPlayer.PlayerName = playerName;
		newPlayer.PlayerLevel = 1;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Agility = newPlayer.PlayerClass.Agility;
		newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
		newPlayer.Vitality = newPlayer.PlayerClass.Vitality;
		newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
		newPlayer.Luck = newPlayer.PlayerClass.Luck;
		newPlayer.Gold = 100;
	}
}
