using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour
{
  public static QuestController Instance { get; private set; }
  public List<QuestProgress> activeQuests = new();
  private QuestUI questUI;

  private void Awake()
  {
    if(Instance == null) Instance = this;
    else Destroy(gameObject);

    questUI = FindObjectOfType<QuestUI>();
  }

  public void AcceptQuest(Quest quest)
  {
    if( IsQuestActive(quest.questID)) return;
    
    activateQuests.Add();

    questUI.UpdateQuestUI();
  }

  public bool IsQuestActive(string questID) => activateQuests.Exists(q => q.questID == questID);
}
