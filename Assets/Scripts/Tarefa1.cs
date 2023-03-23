using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarefa1 : MonoBehaviour
{
    //Vector3 alvo = new Vector3(0, 0, 15);
    public float speed = 2.0f;
    public Transform alvo;

    public void Update()
    {     
            Vector3 direction = alvo.position - this.transform.position;
            this.transform.Translate(direction.normalized * speed*Time.deltaTime);
            //this.transform.Translate(alvo.normalized * speed * Time.deltaTime);      
    }
}
