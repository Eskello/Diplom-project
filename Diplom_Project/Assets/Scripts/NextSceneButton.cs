using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneButton : MonoBehaviour
{
    public void OnButtonClick()
    {
        var nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        var sceneCount = SceneManager.sceneCount;

        if (nextSceneIndex >= sceneCount)
        {
            SceneManager.LoadScene(nextSceneIndex - 1);
        }
        else
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
