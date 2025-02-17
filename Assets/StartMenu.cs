using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;

public class StartMenu : MonoBehaviour
{
   public void PlayGame(){
        SceneManager.LoadSceneAsync(1);
   }
}
