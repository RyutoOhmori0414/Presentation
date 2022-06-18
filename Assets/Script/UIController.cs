using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] Text _text = default;
    [SerializeField] Text _resultText = default;
    [SerializeField] Text _hitokoto = default;
    [SerializeField] Image _strike1 = default;
    [SerializeField] Image _strike2 = default;
    [SerializeField] Text _s = default;
    [SerializeField] GameObject _next = default;
    [SerializeField] Image _white = default;
    [SerializeField] Image _ojosama = default;
    [SerializeField] Image _fukidasi = default;

   [SerializeField] Transform _ballTransform = default;
    [SerializeField] float _distance = default;
    [SerializeField] string[] _hagemasi;
    [SerializeField] string[] _botiboti;
    [SerializeField] string[] _sugoi;
    [SerializeField] string[] _tonndemonaidesuwa;

    int _a = default;
    int _b = default;
    int _c = default;
    int _d = default;

    int _mojisuu = default;
    float _keikajikan = default;
    string _talkOjousama;

    float _bT = default;
    public static bool _resultCheck = default;
    string _mesugakiOjousama = default;

    // Start is called before the first frame update
    void Start()
    {
        _mojisuu = 0;
        _resultText.text = null;
        _hitokoto.text = null;
        _next.SetActive(false);
        _white.enabled = false;
        _ojosama.enabled = false;
        _fukidasi.enabled = false;
        //_bT = _ballTransform.position.x;
        //_text.text = $"{ _bT.ToString("2")}";
        if (SceneManage._strikes == 0)
        {
            _strike1.enabled = false;
            _strike2.enabled = false;
        }
        else if (SceneManage._strikes == 1)
        {
            _strike2.enabled = false;
        }

        _a = Random.Range(0, _hagemasi.Length);
        _b = Random.Range(0, _botiboti.Length);
        _c = Random.Range(0, _sugoi.Length);
        _b = Random.Range(0, _tonndemonaidesuwa.Length);

        _resultCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_resultCheck)
        {
            _bT = _ballTransform.position.x;
            _text.text = $"{ _bT.ToString("f2")}";
        }

        if (_resultCheck)
        {
            if (_bT < 50f)
            {
                _mesugakiOjousama = _hagemasi[_a];
            }
            else if (_bT < 100f)
            {
                _mesugakiOjousama = _botiboti[_b];
            }
            else if ( _bT < 160f)
            {
                _mesugakiOjousama = _sugoi[_c];
            }
            else
            {
                _mesugakiOjousama = _tonndemonaidesuwa[_d];
            }
            _hitokoto.text = Talk($"-‚¨ì—l‚ÌˆêŒ¾-\n{_mesugakiOjousama}");
            _resultText.text = $"”ò‹——£{_bT.ToString()}m";
            _white.enabled = true;
            _ojosama.enabled = true;
            _fukidasi.enabled = true;
            _next.SetActive(true);
            _text.text = null;
            _s.enabled = false;
            _strike1.enabled = false;
            _strike2.enabled = false;
            SceneManage._result = _ballTransform.position.x;
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
