using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("mainmenue", LoadSceneMode.Single);
      
    }
}
