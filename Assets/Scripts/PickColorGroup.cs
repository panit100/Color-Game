using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickColorGroup : ColorGroup
{
    [SerializeField] BlockColor pickColorBlockPrefab;

    public void CreateAllPickColorBlock()
    {
        foreach(string color in Enum.GetNames(typeof(BlockColorType)))
        {
            if(color != "None")
                CreatePickColorBlock((BlockColorType)Enum.Parse(typeof(BlockColorType),color));
        }
    }

    void CreatePickColorBlock(BlockColorType color)
    {
        PickColor pickColorBlock = Instantiate(pickColorBlockPrefab,this.transform) as PickColor;
        pickColorBlock.SetBlockColor(color);
        blockColorList.Add(pickColorBlock);
    }
}
