using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

        
        StartCoroutine(ToogleIgnoreLayout(true));
    }

    void CreatePickColorBlock(BlockColorType color)
    {
        PickColor pickColorBlock = Instantiate(pickColorBlockPrefab,this.transform) as PickColor;
        pickColorBlock.SetBlockColor(color);
        blockColorList.Add(pickColorBlock);
    }

    IEnumerator ToogleIgnoreLayout(bool toggle)
    {
        yield return new WaitForEndOfFrame();

        foreach(var n in blockColorList)
        {
            n.GetComponent<LayoutElement>().ignoreLayout = toggle;
        }
    }
}
