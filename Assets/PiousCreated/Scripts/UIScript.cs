using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class UIScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject menu;
    public UIDocument mainMenu;
    public string GameSceneName;
    private Button StartButton;
    private Button QuitButton;
    private VisualElement mainMenu2;

    void OnEnable()
    {
        mainMenu = menu.GetComponent<UIDocument>();
        mainMenu2 = mainMenu.rootVisualElement;

        StartButton = mainMenu2.Q<Button>("StartButton");
        QuitButton = mainMenu2.Q<Button>("QuitButton");
        StartButton.clicked += Play;
        QuitButton.clicked += Quit;

    }
        

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene(GameSceneName);
        Debug.Log("Clicked Play");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Clicked Quit");
    }
}
