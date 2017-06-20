using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class scr_RoomParser : MonoBehaviour {

    enum ObjectIDs
    {
        AIR,
        WALL,
        SPIKES,
        KEY,
        DOOR,
        PATROLENEMY,
        RANGEDENEMY
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Parse(string path)
    {
        FileStream fs = new FileStream(path, FileMode.Open);
        StreamReader reader = new StreamReader(fs);
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            var ids = line.Split(' ');
            foreach (var idStr in ids)
            {
                ObjectIDs id = (ObjectIDs)(int.Parse(idStr));
                switch (id)
                {
                    case ObjectIDs.AIR:
                        break;
                    case ObjectIDs.WALL:
                        break;
                    case ObjectIDs.SPIKES:
                        break;
                    case ObjectIDs.KEY:
                        break;
                    case ObjectIDs.DOOR:
                        break;
                    case ObjectIDs.PATROLENEMY:
                        break;
                    case ObjectIDs.RANGEDENEMY:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
