using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuUI : MonoBehaviour
{
    private Button startButton;

    void OnEnable()
    {
        var uiDocument = GetComponent<UIDocument>();

        var root = uiDocument.rootVisualElement;

        startButton = root.Q<Button>("StartButton");

        if(startButton != null)
        {
            startButton.clicked += OnStartButtonClicked;
        }
        else
        {
            Debug.LogWarning("StartButton not found.");
        }
    }

    private void OnStartButtonClicked()
    {
        Debug.Log("Button Clicked.");
    }
}
