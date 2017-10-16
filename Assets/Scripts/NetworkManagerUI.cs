using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkManagerUI : MonoBehaviour {

	public NetworkManager networkManager;
	public Animator gameAnimator;
	public Animator lightsAnimator;

	public void CreateServer (){

		networkManager.StartHost ();
		gameAnimator.SetTrigger ("start");
		lightsAnimator.SetTrigger ("start");

	}

	public void ConnectClient(){

		networkManager.StartClient ();
		gameAnimator.SetTrigger ("start");
		lightsAnimator.SetTrigger ("start");
	}


}
