using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    
    public List<Word> words;

    public WordManager wordManager;
    
    public WordSpawner wordspawner;
    
    // Start is called before the first frame update
    void Start()
    {
        addWord();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addWord()
    {
        Word word = new Word(Wordgenerator.GetRandomWord(), wordspawner.Spawnword());
        Debug.Log(word.word);
        
        words.Add(word);
    }

    private void test(string input)
    {
        if (input == "test")
        {
            Debug.Log("test");
        }
    }
}
