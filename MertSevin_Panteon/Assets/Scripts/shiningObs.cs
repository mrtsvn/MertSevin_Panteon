using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiningObs : MonoBehaviour
{
    public float startX;
    public float endX;
    public float speed = 1f;

    private bool movingRight = true;
    private float targetX;

    private ParticleSystem particleSystem;

    private void Awake()
    {
        targetX = startX;
    }

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
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

        transform.Rotate(Vector3.up, 100f * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        ChangeColor();
    }

    public void ChangeColor()
    {
        Color randomColor = GetRandomColor();
        var mainModule = particleSystem.main;
        mainModule.startColor = new ParticleSystem.MinMaxGradient(randomColor);
    }

    private Color GetRandomColor()
    {
        float randomValue = Random.value;
        if (randomValue < 0.33f)
        {
            return Color.yellow;
        }
        else if (randomValue < 0.66f)
        {
            return Color.green;
        }
        else
        {
            return Color.blue;
        }
    }
}
