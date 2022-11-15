using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelCounter : MonoBehaviour
{
    [SerializeField] private Text text;

    private string level = "Уровень ";

    private void OnEnable()
    {
        var levelNumber = SceneManager.GetActiveScene().buildIndex.ToString();

        text.text = level + levelNumber;
    }
}
