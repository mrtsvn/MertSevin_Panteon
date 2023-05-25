using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonut : MonoBehaviour
{
    public float startX = 0.12f;
    public float endX = 0.1f;
    public float speed = 1f;

    private bool movingRight = true;
    private float targetX;

    void Start()
    {
        targetX = startX;
    }

    void Update()
    {
        float distanceToTargetX = Mathf.Abs(transform.position.x - targetX);

        if (distanceToTargetX < 0.01f)
        {
            movingRight = !movingRight;
            targetX = movingRight ? endX : startX;
        }

        float direction = movingRight ? 1f : -1f;
        transform.position += new Vector3(0f, 0f, direction * speed * Time.deltaTime);
    }
}
