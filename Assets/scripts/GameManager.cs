using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Image questionImage;
    [SerializeField] private List<Question> questions;
    [SerializeField] private InputField answerfield;
    private int goodAnswers;

    private int questionNumber;
    // Start is called before the first frame update
    void Start()
    {
        questionNumber = 0;
        questionImage.sprite = questions[questionNumber].picture;
        Debug.Log(questions[questionNumber].answer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckAnswer()
    {
        if (answerfield.text == questions[questionNumber].answer)
        {
            Debug.Log("goed zo");
        }

        else
        {
            Debug.Log("fout");
        }
        
        NextQuestion();
    }
    void NextQuestion()
    {
        questions.RemoveAt(questionNumber);
        questionNumber = Random.Range(0, questions.Count);
        questionImage.sprite = questions[questionNumber].picture;
        Debug.Log(questions[questionNumber].answer);
    }
}