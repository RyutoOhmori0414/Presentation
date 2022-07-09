using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleUI : UIkeishou
{
    [SerializeField] Text _text;
    [SerializeField] Image _fukidasi;
    [SerializeField] GameObject _setting;
    [SerializeField] Dropdown _dropdown;

    //float _distance = default;
    [SerializeField] float _yukkuri;
    [SerializeField] float _futu;
    [SerializeField] float _hayai;

    /*int _mojisuu = default;
    float _keikajikan = default;
    string _talkOjousama;*/
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        _dropdown.value = SceneManage._dropdownValue;
        _setting.SetActive(false);
        //_distance = SceneManage._speakDistance;
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
            _text.text = TalkSkip($"¡‚ÌÅ’·”ò‹——£‚Í {SceneManage._highScore.ToString("f2")}m‚Å‚·‚í");
        }

        if (_dropdown.value == 0)
        {
            SceneManage._speakDistance = _futu;
            SceneManage._dropdownValue = 0;
        }
        else if (_dropdown.value == 1)
        {
            SceneManage._speakDistance = _hayai;
            SceneManage._dropdownValue = 1;
        }
        else if (_dropdown.value == 2)
        {
            SceneManage._speakDistance = _yukkuri;
            SceneManage._dropdownValue =@2;
        }
    }

    protected override float Speed(float _distance)
    {
        _distance *= Random.value;
        return _distance;
    }

    /*string Talk(string Ojousama)
    {
        if (Time.realtimeSinceStartup - _keikajikan > _distance && _mojisuu < Ojousama.Length)
        {
            _mojisuu++;
            _talkOjousama = Ojousama.Substring(0, _mojisuu);
            _keikajikan = Time.realtimeSinceStartup;
        }
        return _talkOjousama;
    }*/

    public void OpenSetting()
    {
        _setting.SetActive(true);
    }

    public void CloseSetting()
    {
        _setting.SetActive(false);
    }
}
