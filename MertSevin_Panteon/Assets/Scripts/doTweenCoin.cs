using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class doTweenCoin : MonoBehaviour
{
    public Vector2 targetPosition = new Vector2(361.5f, 363f);
    public float duration = 100f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            this.transform.DOMove(targetPosition, duration);
        }

    }
}
