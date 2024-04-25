using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LoadGameRank : MonoBehaviour
{
    // Start is called before the first frame update
    public Text BestPlayerData;

    void Awake()
    {
        LoadSavedData();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetPlayerData()
    {
        if (MainManager.BestPlayer == null && MainManager.BestScore == 0)
        {
            BestPlayerData.text = "";
        }
        else
        {
            BestPlayerData.text = $"Best Score - {MainManager.BestPlayer}: {MainManager.BestScore}";
        }

    }
    public void LoadSavedData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            MainManager.BestPlayer = data.TheBestPlayer;
            MainManager.BestScore = data.HighiestScore;
        }


    }


    [System.Serializable]
    public class SaveData
    {
        public int HighiestScore;
        public string TheBestPlayer;
    }


}
