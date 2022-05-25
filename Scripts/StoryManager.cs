using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{

    public Text ChatText; // 실제 채팅이 나오는 텍스트
    public Text CharacterName; // 캐릭터 이름이 나오는 텍스트
    public GameObject KingImage; // 왕 이미지
    public GameObject PrincessImage; // 공주 이미지
    public GameObject PondImage; // 연못 이미지
    public GameObject DragonImage; // 용 이미지
    public GameObject BabyImage; // 아기 이미지
    public GameObject MaImage; // 마 이미지
    public GameObject MarketImage; // 장터 이미지
    public GameObject GyeongjuImage; // 경주 이미지
    public GameObject TownImage; // 마을 이미지
    public GameObject GoldImage; // 금 덩어리 이미지
    public GameObject CoupleImage; // 커플 이미지
    public GameObject FieldImage; // 밭 이미지
    public GameObject ALotOfGoldImage; // 많은 금 덩어리 이미지
    public GameObject SajasaImage; // 사자사 이미지
    public GameObject JimyeongImage; // 지명법사 이미지

    public List<KeyCode> skipButton; // 대화를 빠르게 넘길 수 있는 키

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
        foreach (var element in skipButton) // 버튼 검사
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

        // 텍스트 타이핑 효과
        for (a = 0; a < narration.Length; a++)
        {
            writerText += narration[a];
            ChatText.text = writerText;
            yield return null;
        }

        //키를 다시 누를 떄 까지 무한정 대기
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
    
    // 텍스트 타이핑 제거 버전
    IEnumerator NormalChat(string narrator, string narration)
    {
        CharacterName.text = narrator;
        writerText = "";

        writerText += narration;
        ChatText.text = writerText;
        yield return null;

        //키를 다시 누를 떄 까지 무한정 대기
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
        yield return StartCoroutine(NormalChat("나레이션", "이 이야기는 고려시대 승려 일연이 작성한 <삼국유사> 2권 무왕조(武王條)에 수록된 이야기를 바탕으로 하고 있습니다."));

        PondImage.SetActive(true);
        yield return StartCoroutine(NormalChat("나레이션", "백제의 수도, 사비의 어느 남쪽 마을에 남편을 잃고 홀로 사는 한 여인이 있었습니다."));
        DragonImage.SetActive(true);
        yield return StartCoroutine(NormalChat("나레이션", "여인의 집 앞에는 연못이 하나 있었는데 커다란 용이 나타났고 여인은 용과 사랑에 빠지게 됩니다."));
        PondImage.SetActive(false);
        DragonImage.SetActive(false);
        BabyImage.SetActive(true);
        MaImage.SetActive(true);
        yield return StartCoroutine(NormalChat("나레이션", "여인은 용의 아이를 낳게 되었고, 아이는 어려서 부터 마를 캐다 팔며 살림을 도왔습니다."));
        yield return StartCoroutine(NormalChat("나레이션", "사람들은 항상 마를 캐던 그 아이를 서동(薯童)이라고 불렀습니다."));
        BabyImage.SetActive(false);
        MaImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("서동", "자 그럼, 오늘도 마를 팔러 가볼까?"));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("나레이션", "마를 팔기 위해 장터로 향한 서동은 흥미로운 이야기를 듣게 됩니다."));
        MarketImage.SetActive(true);
        yield return StartCoroutine(NormalChat("마을 사람1", "자네 그 이야기 들었나?"));
        yield return StartCoroutine(NormalChat("마을 사람2", "무슨 이야기 말인가?"));
        yield return StartCoroutine(NormalChat("마을 사람1", "동쪽의 머나먼 나라 신라의 임금님인 진평왕의 셋째 공주님이 그렇게 아름답다고 하더군!"));
        yield return StartCoroutine(NormalChat("마을 사람2", "호오, 그런 소문이 있었군 공주님의 이름이 무엇인가?"));
        yield return StartCoroutine(NormalChat("마을 사람1", "선화 공주님이라고 한다네"));
        yield return StartCoroutine(NormalChat("마을 사람2", "얼마나 아름다울지 궁금하구먼 그래"));
        MarketImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("서동", "선화 공주님이라.. 나도 궁금한걸?"));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("나레이션", "그리하여 서동은 신라의 수도 경주로 떠나게 되었습니다."));
        GyeongjuImage.SetActive(true);
        yield return StartCoroutine(NormalChat("서동", "이곳이 경주로구나!"));
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("서동", "어떻게 해야 공주를 만날 수 있을까?"));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("나레이션", "곰곰히 생각하던 때에 서동은 자신이 항상 팔던 마가 눈에 들어 왔습니다."));
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("서동", "그래 이거야!"));
        GyeongjuImage.SetActive(false);
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("나레이션", "서동은 근처 마을로 향했습니다."));
        TownImage.SetActive(true);
        yield return StartCoroutine(NormalChat("나레이션", "마을에는 많은 아이들이 즐겁게 놀고 있었습니다."));
        yield return StartCoroutine(NormalChat("아이들", "처음보는 사람이다!"));
        yield return StartCoroutine(NormalChat("나레이션", "서동은 갖고 있던 마를 꺼내며 아이들에게 말했습니다."));
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("서동", "얘들아 이거 줄테니 부탁 하나만 들어주겠니?"));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("아이들", "우와 맛있겠다! 무슨 부탁인데요?"));
        TownImage.SetActive(false);
        GyeongjuImage.SetActive(true);
        yield return StartCoroutine(NormalChat("나레이션", "그 시각 신라의 궁궐에서는..."));
        yield return StartCoroutine(NormalChat("신하", "폐하, 큰일났사옵니다!"));
        yield return StartCoroutine(NormalChat("진평왕", "무슨 일인가?"));
        yield return StartCoroutine(NormalChat("신하", "그게 그러니까..."));
        yield return StartCoroutine(NormalChat("진평왕", "뭐라고? 당장 셋째 공주를 당장 데려오너라!"));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("선화 공주", "부르셨습니까?"));
        PrincessImage.SetActive(false);
        yield return StartCoroutine(NormalChat("진평왕", "지금 궁 밖에서 이상한 노래가 떠돌고 있는데 사실이냐?"));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("선화 공주", "네? 그게 무슨.."));
        PrincessImage.SetActive(false);
        yield return StartCoroutine(NormalChat("아이들", "선화공주님은 남몰래 사귀어 서동 도련님을 밤에 몰래 안고 간다~"));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("선화 공주", "저, 저는 모르는 일입니다!"));
        PrincessImage.SetActive(false);
        yield return StartCoroutine(NormalChat("진평왕", "시끄럽다! 내 허락도 없이 임자를 만나다니... 꼴도 보기 싫으니 당장 궁에서 나가거라!"));
        GyeongjuImage.SetActive(false);
        yield return StartCoroutine(NormalChat("나레이션", "그렇게 선화 공주는 궁 밖으로 쫓겨나게 되었습니다."));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("선화 공주", "어머니.. 저는 억울합니다"));
        PrincessImage.SetActive(false);
        yield return StartCoroutine(NormalChat("왕후", "공주, 슬퍼 마시고 이것을 받으세요"));
        GoldImage.SetActive(true);
        yield return StartCoroutine(NormalChat("나레이션", "공주의 어머니는 금 한덩어리를 건네주었습니다."));
        yield return StartCoroutine(NormalChat("왕후", "분명 도움이 될겁니다."));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("선화 공주", "감사합니다..."));
        GoldImage.SetActive(false);
        PrincessImage.SetActive(false);
        yield return StartCoroutine(NormalChat("나레이션", "그렇게 공주는 귀양길에 올랐습니다. 하염없이 걷던 도중 공주 앞에 한 사내가 나타났습니다."));
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("??", "처음 뵙겠습니다. 먼 길을 떠나시는 것 같은데 함께 가도 되겠습니까?"));
        KingImage.SetActive(false);
        CoupleImage.SetActive(true);
        yield return StartCoroutine(NormalChat("나레이션", "그렇게 두 사람은 많은 얘기를 나누었고 서로 호감을 갖게 되었습니다."));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("선화 공주", "실례지만 성함이 어떻게 되시는지요?"));
        PrincessImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("서동", "저는 백제에서 온 서동이라고 합니다."));
        KingImage.SetActive(false);
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("선화 공주", "서동이라면..!"));
        PrincessImage.SetActive(false);
        yield return StartCoroutine(NormalChat("아이들", "선화공주님은 남몰래 사귀어 서동 도련님을 밤에 몰래 안고 간다~"));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("선화 공주", "당신이 사람들에게 노래를 퍼트렸군요."));
        PrincessImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("서동", "맞습니다. 공주님을 실제로 뵙고싶었습니다. 역시나 아름다우시군요."));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("나레이션", "공주는 기쁜듯이 웃으며 무언가를 결심한 듯, 금 덩어리를 꺼내들었습니다."));
        CoupleImage.SetActive(false);
        GoldImage.SetActive(true);
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("선화 공주", "저는 당신을 따라서 백제로 가겠어요. 이 금 덩어리가 도움이 될 거예요."));
        PrincessImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("서동", "이것은..!"));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("나레이션", "서동은 곰곰히 생각하더니, 공주에게 말했습니다."));
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("서동", "이런 것이라면 제가 마를 캐는 곳에 잔뜩 있습니다. 어서 가시죠!"));
        KingImage.SetActive(false);
        GoldImage.SetActive(false);
        FieldImage.SetActive(true);
        yield return StartCoroutine(NormalChat("나레이션", "두 사람은 서둘러 백제로 향했고, 서동이 항상 마를 캐는 밭에 도착했습니다."));
        FieldImage.SetActive(false);
        ALotOfGoldImage.SetActive(true);
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("선화 공주", "정말이군요..! 이렇게 많은 금 덩어리들은 처음 봐요."));
        PrincessImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("서동", "이 금 덩어리들을 신라의 임금님께 보내드리면 우리의 관계를 인정해주실 겁니다."));
        KingImage.SetActive(false);
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("선화 공주", "근데 이 많은 금 덩어리들을 어떻게 그 먼 곳까지 보내죠?"));
        PrincessImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("서동", "제가 신통력이 뛰어난 분을 알고 있습니다. 그 분이라면 가능할겁니다."));
        KingImage.SetActive(false);
        ALotOfGoldImage.SetActive(false);
        SajasaImage.SetActive(true);
        yield return StartCoroutine(NormalChat("나레이션", "두 사람은 이번엔 용화산에 있는 사자사라는 절에 도착했습니다."));
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("서동", "법사님! 계십니까?"));
        KingImage.SetActive(false);
        JimyeongImage.SetActive(true);
        yield return StartCoroutine(NormalChat("지명법사", "서동이구만, 무슨일인가?"));
        JimyeongImage.SetActive(false);
        yield return StartCoroutine(NormalChat("나레이션", "서동은 자초지종을 설명하고 금 덩어리를 옮길 방법을 물었습니다."));
        JimyeongImage.SetActive(true);
        yield return StartCoroutine(NormalChat("지명법사", "그렇다면 나한테 금 덩어리들을 가져오게"));
        JimyeongImage.SetActive(false);
        yield return StartCoroutine(NormalChat("나레이션", "이윽고, 선화 공주가 금 덩어리와 직접 쓴 편지를 가져 왔습니다."));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("선화 공주", "이 편지도 함께 보내주시겠어요?"));
        PrincessImage.SetActive(false);
        JimyeongImage.SetActive(true);
        yield return StartCoroutine(NormalChat("지명법사", "알겠네, 하룻밤 사이면 신라의 궁궐까지 도착할걸세"));
        SajasaImage.SetActive(false);
        JimyeongImage.SetActive(false);
        yield return StartCoroutine(NormalChat("나레이션", "다음날..."));
        GyeongjuImage.SetActive(true);
        yield return StartCoroutine(NormalChat("진평왕", "아니!? 이게 무슨.."));
        yield return StartCoroutine(NormalChat("나레이션", "신라의 궁궐에는 수 많은 금덩어리와 선화 공주가 보낸 편지가 함께 놓여있었습니다."));
        GyeongjuImage.SetActive(false);
        CoupleImage.SetActive(true);
        yield return StartCoroutine(NormalChat("나레이션", "진평왕은 편지를 읽고 두 사람의 사이를 인정해 주었고 훗날, 서동은 왕위에 오르게 됩니다."));
        yield return StartCoroutine(NormalChat("나레이션", "이 사람이 바로 백제의 제 30대 국왕 무왕입니다."));
        CoupleImage.SetActive(false);
        yield return StartCoroutine(NormalChat("나레이션", "그 이후 어느 날, 두 사람은 용화산의 큰 못가를 지나가다가 못 가운데에서 미륵삼존이 나타나는 것을 보았습니다."));
        yield return StartCoroutine(NormalChat("나레이션", "가던 길을 멈추고 경배를 한뒤 왕비는 무왕에게 말했습니다."));
        PrincessImage.SetActive(true);
        yield return StartCoroutine(NormalChat("선화", "폐하, 부탁드릴 말씀이 있습니다. 이 곳에 큰 절을 짓는 것이 어떻겠습니까?"));
        PrincessImage.SetActive(false);
        KingImage.SetActive(true);
        yield return StartCoroutine(NormalChat("무왕", "좋은 생각일세, 그렇게 하도록 하지"));
        KingImage.SetActive(false);
        yield return StartCoroutine(NormalChat("나레이션", "무왕은 지명법사를 찾아가 못을 메울 방법을 물었습니다."));
        yield return StartCoroutine(NormalChat("나레이션", "법사는 신력을 통해 산과 못을 메우고 평지를 만들었습니다."));
        yield return StartCoroutine(NormalChat("나레이션", "그곳에 미륵삼상(彌勒三像)과 회전(會殿), 탑(塔), 낭무(廊)를 만들어 각각 세 곳에 세우고 액호를 미륵사(彌勒寺)라 하니 지금까지 그 절이 전해지고 있습니다."));
        yield return StartCoroutine(NormalChat("나레이션", "<삼국유사> 무왕조 이야기 끝"));
        yield return StartCoroutine(NormalChat("", "Skip 버튼을 눌러 화면을 나가주세요"));
    }
}