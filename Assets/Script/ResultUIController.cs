using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultUIController : MonoBehaviour
{
    [SerializeField] Text _resultText = default;
    [SerializeField] Text _ojosama = default;

    float _distance = default;
    [SerializeField] string[] _serifu = default;

    int _serifuNumber = default;
    int _mojisuu = default;
    float _keikajikan = default;
    string _talkOjousama;
    // Start is called before the first frame update
    void Start()
    {
        _distance = SceneManage._speakDistance;
        if (SceneManage._result != 0)
        {
            _resultText.text = $"”ò‹——£{SceneManage._result:f2}m";
        }
        else
        {
            _resultText.text = "ŽOUI";
        }
    
        _serifuNumber = Random.Range(0, _serifu.Length);
    }

    // Update is called once per frame
    void Update()
    {
        _ojosama.text = Talk(_serifu[_serifuNumber]);
    }

    string Talk(string Ojousama)
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
