using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEggys1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Eggy"))
        {
            Destroy(other.gameObject);
            ScoreManager.instance.IncreaseScore();
        }
    }
}
