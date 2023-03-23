using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newSceneDelay : MonoBehaviour
{
    public string Scene;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("ChangeScene", 7f);
        }
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(Scene);
    }
}

