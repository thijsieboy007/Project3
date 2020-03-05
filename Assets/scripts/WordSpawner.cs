using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{

    public GameObject wordPrefab;
    public Transform wordCanvas;
    
    public WordDisplay Spawnword()
    {
        GameObject WordObj = Instantiate(wordPrefab, wordCanvas);
        WordDisplay wordDisplay = WordObj.GetComponent<WordDisplay>();
            
        return wordDisplay;
    }
    
}


