using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneChange : MonoBehaviour
{
    [SerializeField] Transform _pitch = default;
    [SerializeField] Transform _bat= default;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManage._strikes == 3)
        {
            SceneManage.ResultScene();
        }
        else if (_pitch.position.x < -10 && _bat.position.x == 0)
        {
            SceneManage.ResetGame();
        }
    }
}
