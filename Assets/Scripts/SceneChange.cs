using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
	AudioSource myButton;

	void Awake()
	{
		myButton = GetComponent<AudioSource>();
	}
    public void changeScene(string sceneName){
    	Application.LoadLevel (sceneName);
    }

    public void PlaySound();
    {
    	myButton.Play();
    }
}
