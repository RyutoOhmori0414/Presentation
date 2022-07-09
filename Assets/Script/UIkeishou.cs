using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UIkeishou : MonoBehaviour
{
    float _distance = default;
    
    int _mojisuu = default;
    float _keikajikan = default;
    string _talkOjousama;

    bool _keyCheck;

    protected void Start()
    {
        _mojisuu = 0;
        _keyCheck = false;
        _distance = SceneManage._speakDistance;
        _distance = Speed(_distance);
    }
    protected string TalkSkip(string Ojousama)
    {
        if (Input.GetKeyDown(KeyCode.K) || _keyCheck)
        {
            Debug.Log("K“ü‚Á‚Æ‚é‚Å");
            _keyCheck = true;
            return Ojousama;
        }
        else
        {
            if (Time.realtimeSinceStartup - _keikajikan > _distance && _mojisuu < Ojousama.Length)
            {
                _mojisuu++;
                _talkOjousama = Ojousama.Substring(0, _mojisuu);
                _keikajikan = Time.realtimeSinceStartup;
            }
            return _talkOjousama;
        }
    }

    protected virtual float Speed(float _distance)
    {
        return _distance;
    }
}
