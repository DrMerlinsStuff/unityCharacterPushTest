using UnityEngine;
using System.Collections;

public class MoveBoxes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MoveForward ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void MoveForward()
	{
		iTween.MoveAdd ((gameObject), iTween.Hash ("z", .5f, "islocal", true, "time", .5, "easetype", "linear", "oncomplete", "MoveBack", "onCompleteTarget", gameObject));
	}

	void MoveBack()
	{
		iTween.MoveAdd ((gameObject), iTween.Hash ("z", -.5f, "islocal", true, "time", .5, "easetype", "linear", "oncomplete", "MoveForward", "onCompleteTarget", gameObject));
	}
}
