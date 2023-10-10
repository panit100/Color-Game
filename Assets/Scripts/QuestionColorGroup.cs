using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionColorGroup : ColorGroup
{
    [SerializeField] BlockColor questionBlockPrefab;

    public void CreateQuestionBlock()
    {
        for(var i = 0; i < 4; i++)
        {
            BlockColor questionBlock = Instantiate(questionBlockPrefab,this.transform);
            blockColorList.Add(questionBlock);
        }
    }

    void RandomQuestion()
    {

    }

    void SetQuestion()
    {
        
    }
}
