using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class changeColor : MonoBehaviour
{
    public GameObject player;
    public Material material1;
    public Material material2;
    public Material material3;
    public Material material4;
    public Material material5;
    public Material material6;

    #region Trocar Cores

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            player.GetComponent<Renderer>().material = material1;
        }
        if (other.CompareTag("Trigger1"))
        {
            player.GetComponent<Renderer>().material = material2;
        }
        if (other.CompareTag("Trigger2"))
        {
            player.GetComponent<Renderer>().material = material3;
        }
        if (other.CompareTag("Trigger3"))
        {
            player.GetComponent<Renderer>().material = material4;
        }
        if (other.CompareTag("Trigger4"))
        {
            player.GetComponent<Renderer>().material = material5;
        }
        if (other.CompareTag("Trigger5"))
        {
            player.GetComponent<Renderer>().material = material6;
        }

    }
    #endregion
}
