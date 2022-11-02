using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Linq;

public class GameEnd : MonoBehaviour
{
    public GameObject player;
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public CanvasGroup victory;
    public Timer stopWatch;
    bool playerAtEnd = false;
    float timer; 
    string first;
    string second;
    string third;


    // Update is called once per frame
    void Update()
    {
        if(playerAtEnd)
        {
            timer += Time.deltaTime;

        victory.alpha = timer / fadeDuration;

        if(timer > fadeDuration + displayImageDuration)
        {
            WriteString();
            SceneManager.LoadScene("MainMenu");
        }
        }
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject == player){
            playerAtEnd = true;
        }
    }

    void Read()
    {
        string path = "Assets/Leaderboard/leaderboard.txt";
        StreamReader reader = new StreamReader(path);
        first = reader.ReadLine();
        
        second = reader.ReadLine();
        
        third = reader.ReadLine();
        
        reader.Close();
    }

    public void WriteString()
   {
        Read();
         string path = "Assets/Leaderboard/leaderboard.txt";
        StreamWriter writer = new StreamWriter(path, false);
        string current = stopWatch.GetCurrentTime().ToString("0.00");
       
        if(first == null)
        {
            first = current;
        }else if(second == null)
        {
            second = current;
        }else if(third == null)
        {
            third = current;
        }else{
            if(float.Parse(current)<float.Parse(first))
            {
                third = second;
                second = first;
                first = current;
            }else if(float.Parse(current)<float.Parse(second))
            {
                third = second;
                second = current;
            }else if(float.Parse(current)<float.Parse(third))
            {
                third = current;
            }
        }

    Debug.Log(first);
    Debug.Log(second);
    Debug.Log(third);
        writer.WriteLine(first);
        writer.WriteLine(second);
        writer.WriteLine(third);
        writer.Close();
    
    }

}
