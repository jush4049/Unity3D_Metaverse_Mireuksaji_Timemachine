using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public GameObject player;

     private void Start()
     {
        Debug.Log("연결 시작");
         //방에 입장한 후에 플레이어 생성
         PhotonNetwork.Instantiate("Man", new Vector3(0,0,0), Quaternion.identity, 0);
         Debug.Log("캐릭터 생성");
    }

    // 접속 종료 버튼을 누를 시 작동하는 함수
    public void OnDisconnect()
    {
        PhotonNetwork.Disconnect();
        Debug.Log("접속을 종료합니다");
        SceneManager.LoadScene("Lobby");
    }
}
