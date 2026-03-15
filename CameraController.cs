using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    //PlayerController.cs 참조용
    public PlayerController p;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {  
        //해당 부분에서 if 조건문으로 게임 진행 중인지 아닌지 확인.
        //그렇지 않으면 player가 사라져 없는 오브젝트를 참조하려는 오류가 발생.
        if (p.onGame) transform.position = player.transform.position + offset;
    }
}
