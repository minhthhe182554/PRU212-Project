using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void GoToSettingScene()
    {
        SceneManager.LoadScene(SceneNames.SETTING_SCENE);
    }

    public void GoToSelectPlayerScene()
    {
        SceneManager.LoadScene(SceneNames.SELECT_PLAYER);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(SceneNames.MAIN_MENU);
    }
}
