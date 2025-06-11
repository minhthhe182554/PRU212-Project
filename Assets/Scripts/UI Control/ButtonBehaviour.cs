using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void GoToSettingScene()
    {
        SceneManager.LoadScene(SceneNames.SETTING_SCENE);
    }
}
