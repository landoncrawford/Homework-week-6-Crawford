using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverBehavior : MonoBehaviour
{
    public void OnRestartButtonPressed ()
    {
        SceneManager.LoadScene(0);
    }
}
