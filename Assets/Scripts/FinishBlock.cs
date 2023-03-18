using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class FinishBlock : MonoBehaviourPunCallbacks
{
    private bool finished = false;
    private int winnerId;
    private GameObject endScreen;

    void Awake() {
        //endScreen = Resources.Load("Endscreen");
    }
    private void OnTriggerEnter2D(Collider2D collider) {
        if(!finished && collider.GetComponent<PlayerMovement>()) {

            winnerId = collider.GetComponent<PlayerMovement>().photonView.ControllerActorNr;

            finished = true;
            if(PhotonNetwork.LocalPlayer.ActorNumber == winnerId) {
                ShowWinScreen();
            } else {
                ShowLoseScreen();
            }
            
            // if(PhotonNetwork.IsMasterClient) {
            //     photonView.RPC("ShowLoseScreen", RpcTarget.Others);
            // }
        }
    }

    private void ShowWinScreen() {
        endScreen = Instantiate(Resources.Load("Endscreen", typeof(GameObject))) as GameObject;
        endScreen.GetComponent<EndScreen>().Initialize(null);
    }

    [PunRPC] 
    void ShowLoseScreen() {
        endScreen = Instantiate(Resources.Load("Endscreen", typeof(GameObject))) as GameObject;
        endScreen.GetComponent<EndScreen>().Initialize(PhotonNetwork.CurrentRoom.GetPlayer(winnerId).NickName);
    }
}
