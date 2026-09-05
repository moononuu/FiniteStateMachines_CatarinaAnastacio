using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public sealed class GameEnvironment : MonoBehaviour
{

    private static GameEnvironment instance;
    private List<GameObject> checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints { get { return checkpoints; } }

    public static GameEnvironment Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameEnvironment();
                instance.Checkpoints.AddRange(GameObject.FindGameObjectsWithTag("Checkpoint"));

            }
            return instance;
        }
    }

}