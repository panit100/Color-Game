using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum BlockColorType
{
    None,
    Black,
    Yellow,
    Blue,
    Orange,
    Magenta,
    Pink,
}

public enum BlockType
{
    ColorBlock,
    AnswerBlock,
}

public enum AnswerType
{
    None,
    ColorAndPlaceCorrect,
    ColorCorrect,
    Wrong,
}



public class GameManager : MonoBehaviour
{
    [SerializeField] QuestionColorGroup questionColorGroup; 
    [SerializeField] GuessColorGroup guessColorGroup;
    [SerializeField] PickColorGroup pickColorGroup;

    void Start() 
    {
        Init();
    }

    void Init()
    {
        questionColorGroup.CreateQuestionBlock();
        pickColorGroup.CreateAllPickColorBlock();

        guessColorGroup.CreateAllColorGroup();
    }

    Color GetBloackColor(BlockColorType _color)
    {
        switch(_color)
        {
            case BlockColorType.None:
                return Color.white;
            case BlockColorType.Black:
                return Color.black;
            case BlockColorType.Yellow:
                return Color.yellow;
            case BlockColorType.Blue:
                return Color.blue;
            case BlockColorType.Orange:
                return new Color(0,0,0);
            case BlockColorType.Magenta:
                return Color.magenta;
            case BlockColorType.Pink:
                return new Color(0,0,0);
            default:
                return Color.white;
        }
    }   

    Color GetAnswerColor(AnswerType answer)
    {
        switch(answer)
        {
            case AnswerType.None:
                return Color.white;
            case AnswerType.ColorAndPlaceCorrect:
                return Color.black;
            case AnswerType.ColorCorrect:
                return Color.yellow;
            case AnswerType.Wrong:
                return Color.blue;
            default:
                return Color.white;
        }
    }
}