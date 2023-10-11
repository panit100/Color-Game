using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GuessColorGroup : MonoBehaviour
{
    [SerializeField] int guessCount = 15;
    [SerializeField] ColorGroup colorGroupPrefab;
    [SerializeField] Transform colorGroupParent;
    [SerializeField] List<ColorGroup> colorGroupList = new List<ColorGroup>();

    public void CreateAllColorGroup()
    {
        for(int i = 0; i < guessCount; i++)
        {
            CreateGuessColorGroup();
        }
    }

    public void CreateGuessColorGroup()
    {
        ColorGroup newColorGroup = Instantiate(colorGroupPrefab,colorGroupParent);
        colorGroupList.Add(newColorGroup);
    }
}
