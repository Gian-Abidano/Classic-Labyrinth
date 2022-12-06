using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerMaze : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TMP_Text gameOverText;
    [SerializeField] Hole hole;
    void Update()
    {
        if(hole.Entered && gameOverPanel.activeInHierarchy == false)
        {
            gameOverPanel.SetActive(true);
            gameOverText.text = "Stage Clear";
        }
    }
    
    public void LoadScene(string sceneName)
    {
        Debug.Log("Changing to Scene " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
