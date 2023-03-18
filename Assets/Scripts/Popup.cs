using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{
    [SerializeField] private GameObject _text;

    public void Initialize(string text) {
        _text.GetComponent<Text>().text = text;
        //Debug.LogError(text);
    }

    public void Close() {
        Destroy(this.gameObject);
    }
}
