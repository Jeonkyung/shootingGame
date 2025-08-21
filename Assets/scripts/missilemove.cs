using UnityEngine;

public class missilemove : MonoBehaviour
{
    public float moveSpeed = 0.0f;
    //미사일 발사 딜레이 구현
    //01시간 써서 하시면 되요. 0.5초 마다 한 발씩 나가도록 구현
    //02 미사일 발사 갯수 5개를 만들어서 5발 다 쏘고나면 충전시간 만드세요
    // 충전 시간은 3초 주세요 3초 뒤에 5발 충전
    public float timeCheck = 0.0f; //시간 값 담을 변수
    public float timDelay = 0.0f; //딜레이 값 담을 변수
    public int missleCount = 0; //미사일 갯수 담을 변수
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime,Space.World);
    }
}
