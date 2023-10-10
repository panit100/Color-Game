using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlockColor : MonoBehaviour
{
    [SerializeField] BlockColorType color;
    [SerializeField] AnswerType answer;

    public void SetBlockColor(BlockColorType _color)
    {
        color = _color;
    }

    public void SetAnswer(AnswerType _answer)
    {
        answer = _answer;
    }
}
