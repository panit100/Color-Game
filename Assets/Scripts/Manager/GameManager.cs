using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockColorType
{
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
    ColorAndPlaceCorrect,
    ColorCorrect,
    Wrong,
    None,
}



public class GameManager : MonoBehaviour
{
    [SerializeField] ColorGroup QuestionColorGroup; 
    [SerializeField] List<ColorGroup> ColorColorGroupList = new List<ColorGroup>();
    [SerializeField] List<ColorGroup> PickColorList = new List<ColorGroup>();

    void RandomColor()
    {

    }
}