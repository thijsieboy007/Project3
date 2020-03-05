using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wordgenerator : MonoBehaviour
{

    private static string[] wordlist =
    {
        "hee",
        "hee2",
        "hee3",
        "hee4",
        "hee5",
        "hee6",
        "hee7",
        "hee8",
        "hee9",
        "hee10"
    };
    
    
    public static string GetRandomWord()
    {
        int randmonIndex = Random.Range(0, wordlist.Length);
        string randmonWord = wordlist[randmonIndex];
        
        return randmonWord;
    }
}
