using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public void changeScene(string sceneName){
    	Application.LoadLevel (sceneName);
    }
}
