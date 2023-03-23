using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(sceneName);
                Debug.Log("Load");
            }
        }
    }