using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sistem : MonoBehaviour 
{
	public static Sistem instance;
	public int ID;
	public GameObject TempatSpawn;
	public GameObject Gui_Utama;
	public GameObject[] HurufHijaiyah;
	public AudioClip[] SuaraHijaiyah;
	AudioSource Suara;
	// Use this for initialization

	private void Awake()
	{
		instance = this;
	}

	void Start () 
	{
		ID = 0;
		//SpawnObject();
		Gui_Utama.SetActive(false);
		Suara = gameObject.AddComponent<AudioSource>();
	}
	
	public void SpawnObject()
	{
		GameObject BendaSebelumnya = GameObject.FindGameObjectWithTag("Hijaiyah");
		if (BendaSebelumnya != null) Destroy(BendaSebelumnya);

		GameObject Benda = Instantiate(HurufHijaiyah[ID]);
		Benda.transform.SetParent(TempatSpawn.transform, false);
		TempatSpawn.GetComponent<Animation>().Play("PopUp");
		KumpulanSuara.instance.Panggil_Suara(1);
	}

	private void update()
	{
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			GantiHijaiyah(true);
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			GantiHijaiyah(false);
		}

	}

	public void GantiHijaiyah(bool Kanan)
	{
		if (Kanan)
		{
			if(ID >= HurufHijaiyah.Length - 1)
			{
				ID = 0;
			}
			else
			{
				ID++;
			}
		}
		else
		{
			if (ID <= 0)
			{
				ID = HurufHijaiyah.Length - 1;
			}
			else
			{
				ID--;
			}
		}

		SpawnObject();
		PanggilSuara();
	}

	public void PanggilSuara()
	{
		Suara.clip = SuaraHijaiyah[ID];
		Suara.Play();
	}
}