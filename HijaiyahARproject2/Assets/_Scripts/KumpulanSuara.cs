using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KumpulanSuara : MonoBehaviour 
{
	public static KumpulanSuara instance;

	public AudioClip[] Clipnya;
	[SerializeField]List<AudioSource> Suara = new List<AudioSource>();

	private void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () 
	{
		Suara.Clear();
		for	(int i = 0; i < Clipnya.Length; i++)
		{
			Suara.Add(gameObject.AddComponent<AudioSource>());
			Suara[i].clip = Clipnya[i];
		}
	}

	public void Panggil_Suara(int i)
	{
		Suara[i].Play();
	}

}
