using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Transform _spawnLocation;
    private static GameObject localPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.Instantiate("Characters/Player", _spawnLocation.position, Quaternion.identity);
    }
}
