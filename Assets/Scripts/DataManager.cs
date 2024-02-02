using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string userName;
    public string savePath;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        savePath = Application.persistentDataPath + "/savefile.json";
        Instance = this;
        DontDestroyOnLoad(this);
    }

    [System.Serializable]
    public class SaveData
    {
        public string userName;
        public string highestScore;
    }

    public void Save(string score)
    {
        SaveData saveData = new SaveData();
        saveData.userName = userName;
        saveData.highestScore = score;
        string json = JsonUtility.ToJson(saveData);
        File.WriteAllText(savePath, json);
    }

    public SaveData Load()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            return JsonUtility.FromJson<SaveData>(json);
        }
        return null;
    }
}