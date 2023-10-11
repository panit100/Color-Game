using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CuteEngine.Utilities;

public enum BlockColorType
{
    None,
    Black,
    Yellow,
    Blue,
    Orange,
    Magenta,
    Green,
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



public class GameManager : Singleton<GameManager>
{
    [SerializeField] QuestionColorGroup questionColorGroup; 
    [SerializeField] GuessColorGroup guessColorGroup;
    [SerializeField] PickColorGroup pickColorGroup;

    [SerializeField] BlockColorType pickingColor = BlockColorType.None;

    protected override void InitAfterAwake()
    {
        
    }

    void Start() 
    {
        Init();
    }

    void Init()
    {
        questionColorGroup.CreateQuestionBlock();
        pickColorGroup.CreateAllPickColorBlock();

        guessColorGroup.CreateGuessColorGroup();
    }

    public Color GetBloackColor(BlockColorType _color)
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
                return new Color(1,0.5f,0);
            case BlockColorType.Magenta:
                return Color.magenta;
            case BlockColorType.Green:
                return Color.green;
            default:
                return Color.white;
        }
    }   

    public Color GetAnswerColor(AnswerType answer)
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

    public void SetPickingColor(BlockColorType color)
    {
        pickingColor = color;
    }

    public Color GetPickingColor()
    {
        return GetBloackColor(pickingColor);
    }
}