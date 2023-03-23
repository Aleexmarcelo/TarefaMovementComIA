using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarefaTeste : MonoBehaviour
{
    public Transform[] objectsToMoveTo;
    private int currentTargetIndex = 0;
    public float moveSpeed = 5f;

    void FixedUpdate()
    {

        float distanceToTarget = Vector3.Distance(transform.position, objectsToMoveTo[currentTargetIndex].position);
        float lerpValue = Mathf.Clamp01(moveSpeed * Time.deltaTime / distanceToTarget);
        transform.position = Vector3.Lerp(transform.position, objectsToMoveTo[currentTargetIndex].position, lerpValue);

        Vector3 lookPos = objectsToMoveTo[currentTargetIndex].position - transform.position;
        lookPos.y = 0;
        if (lookPos != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(lookPos);
        }

        if (transform.position == objectsToMoveTo[currentTargetIndex].position)
        {
            if (currentTargetIndex == objectsToMoveTo.Length - 1)
            {
                return;
            }
            else
            {
                currentTargetIndex++;
            }
        }
    }
}
