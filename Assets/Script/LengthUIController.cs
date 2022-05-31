using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LengthUIController : MonoBehaviour
{
    [SerializeField] Text _text = default;
    [SerializeField] Transform _ballTransform = default;
    float _bT = default;

    // Start is called before the first frame update
    void Start()
    {
        //_bT = _ballTransform.position.x;
        //_text.text = $"{ _bT.ToString("2")}";
    }

    // Update is called once per frame
    void Update()
    {
        _bT = _ballTransform.position.x;
        _text.text = $"{ _bT.ToString("f2")}";
    }
}
