﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateCollider : MonoBehaviour
{
	public string NextMap;
	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene(NextMap);
	}
}
