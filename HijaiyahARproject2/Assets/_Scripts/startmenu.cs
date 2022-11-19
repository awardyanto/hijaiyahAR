using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startmenu : MonoBehaviour {

	public void mailto(string mail) {
		Application.OpenURL("mailto:"+mail);
	}
		
	public void sound_volume(float volume) {
		PlayerPrefs.SetFloat("volume",volume);
	}
}
