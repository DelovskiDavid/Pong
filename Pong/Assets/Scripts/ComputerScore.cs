using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerScore : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Ball ball = other.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            GameManager.Instance.ComputerScores();
        }

    }
}
