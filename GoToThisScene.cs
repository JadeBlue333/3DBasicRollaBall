using UnityEngine;
using UnityEngine.SceneManagement;

//inspector에서 이동할 씬 이름 입력 후 Button의 onClick()에 추가
public class GoToThisScene : MonoBehaviour
{
    public string SceneName = "MainMenu";

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
