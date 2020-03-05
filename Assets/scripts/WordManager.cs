using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordManager : MonoBehaviour
{
    public List<Word> words;

    public List<Sprite> hand;

    public WordSpawner wordspawner;

    private bool hasActiveWord;
    
    public Word activeWord;
    
    private void Start()
    {
        addWord();
    }

    public void addWord()
    {
        Word word = new Word(Wordgenerator.GetRandomWord(), wordspawner.Spawnword());
        Debug.Log(word.word);
        
        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
    
}
