using System;
using UnityEngine;

public class WolfManager : MonoBehaviour
{
    public static WolfManager instance = null;
    
    [SerializeField] private GameObject _upHands;
    [SerializeField] private GameObject _downHands;

    [SerializeField] private float _wolfXPosition;
    [SerializeField] private float _wolfYPosition;

    [SerializeField] private GameObject _gameOver;
    
    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        if (HealthManager.instance._health <= 0)
        {
            _gameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void UpHands()
    {
        _downHands.SetActive(false);
        _upHands.SetActive(true);
    }

    public void DownHands()
    {
        _upHands.SetActive(false);
        _downHands.SetActive(true);
    }

    public void WolfLeftPosition()
    {
        transform.position = new Vector2(-_wolfXPosition, _wolfYPosition);
        transform.localScale = new Vector2(1f, 1f);
    }
    
    public void WolfRightPosition()
    {
        transform.position = new Vector2(_wolfXPosition, _wolfYPosition);
        transform.localScale = new Vector2(-1f, 1f);
    }
}
