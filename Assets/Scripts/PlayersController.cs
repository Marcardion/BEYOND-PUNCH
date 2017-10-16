using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayersController : NetworkBehaviour {

//	[SyncVar]
	public CardsController cardsController;

	//public Animator fighterController1;
	//public Animator fighterController2;
	bool beginCombate = false;

	bool turn1 = false;
	bool turn2 = false;
	bool turn3 = false;

	public Fighter_Controller fighterController1;
	public Fighter_Controller fighterController2;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		Debug.Log (cardsController.p1slot1Choose );

		if (cardsController.p1slot1Choose != "" &&
		   	cardsController.p1slot2Choose != "" &&
		  	cardsController.p1slot3Choose != "" &&
		
			cardsController.p2slot1Choose != "" &&
			cardsController.p2slot2Choose != "" &&
			cardsController.p2slot3Choose != ""

		
			) {

			StartCoroutine (combate ());

			Debug.Log ("cardsController.slot1Choose");
		
		}

	}

	IEnumerator combate(){

		if (!beginCombate) {
			beginCombate = true;

			if (!turn1) {
				yield return new WaitForSeconds (1.0f);
				cardComb (cardsController.p1slot1Choose, cardsController.p2slot1Choose);
				turn1 = true;
			}

			if (!turn2) {
				yield return new WaitForSeconds (2.0f);
				cardComb (cardsController.p1slot2Choose, cardsController.p2slot2Choose);
				turn2 = true;
			}

			if (!turn3) {
				yield return new WaitForSeconds (2.0f);
				cardComb (cardsController.p1slot3Choose, cardsController.p2slot3Choose);
				turn3 = true;
			}



		}

	}


	void cardComb(string P1, string P2){


		if(P1 == "punch"){

			fighterController1.Punch();

		}

		if(P1 == "grab"){

			fighterController1.Grab();

		}

		if(P1 == "block"){

			fighterController1.Block();

		}

		if(P2 == "punch"){

			fighterController2.Punch();

		}

		if(P2 == "grab"){

			fighterController2.Grab();

		}

		if(P2 == "block"){

			fighterController2.Block();

		}



	}



}
