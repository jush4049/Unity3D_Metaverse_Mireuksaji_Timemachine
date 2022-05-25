using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class PortalManager : MonoBehaviour
{
    private void Start()
    {
    }
    void OnTriggerEnter(Collider _col)
    {
        if (_col.gameObject.tag == "Portal")
        {
            Destroy(gameObject);
            PhotonNetwork.Instantiate("Girl", new Vector3(2159, -38, -130), Quaternion.identity, 0);
        }
        else
        {
            return;
        }
    }

}