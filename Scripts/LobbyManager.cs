using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    private string gameVersion = "1"; // 게임 버전

    public Text IDtext; // 사용자 아이디 텍스트
    public Text connectionInfoText; // 네트워크 정보 표시 텍스트
    public Button joinButton; // 룸 접속 버튼

    public GameObject Man;

    // Start is called before the first frame update
    private void Start() // 실행과 동시에 마스터 서버 접속 시도 
    {
        // 접속에 필요한 정보 설정
        PhotonNetwork.GameVersion = gameVersion;
        // 설정한 정보를 가지고 마스터 서버 접속 시도
        PhotonNetwork.ConnectUsingSettings();

        // 룸 접속 버튼 잠시 비활성화
        joinButton.interactable = false;
        Debug.Log("버튼 비활성화, 서버 연결 중");
        // 접속 시도 중임을 텍스트로 표시
        connectionInfoText.text = "서버에 접속하는 중...";

    }

    // 마스터 서버 접속 성공시 자동 실행
    public override void OnConnectedToMaster()
    {
        // 룸 접속 버튼 활성화
        joinButton.interactable = true;
        // 접속 정보 표시
        connectionInfoText.text = "서버에 연결됨 - 온라인 상태";
        Debug.Log("버튼 활성화, 서버 연결 성공");
    }

    // 마스터 서버 접속 실패시 자동 실행
    public override void OnDisconnected(DisconnectCause cause)
    {
        // 룸 접속 버튼 잠시 비활성화
        joinButton.interactable = false;
        // 접속 정보 표시
        connectionInfoText.text = "서버에 연결되지 않음 - 오프라인 상태.";
        Debug.Log("버튼 비활성화, 서버 연결 실패");

        // 마스터 서버로의 재접속 시도
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("서버 재접속 시도"); 
    }

    // 룸 접속 시도
    public void Connect()
    {
        if (IDtext.text.Equals(""))
        {
            connectionInfoText.text = "닉네임을 입력해주세요!";
            return;
        }
        else
        {
            PhotonNetwork.LocalPlayer.NickName = IDtext.text;

            // 중복 접속 시도 방지, 접속 버튼 비활성화
            joinButton.interactable = false;
            Debug.Log("버튼 비활성화");

        // 마스터 서버에 접속중이면
        if (PhotonNetwork.IsConnected)
        {
            // 룸 접속 실행
            connectionInfoText.text = "룸에 접속중...";
            PhotonNetwork.JoinRandomRoom();
            Debug.Log("룸에 연결중");
        }
        else
        {
            // 마스터 서버에 접속중이 아니면, 마스터 서버에 접속 시도
            connectionInfoText.text = "서버에 연결되지 않음 - 재접속 시도중...";
            PhotonNetwork.ConnectUsingSettings();
            Debug.Log("서버에 연결안됨, 재접속 시도");
        }
     }
 }

        // 빈 방이 없어 랜덤 룸 참가에 실패한 경우 자동 실행
        public override void OnJoinRandomFailed(short returnCode, string message)
    {
        // 접속상태 표시
        connectionInfoText.text = "빈 방이 없음, 새로운 방 생성 시도중...";
        // 최대 4명 수용 가능한 빈방 생성
        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = 4 });
        Debug.Log("빈 방 없음, 새로운 방 생성 중");

    }

    // 룸에 참가 완료된 경우 자동 실행
    public override void OnJoinedRoom()
    {
        // 접속 상태 표시
        connectionInfoText.text = "방 참가 성공...잠시만 기다려주세요";
        // 모든 룸 참가자들이 Main 씬 로드
        PhotonNetwork.LoadLevel("Main");
        Debug.Log("룸 연결 성공, 메인 씬으로 이동");
    }
}
