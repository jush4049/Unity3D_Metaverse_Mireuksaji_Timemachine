using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class PortalManagerTwo : MonoBehaviour
{
    void OnTriggerEnter(Collider _col)
    {
        if (_col.gameObject.tag == "Portal")
        {
            Destroy(gameObject);

            PhotonNetwork.Instantiate("Man", new Vector3(-14, 2, 32), Quaternion.identity, 0);
        }
        else
        {
            return;
        }
    }
}