using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void Play()
    {
        SoundManager.instance.PlaySound(SoundManager.instance.swooshingSound);
        SceneManager.LoadScene("PlayScene");
    }
    public void BackToMenu()
    {
        SoundManager.instance.PlaySound(SoundManager.instance.swooshingSound);
        SceneManager.LoadScene("MenuScene");
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }
    public void GotoLeaderBoard()
    {
        SoundManager.instance.PlaySound(SoundManager.instance.swooshingSound);
        SceneManager.LoadScene("LeaderBoardScene");
    }
   
}
