using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

	/*
	0 = corredor || ( 2 - 4 - 5 )
	1 = corredor == 
	2 = vira pra os dois lados =|=
	3 = vira para os dois lados 180º
	*/

	public GameObject character;
	public GameObject[] tiles;
	int p = 0;

	int currentTile;

	// Use this for initialization
	void Start(){
		CreatePath();
		InvokeRepeating("CreatePath", 1, 1);
	}
	
	// Update is called once per frame
	void Update(){
	
	}

	void CreatePath(){

		NextTile();

		//Instantiate(tiles[currentTile], new Vector3(0, 0, p*10), character.transform.rotation);
		Instantiate( tiles[currentTile], character.transform.position + transform.forward*10, character.transform.rotation );
		p++;

		Debug.Log (currentTile);
	}

	void NextTile(){
		//Random.Range(0,7);
		int lastTile;
		lastTile = currentTile;

		int nextTile = Random.Range(0,2);

		if( nextTile == 0 ){


		}

		currentTile = nextTile;
	}
}
