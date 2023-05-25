using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonut : MonoBehaviour
{
    public float startX;
    public float endX;
    public float speed = 1f;

    private bool movingRight = true;
    private float targetX;

    private void Awake()
    {
        targetX = startX;
    }

    private void Update()
    {
        MoveObject();
    }

    private void MoveObject()
    {
        float currentX = transform.position.z;
        float direction = movingRight ? 1f : -1f;
        float distanceToTargetX = Mathf.Abs(currentX - targetX);

        if (distanceToTargetX < 0.01f)
        {
            movingRight = !movingRight;
            targetX = movingRight ? endX : startX;
        }

        float step = speed * Time.deltaTime;
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, targetX);
        transform.position = Vector3.MoveTowards(transform.position, newPosition, step);
    }
}
