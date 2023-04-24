using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    int[] map;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello world");
        string debugText = "";
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0 };
        {
            for (int i = 0; i < map.Length; i++)
            {
                debugText += map[i].ToString() + ",";
                Debug.Log(map[i]+",");
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            int playerInbox = -1;
            for(int i = 0; i < map.Length;i++)
            {
                if (map[i] == 1) 
                {
                    playerInbox = i;
                    break;

                }
            }
            if (playerInbox <map.Length - 1)
            {
                map[playerInbox + 1] = 1;
                map[playerInbox] = 0;

            }
            string debugText = "";
            for (int i = 0;i < map.Length;i++)
            {
                debugText += map[i].ToString() + ",";
            }
            Debug.Log(debugText);
        }
    }
}
