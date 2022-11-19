using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fungsi_Rotasi : MonoBehaviour 
{
	public float Kecepatan;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(0, Kecepatan * 10 *Time.deltaTime, 0);
		transform.localScale = new Vector3(1, 1, 1);
	}
}
