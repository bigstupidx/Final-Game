﻿using UnityEngine;
using System.Collections;

public class ChangeLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log("ddsds");
	}

	public void HadleLoadLevel(int Level){
		
		Application.LoadLevel ("Level" + Level);
	}
}
