using System;
using System.Collections;
using UnityEngine;
using DG.Tweening;

public class EggyMove : MonoBehaviour
{
    public static EggyMove instance = null;
    
    [SerializeField] private Collider2D _collider2D;
    
    private void Start()
    {
        instance = this;
        StartCoroutine(OffColliderTrigger());
    }

    private void Update()
    {
        if (gameObject.transform.position.y > 0)
        {
            gameObject.tag = "EggyPos";
        }
        else
        { 
            //gameObject.tag = "Eggy";
        }
        
    }

    private IEnumerator OffColliderTrigger()
    {
        yield return new WaitForSeconds(3.5f);
        _collider2D.isTrigger = true;
    }

    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("UpBasket"))
        {
            Destroy(gameObject);
            ScoreManager.instance.IncreaseScore();
        }

        if (other.CompareTag("DownBasket"))
        {
            Destroy(gameObject);
            ScoreManager.instance.IncreaseScore();
        }
    }
    */
}
