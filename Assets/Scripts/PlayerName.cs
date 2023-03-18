using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class PlayerName : MonoBehaviourPun
{
    void Start()
    {
        gameObject.GetComponent<TMP_Text>().text = photonView.Controller.NickName;
    }
}
