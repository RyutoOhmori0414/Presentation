using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleUI : MonoBehaviour
{
    [SerializeField] Text _text;
    [SerializeField] Image _fukidasi;

    [SerializeField] float _distance = default;

    int _mojisuu = default;
    float _keikajikan = default;
    string _talkOjousama;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManage._highScore == 0)
        {
            _text.enabled = false;
            _fukidasi.enabled = false;
        }
        else
        {
            _text.text = Talk($"¡‚ÌÅ’·”ò‹——£‚Í {SceneManage._highScore.ToString("f2")}m‚Å‚·‚í");
        }
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
