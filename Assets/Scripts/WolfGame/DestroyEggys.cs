using System;
using System.Collections;
using UnityEngine;

public class DestroyEggys : MonoBehaviour
{
    [SerializeField] private Animator _eggyAnimator;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Eggy"))
        {
            StartCoroutine(offAnim());
            Destroy(other.gameObject);
            _eggyAnimator.SetBool("playEggy", true);
            HealthManager.instance.DecreaseScore();
        }
    }

    private IEnumerator offAnim()
    {
        yield return new WaitForSeconds(2f);
        _eggyAnimator.SetBool("playEggy", false);
    }
}