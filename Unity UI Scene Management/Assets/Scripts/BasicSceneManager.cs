using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BasicSceneManager : MonoBehaviour
{
    public Button scene2Button;
    public Button scene3Button;
    public Button scene4Button;
    public Button backToMainSceneButton;

    public string scene2Name;
    public string scene3Name;
    public string scene4Name;
    public string sceneMainName;


    private void Start()
    {
        if (scene2Button != null) scene2Button.onClick.AddListener(() => ChangeScene(scene2Name));
        if (scene3Button != null) scene3Button.onClick.AddListener(() => ChangeScene(scene3Name));
        if (scene4Button != null) scene4Button.onClick.AddListener(()=>ChangeScene(scene4Name));
        if (backToMainSceneButton != null) backToMainSceneButton.onClick.AddListener(() => ChangeScene(sceneMainName));
    }

    private void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
