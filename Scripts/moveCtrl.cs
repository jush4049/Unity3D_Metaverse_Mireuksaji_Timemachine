using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Cinemachine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class moveCtrl : MonoBehaviourPunCallbacks, IPunObservable
{
    public float moveSpeed = 5.0f; // 이동 속도
    public float rotateSpeed = 100.0f; // 회전 속도

    public int jumpPower = 2; // 점프 거리

    private Transform tr; // 위치

    private Animator animator; // 애니메이션
    private bool IsMove; // 움직임 여부

    private PhotonView photonview; // 포톤 뷰
    public Transform target; // 플레이어

    private Rigidbody rigid; // 리지드바디
    private bool IsJumping; // 점프 가능 여부

    private void Start()
    {
        // 각각의 컴포넌트를 받아옴
        tr = GetComponent<Transform>();

        photonview = GetComponent<PhotonView>();

        animator = GetComponent<Animator>();

        rigid = GetComponent<Rigidbody>();
        IsJumping = false; // 점프 중 인지 판단하는 bool 값

        if (this.photonview.IsMine)
        {
            var followCam = FindObjectOfType<CinemachineVirtualCamera>();

            followCam.Follow = this.tr;
            followCam.LookAt = this.tr;
        }
        // 로컬플레이어가 아닌 경우 입력 받지 않음
        if (!photonview.IsMine)
        {
            return;
        }
    }

    private void Update()
    {
        if (photonView.IsMine) // 애니메이션 동작함수
        {
            Animations();
            Jump();
        }
        UpdateAnimation();
    }

    void UpdateAnimation() // 다른 네트워크 플레이어의 애니메이션을 보는 함수
    {
        animator.SetFloat("IsWalk", moveSpeed); // 걷는 모션
    }

    void Animations()
    {
        //controlled locally일 경우 이동(자기 자신의 캐릭터일 때)
        if (photonView.IsMine)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = (Vector3.forward * moveVertical) + (Vector3.right * moveHorizontal);

            // 이동과 회전을 함께 처리
            transform.position += movement * moveSpeed * Time.deltaTime;
            // 회전하는 부분
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(movement), Time.deltaTime * rotateSpeed);

            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)
                || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                IsMove = true;
            }
            else
            {
                IsMove = false;
            }
        }

        else
        {
            //끊어진 시간이 너무 길 경우(텔레포트)
            if ((tr.position - currPos).sqrMagnitude >= 10.0f * 10.0f)
            {
                tr.position = currPos;
                tr.rotation = currRot;
            }
            //끊어진 시간이 짧을 경우(자연스럽게 연결 - 데드레커닝)
            else
            {
                tr.position = Vector3.Lerp(tr.position, currPos, Time.deltaTime * 10.0f);
                tr.rotation = Quaternion.Slerp(tr.rotation, currRot, Time.deltaTime * 10.0f);
            }
        }

        if (IsMove == false) // 움직이지 않을때는 동작 정지
        {
            animator.SetBool("IsWalk", false);
            //animator.SetBool("Breathing Idle", true);
        }
        else // 움직이는 경우 동작 활성화
        {
            animator.SetBool("IsWalk", true);
        }
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.LeftAlt)) // 왼쪽 알트키를 누르면 점프
            {
            if (!IsJumping) // 바닥에 있으면
            {
                // 점프 가능
                IsJumping = true;
                rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            }
         else // 공중에 떠있으면
            {
                // 점프 불가능
                return; 
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 바닥에 닿으면
        if (collision.gameObject.CompareTag("Ground"))
        {
            // 점프가 가능한 상태
            IsJumping = false;
        }
    }

    //클론이 통신을 받는 변수 설정
    private Vector3 currPos;
    private Quaternion currRot;

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        //통신을 보내는 
        if (stream.IsWriting)
        {
            stream.SendNext(tr.position);
            stream.SendNext(tr.rotation);
        }

        //클론이 통신을 받는 
        else
        {
            currPos = (Vector3)stream.ReceiveNext();
            currRot = (Quaternion)stream.ReceiveNext();
        }
    }
}