using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{

    public Text ChatText; // ���� ä���� ������ �ؽ�Ʈ
    public Text CharacterName; // ĳ���� �̸��� ������ �ؽ�Ʈ
    public GameObject KingImage; // �� �̹���
    public GameObject PrincessImage; // ���� �̹���
    public GameObject PondImage; // ���� �̹���
    public GameObject DragonImage; // �� �̹���
    public GameObject BabyImage; // �Ʊ� �̹���
    public GameObject MaImage; // �� �̹���
    public GameObject MarketImage; // ���� �̹���
    public GameObject GyeongjuImage; // ���� �̹���
    public GameObject TownImage; // ���� �̹���
    public GameObject GoldImage; // �� ��� �̹���
    public GameObject CoupleImage; // Ŀ�� �̹���
    public GameObject FieldImage; // �� �̹���
    public GameObject ALotOfGoldImage; // ���� �� ��� �̹���
    public GameObject SajasaImage; // ���ڻ� �̹���
    public GameObject JimyeongImage; // ������� �̹���

    public List<KeyCode> skipButton; // ��ȭ�� ������ �ѱ� �� �ִ� Ű

    public string writerText = "";

    bool isButtonClicked = false;

    public void Start()
    {
        StartCoroutine(FirstStory());
    }

    public void StartTwo()
    {
        //StartCoroutine(SecondStory());
    }

    public void Update()
    {
        foreach (var element in skipButton) // ��ư �˻�
        {
            if (Input.GetKeyDown(element))
            {
                isButtonClicked = true;
            }
        }
    }


    /*IEnumerator NormalChat(string narrator, string narration)
    {
        int a = 0;
        CharacterName.text = narrator;
        writerText = "";

        // �ؽ�Ʈ Ÿ���� ȿ��
        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return null;
        }

        //Ű�� �ٽ� ���� �� ���� ������ ���
        while (true)
        {
            if (isButtonClicked)
            {
                isButtonClicked = false;
                break;
            }
            yield return null;
        }
    }*/
    
    // �ؽ�Ʈ Ÿ���� ���� ����
    IEnumerator NormalChat(string narrator, string narration)
    {
        CharacterName.text = narrator;
        writerText = "";

        writerText += narration;
        ChatText.text = writerText;
        yield return null;

        //Ű�� �ٽ� ���� �� ���� ������ ���
        while (true)
        {
            if (isButtonClicked)
            {
                isButtonClicked = false;
                break;
            }
            yield return null;
        }
    }

    IEnumerator FirstStory()
    {
        KingImage.SetActive(false);
        PrincessImage.SetActive(false);
        DragonImage.SetActive(false);
        BabyImage.SetActive(false);
        MaImage.SetActive(false);
        MarketImage.SetActive(false);
        GyeongjuImage.SetActive(false);
        TownImage.SetActive(false);
        GoldImage.SetActive(false);
        CoupleImage.SetActive(false);
        FieldImage.SetActive(false);
        ALotOfGoldImage.SetActive(false);
        SajasaImage.SetActive(false);
        JimyeongImage.SetActive(false);

        PondImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "�� �̾߱�� ����ô� �·� �Ͽ��� �ۼ��� <�ﱹ����> 2�� ������(������)�� ���ϵ� �̾߱⸦ �������� �ϰ� �ֽ��ϴ�."));

        PondImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�����̼�", "������ ����, ����� ��� ���� ������ ������ �Ұ� Ȧ�� ��� �� ������ �־����ϴ�."));
        DragonImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�����̼�", "������ �� �տ��� ������ �ϳ� �־��µ� Ŀ�ٶ� ���� ��Ÿ���� ������ ��� ����� ������ �˴ϴ�."));
        PondImage.SetActive(false);
        DragonImage.SetActive(false);
        BabyImage.SetActive(true);
        MaImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�����̼�", "������ ���� ���̸� ���� �Ǿ���, ���̴� ����� ���� ���� ĳ�� �ȸ� �츲�� ���Խ��ϴ�."));
        yield return StartCoroutine(NormalChat("�����̼�", "������� �׻� ���� ĳ�� �� ���̸� ����(���)�̶�� �ҷ����ϴ�."));
        BabyImage.SetActive(false);
        MaImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "�� �׷�, ���õ� ���� �ȷ� ������?"));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "���� �ȱ� ���� ���ͷ� ���� ������ ��̷ο� �̾߱⸦ ��� �˴ϴ�."));
        MarketImage.SetActive(true);
        yield return StartCoroutine(NormalChat("���� ���1", "�ڳ� �� �̾߱� �����?"));
        yield return StartCoroutine(NormalChat("���� ���2", "���� �̾߱� ���ΰ�?"));
        yield return StartCoroutine(NormalChat("���� ���1", "������ �ӳ��� ���� �Ŷ��� �ӱݴ��� ������� ��° ���ִ��� �׷��� �Ƹ���ٰ� �ϴ���!"));
        yield return StartCoroutine(NormalChat("���� ���2", "ȣ��, �׷� �ҹ��� �־��� ���ִ��� �̸��� �����ΰ�?"));
        yield return StartCoroutine(NormalChat("���� ���1", "��ȭ ���ִ��̶�� �Ѵٳ�"));
        yield return StartCoroutine(NormalChat("���� ���2", "�󸶳� �Ƹ��ٿ��� �ñ��ϱ��� �׷�"));
        MarketImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "��ȭ ���ִ��̶�.. ���� �ñ��Ѱ�?"));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "�׸��Ͽ� ������ �Ŷ��� ���� ���ַ� ������ �Ǿ����ϴ�."));
        GyeongjuImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "�̰��� ���ַα���!"));
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "��� �ؾ� ���ָ� ���� �� ������?"));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "������ �����ϴ� ���� ������ �ڽ��� �׻� �ȴ� ���� ���� ��� �Խ��ϴ�."));
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "�׷� �̰ž�!"));
        GyeongjuImage.SetActive(false);
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "������ ��ó ������ ���߽��ϴ�."));
        TownImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�����̼�", "�������� ���� ���̵��� ��̰� ��� �־����ϴ�."));
        yield return StartCoroutine(NormalChat("���̵�", "ó������ ����̴�!"));
        yield return StartCoroutine(NormalChat("�����̼�", "������ ���� �ִ� ���� ������ ���̵鿡�� ���߽��ϴ�."));
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "���� �̰� ���״� ��Ź �ϳ��� ����ְڴ�?"));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("���̵�", "��� ���ְڴ�! ���� ��Ź�ε���?"));
        TownImage.SetActive(false);
        GyeongjuImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�����̼�", "�� �ð� �Ŷ��� �ñȿ�����..."));
        yield return StartCoroutine(NormalChat("����", "����, ū�ϳ���ɴϴ�!"));
        yield return StartCoroutine(NormalChat("�����", "���� ���ΰ�?"));
        yield return StartCoroutine(NormalChat("����", "�װ� �׷��ϱ�..."));
        yield return StartCoroutine(NormalChat("�����", "�����? ���� ��° ���ָ� ���� �������ʶ�!"));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("��ȭ ����", "�θ��̽��ϱ�?"));
        PrincessImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����", "���� �� �ۿ��� �̻��� �뷡�� ������ �ִµ� ����̳�?"));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("��ȭ ����", "��? �װ� ����.."));
        PrincessImage.SetActive(false);
        yield return StartCoroutine(NormalChat("���̵�", "��ȭ���ִ��� ������ ��;� ���� ���ô��� �㿡 ���� �Ȱ� ����~"));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("��ȭ ����", "��, ���� �𸣴� ���Դϴ�!"));
        PrincessImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����", "�ò�����! �� ����� ���� ���ڸ� �����ٴ�... �õ� ���� ������ ���� �ÿ��� �����Ŷ�!"));
        GyeongjuImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "�׷��� ��ȭ ���ִ� �� ������ �Ѱܳ��� �Ǿ����ϴ�."));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("��ȭ ����", "��Ӵ�.. ���� ����մϴ�"));
        PrincessImage.SetActive(false);
        yield return StartCoroutine(NormalChat("����", "����, ���� ���ð� �̰��� ��������"));
        GoldImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�����̼�", "������ ��Ӵϴ� �� �ѵ���� �ǳ��־����ϴ�."));
        yield return StartCoroutine(NormalChat("����", "�и� ������ �ɰ̴ϴ�."));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("��ȭ ����", "�����մϴ�..."));
        GoldImage.SetActive(false);
        PrincessImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "�׷��� ���ִ� �;�濡 �ö����ϴ�. �Ͽ����� �ȴ� ���� ���� �տ� �� �系�� ��Ÿ�����ϴ�."));
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("??", "ó�� �˰ڽ��ϴ�. �� ���� �����ô� �� ������ �Բ� ���� �ǰڽ��ϱ�?"));
        KingImage.SetActive(false);
        CoupleImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�����̼�", "�׷��� �� ����� ���� ��⸦ �������� ���� ȣ���� ���� �Ǿ����ϴ�."));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("��ȭ ����", "�Ƿ����� ������ ��� �ǽô�����?"));
        PrincessImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "���� �������� �� �����̶�� �մϴ�."));
        KingImage.SetActive(false);
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("��ȭ ����", "�����̶��..!"));
        PrincessImage.SetActive(false);
        yield return StartCoroutine(NormalChat("���̵�", "��ȭ���ִ��� ������ ��;� ���� ���ô��� �㿡 ���� �Ȱ� ����~"));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("��ȭ ����", "����� ����鿡�� �뷡�� ��Ʈ�ȱ���."));
        PrincessImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "�½��ϴ�. ���ִ��� ������ �˰�;����ϴ�. ���ó� �Ƹ��ٿ�ñ���."));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "���ִ� ��۵��� ������ ���𰡸� ����� ��, �� ����� ����������ϴ�."));
        CoupleImage.SetActive(false);
        GoldImage.SetActive(true);
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("��ȭ ����", "���� ����� ���� ������ ���ھ��. �� �� ����� ������ �� �ſ���."));
        PrincessImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "�̰���..!"));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "������ ������ �����ϴ���, ���ֿ��� ���߽��ϴ�."));
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "�̷� ���̶�� ���� ���� ĳ�� ���� �ܶ� �ֽ��ϴ�. � ������!"));
        KingImage.SetActive(false);
        GoldImage.SetActive(false);
        FieldImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�����̼�", "�� ����� ���ѷ� ������ ���߰�, ������ �׻� ���� ĳ�� �翡 �����߽��ϴ�."));
        FieldImage.SetActive(false);
        ALotOfGoldImage.SetActive(true);
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("��ȭ ����", "�����̱���..! �̷��� ���� �� ������� ó�� ����."));
        PrincessImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "�� �� ������� �Ŷ��� �ӱݴԲ� �����帮�� �츮�� ���踦 �������ֽ� �̴ϴ�."));
        KingImage.SetActive(false);
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("��ȭ ����", "�ٵ� �� ���� �� ������� ��� �� �� ������ ������?"));
        PrincessImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "���� ������� �پ ���� �˰� �ֽ��ϴ�. �� ���̶�� �����Ұ̴ϴ�."));
        KingImage.SetActive(false);
        ALotOfGoldImage.SetActive(false);
        SajasaImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�����̼�", "�� ����� �̹��� ��ȭ�꿡 �ִ� ���ڻ��� ���� �����߽��ϴ�."));
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "�����! ��ʴϱ�?"));
        KingImage.SetActive(false);
        JimyeongImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�������", "�����̱���, �������ΰ�?"));
        JimyeongImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "������ ���������� �����ϰ� �� ����� �ű� ����� �������ϴ�."));
        JimyeongImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�������", "�׷��ٸ� ������ �� ������� ��������"));
        JimyeongImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "������, ��ȭ ���ְ� �� ����� ���� �� ������ ���� �Խ��ϴ�."));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("��ȭ ����", "�� ������ �Բ� �����ֽðھ��?"));
        PrincessImage.SetActive(false);
        JimyeongImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�������", "�˰ڳ�, �Ϸ�� ���̸� �Ŷ��� �ñȱ��� �����Ұɼ�"));
        SajasaImage.SetActive(false);
        JimyeongImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "������..."));
        GyeongjuImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�����", "�ƴ�!? �̰� ����.."));
        yield return StartCoroutine(NormalChat("�����̼�", "�Ŷ��� �ñȿ��� �� ���� �ݵ���� ��ȭ ���ְ� ���� ������ �Բ� �����־����ϴ�."));
        GyeongjuImage.SetActive(false);
        CoupleImage.SetActive(true);
        yield return StartCoroutine(NormalChat("�����̼�", "������� ������ �а� �� ����� ���̸� ������ �־��� �ʳ�, ������ ������ ������ �˴ϴ�."));
        yield return StartCoroutine(NormalChat("�����̼�", "�� ����� �ٷ� ������ �� 30�� ���� �����Դϴ�."));
        CoupleImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "�� ���� ��� ��, �� ����� ��ȭ���� ū ������ �������ٰ� �� ������� �̸������� ��Ÿ���� ���� ���ҽ��ϴ�."));
        yield return StartCoroutine(NormalChat("�����̼�", "���� ���� ���߰� ��踦 �ѵ� �պ�� ���տ��� ���߽��ϴ�."));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("��ȭ", "����, ��Ź�帱 ������ �ֽ��ϴ�. �� ���� ū ���� ���� ���� ��ڽ��ϱ�?"));
        PrincessImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("����", "���� �����ϼ�, �׷��� �ϵ��� ����"));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("�����̼�", "������ ������縦 ã�ư� ���� �޿� ����� �������ϴ�."));
        yield return StartCoroutine(NormalChat("�����̼�", "����� �ŷ��� ���� ��� ���� �޿�� ������ ��������ϴ�."));
        yield return StartCoroutine(NormalChat("�����̼�", "�װ��� �̸����(گ��߲��)�� ȸ��(����), ž(��), ����(��)�� ����� ���� �� ���� ����� ��ȣ�� �̸���(گ����)�� �ϴ� ���ݱ��� �� ���� �������� �ֽ��ϴ�."));
        yield return StartCoroutine(NormalChat("�����̼�", "<�ﱹ����> ������ �̾߱� ��"));
        yield return StartCoroutine(NormalChat("", "Skip ��ư�� ���� ȭ���� �����ּ���"));
    }
}