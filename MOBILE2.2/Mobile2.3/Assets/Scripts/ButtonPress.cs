using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour
{
    //public void LoadLevel(string level1)
    //{
    //    SceneManager.LoadScene(level1);
    //}
    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}


    public void PlayGame()
    {
        SceneManager.LoadScene("level1");
    }

}
