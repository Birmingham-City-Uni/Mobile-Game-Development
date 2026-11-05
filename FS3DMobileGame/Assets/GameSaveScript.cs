using System;
using System.IO;
using Unity.Android.Gradle.Manifest;
using UnityEditor.SceneManagement;
using UnityEngine;
using static UnityEngine.Rendering.ReloadAttribute;

public class GameSaveScript : MonoBehaviour
{
    public static GameSaveScript First;
    
    [Serializable]
    public class saveData
    {
        public long saveCounter;
        public string saveID;


        public int highscore;


        public float playtimeSeconds;

        public saveData()
        {
            this.saveCounter = 0;
            this.saveID = null;
            this.highscore = 0;
            this.playtimeSeconds = 0;
        }
    }
    public saveData currentData;

    string json;
    public string filePath;

    public void Start()
    {
        if (First != null)
        {
            Destroy(this.gameObject);
            return;
        
        }
        First = this;
        DontDestroyOnLoad(this.gameObject);
        
    }

    public void SaveGame(saveData data)
    {
        string jsonString = JsonUtility.ToJson(data);
        data.saveCounter++;
        // data.saveID = 
        File.WriteAllText(filePath, jsonString );
        

        /*PlayerPrefs.SetString("GameSave", jsonString);
        PlayerPrefs.Save();*/
        Debug.Log(jsonString);
    }
    public saveData LoadGame()
    {
        if (PlayerPrefs.HasKey("GameSave")) 
        {
            string jsonString = File.ReadAllText(filePath);
            saveData data = JsonUtility.FromJson<saveData>(jsonString);
            return data;
        }
        return new saveData();


    }



    private void Update()
    {
        
    }



    void Awake()
    {
        filePath = UnityEngine.Application.persistentDataPath + "/playerdata.json";
            
        currentData = LoadGame();


    }
    void Paused()
    {

       SaveGame(currentData);




    }
    private void OnApplicationFocus(bool focus)
    {
        SaveGame(currentData);
    }
    private void OnApplicationPause(bool pause)
    {
        SaveGame(currentData);
    }
}
