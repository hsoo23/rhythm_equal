using UnityEngine;

public class LifeCycle : MonoBehaviour{
  void Update()
  {
    if(Input.anyKeyDown)
      Debug.Log(" 키를 눌렀습니다");
    if (Input.GetMouseButtonDown(0))
      Debug.Log(" 미사일 발사");
    if (Input.GetMouseBotton(0))
      Debug.Log(" 미사일 모으는 중");
    if (Input.GetMouseButtonUp(0))
      Debug.Log("슈퍼 미사일 발사");
  }
}
