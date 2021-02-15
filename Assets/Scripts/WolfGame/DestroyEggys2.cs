using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEggys2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EggyPos"))
        {
            Destroy(other.gameObject);
            ScoreManager.instance.IncreaseScore();
        }
    }
}
