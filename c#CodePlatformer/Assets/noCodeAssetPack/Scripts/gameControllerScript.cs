using System;
using UnityEngine;

public class gameControllerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject gemPrefab;
    [SerializeField]
    private GameObject[] gemLoc;

    private GameObject[] gems;
    public static int winCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        gems = new GameObject[gemLoc.Length];
        for(int i = 0; i < gems.Length; i++)
        {
            gems[i] = Instantiate(gemPrefab, gemLoc[i].transform.position, gemLoc[i].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(winCounter);
        if (winCounter >= gemLoc.Length) Debug.Log("Win!");
    }
}
