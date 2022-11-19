using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasiTombol : MonoBehaviour 
{
	public void _animasi()
	{
		GetComponent<Animation>().Play("button");
		KumpulanSuara.instance.Panggil_Suara(0);
	}
}
