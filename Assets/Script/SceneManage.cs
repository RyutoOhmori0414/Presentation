using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    // Start is called before the first frame update
    public static int _strikes = default;
    public static float _result = default;
    public static float _highScore = default;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void TitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public static void ResultScene()
    {
        SceneManager.LoadScene("ResultScene");
        if (_result > _highScore)
        {
            _highScore = _result;
        }
    }
    public static void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        _strikes++;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("GameScene");
        _strikes = 0;
        _result = 0f;
    }
}
