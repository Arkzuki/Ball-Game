using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkController : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        //Ansluter till Photon Servrarna
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Ansluten till" + PhotonNetwork.CloudRegion + "servern");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
