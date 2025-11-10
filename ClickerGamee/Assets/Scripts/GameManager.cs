using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static bool isLoading = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Newgame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        isLoading = true;
        SceneManager.LoadScene(1);
    }
}
