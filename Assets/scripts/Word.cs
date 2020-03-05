using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    
    private int typeIndex;

    WordDisplay Display;
    
    public Word (string _word, WordDisplay _Display)
    {
        word = _word;
        typeIndex = 0;

        Display = _Display;
        Display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        Display.RemoveLetter();
        
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            Display.RemoveWord();
        }

        return wordTyped;
    }
}
