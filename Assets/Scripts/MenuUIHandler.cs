using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;


#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] InputField PlayerNameInput;
    private LoadGameRank loadGameRank;

    void Awake()
    {
        loadGameRank = GameObject.Find("Load Game Rank").GetComponent<LoadGameRank>();
        loadGameRank.SetPlayerData();
    }
    public void StartGame()
    {

        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        PlayerDataHandle.Instance.PlayerName = PlayerNameInput.text;
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); 
#endif
    }



}
