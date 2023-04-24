using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    int[] map;
    void PrintArray()
    {
        string debugText = "";
        for (int i = 0; i < map.Length; i++)
        {
            debugText += map[i].ToString() + ",";
        }
        Debug.Log(debugText);
    }
    int GetPlayerIndex()
    {
        for (int i = 0; i < map.Length; i++)
        {
            if (map[i] == 1)
            {
                return i;
            }
            return -1;
        }
    }
    bool MoveNumber (int number,int moveFrom,int moveTo) 
    {
        if (moveTo < 0 || moveTo >= map.Length) { return false; }

        if (map[moveTo] == 2)
        {
            int velovity = moveTo - moveFrom;
            bool succsess = MoveNumber(2, moveTo, moveTo + velovity); 
            if(!succsess) { return false; }
        }
        
        map[moveTo] = number;
        map[moveFrom] = 0;
        return true;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello world");
        string debugText = "";
        map = new int[] { 0, 0, 0, 1, 0, 2, 0, 0, 0 };
        PrintArray();
      
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyUp(KeyCode.RightArrow)) 
        {
            int PlayerIndex = GetPlayerIndex();
            if(PlayerIndex < map.Length-1)
            {
                map[PlayerIndex +1] = 1;
                map[PlayerIndex] = 0;
            }
            PrintArray();
        }
       if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            int PlayerIndex = GetPlayerIndex();
            MoveNumber(1,PlayerIndex,PlayerIndex+1);
            PrintArray();

        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            int PlayerIndex = GetPlayerIndex();
            if (PlayerIndex < map.Length + 1)
            {
                map[PlayerIndex - 1] = 1;
                map[PlayerIndex] = 0;
            }
            PrintArray();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            int PlayerIndex = GetPlayerIndex();
            MoveNumber(1, PlayerIndex, PlayerIndex + 1);
            PrintArray();

        }
    }
