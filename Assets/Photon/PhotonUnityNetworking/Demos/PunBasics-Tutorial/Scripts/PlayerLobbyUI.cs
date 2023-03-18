using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class PlayerLobbyUI : MonoBehaviour
{
    [SerializeField] private GameObject nickNameUI;
    [SerializeField] private GameObject actorNumUI;
    [SerializeField] private GameObject idUI;
    [SerializeField] private GameObject hostIcon;
    public GameObject promoteButton;

    public void Initialize(string nickName, string actorNum, string id, bool host, bool playerIsMaster) {
        nickNameUI.GetComponent<Text>().text = nickName;
        actorNumUI.GetComponent<Text>().text = actorNum;
        idUI.GetComponent<Text>().text = id;
        if(host) {
            hostIcon.GetComponent<Image>().color = Color.red;
        } else {
            hostIcon.GetComponent<Image>().color = Color.green;
        }

        if(playerIsMaster && !host) {
            promoteButton.SetActive(true);
        } else {
            promoteButton.SetActive(false);
        }
    }

    public void Promote() {
        hostIcon.GetComponent<Image>().color = Color.red;
        promoteButton.SetActive(false);
    }

    public void SetNewMaster() {
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(int.Parse(actorNumUI.GetComponent<Text>().text));
		if (player != null) {PhotonNetwork.SetMasterClient(player);}
	}
}
