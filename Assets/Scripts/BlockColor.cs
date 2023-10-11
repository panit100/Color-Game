using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlockColor : MonoBehaviour
{
    [SerializeField] Image blockColorImage;

    [SerializeField] protected BlockColorType color;
    [SerializeField] protected AnswerType answer;

    public void SetBlockColor(BlockColorType _color)
    {
        color = _color;
        ChangeImageColor(GameManager.Instance.GetBloackColor(color));
    }

    public void SetAnswer(AnswerType _answer)
    {
        answer = _answer;
    }

    public void ChangeImageColor(Color color)
    {
        blockColorImage.color = color;
    }
}
