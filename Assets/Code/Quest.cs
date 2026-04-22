using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Quest")]
public class Quest : ScriptableObject
{
    public string questID;
    public string questName;
    public string description;
    public List<QuestObjective> objectives;

//called when scriptable obj is created 
    private void OnValidate()
    {
        if(string.IsNullOrEmpty(questID))
        {
            questID = questName + Guid.NewGuid().ToString();
            
        }
    }

    [System.Serializable]
    public class QuestObjective
    {
        public string objectiveID; //Note to self match with the item ID  you need to collect
        public string description;
        public ObjectiveType type;
        public int requiredAmount;
        public int currentAmount;

        public bool IsComlpeted => currentAmount >= requiredAmount;
    }

    public enum ObjectiveType { CollectItem, ReachLocation, TalkNPC}
}

    [System.Serializable]
    public class QuestObjective
    {
        public string objectiveID; //Note to self match with the item ID  you need to collect
        public string description;
        public ObjectiveType type;
        public int requiredAmount;
        public int currentAmount;

        public bool IsComlpeted => currentAmount >= requiredAmount;
    }

    public enum ObjectiveType { CollectItem, ReachLocation, TalkNPC}

    [System.Serializable]
    public class QuestProgress

    {
        public Quest quest;
        public List<QuestObjective> objectives;

        public QuestProgress(Quest quest)
        {
            this.quest = quest;
            objectives = new List<QuestObjective>();

            //Deep copy to avoid modifying the og
            foreach(var obj in objectives)
            {
                objectives.Add(new QuestObjective
                {
                    objectiveID = obj.objectiveID,
                    description = obj.description,
                    type = obj.type,
                    requiredAmount = obj.requiredAmount,
                    currentAmount = 0
                });
            }
        }
        public bool IsComlpeted => objectives.TrueForAll(o => o.IsComlpeted);
        public string QuestID => quest.questID;
    }