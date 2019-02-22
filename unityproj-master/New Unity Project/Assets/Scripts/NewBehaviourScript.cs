using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    public int whoturn;//0=x and 1=o
    public int turncount;//numeor de turnos
    public GameObject[] turnIcons; //mostra de quem é o turno
    public Sprite[] playicons;// o=x icon e 1=y icoon
    public Button[] tictactoeSpaces; //espaço jogavel

	// Use this for initialization
	void Start () {
        GameSetup();
	}

    void GameSetup() {
        whoturn = 0;
        turncount = 0;
        turnIcons[0].SetActive(true);
        turnIcons[1].SetActive(false);
        for (int i = 0; i < tictactoeSpaces.Length; i++) {
            tictactoeSpaces[i].interactable = true;
            tictactoeSpaces[1].GetComponent<Image>().sprite=null;
        }
    }

    // Update is called once per frame
    void Update()
    {
		
	}
}
