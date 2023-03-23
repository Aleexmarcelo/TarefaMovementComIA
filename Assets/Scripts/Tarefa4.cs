using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarefa4 : MonoBehaviour
{
    public float speed = 2.0f;
    public float accuracy = 0.1f;
    public Transform alvo;

    private void Update()
    {
        this.transform.LookAt(alvo.position);
        Vector3 direction = alvo.position - this.transform.position;
        Debug.DrawRay(this.transform.position, direction, Color.red);
        if(direction.magnitude > accuracy)
            this.transform.Translate(direction.normalized * speed * Time.deltaTime,Space.World);
    }
}

