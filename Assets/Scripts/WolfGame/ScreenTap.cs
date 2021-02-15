using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTap : MonoBehaviour
{ 
    public void RightDown()
    {
        WolfManager.instance.DownHands();
    }
    
    public void RightUp()
    {
        WolfManager.instance.UpHands();
    }
    
    public void LeftDown()
    {
        WolfManager.instance.DownHands();
    }
    
    public void LeftUp()
    {
        WolfManager.instance.UpHands();
    }

    public void WolfLeftPosition()
    {
        WolfManager.instance.WolfLeftPosition();
    }
    
    public void WolfRightPosition()
    {
        WolfManager.instance.WolfRightPosition();
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        StartCoroutine(EggysSpawn.instance.EggySpawn());
    }
}
