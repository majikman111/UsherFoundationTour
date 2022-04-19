using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Objective))]
public class DelayedObjective : Objective
{
    // Start is called before the first frame update
    public void Start()
    {
        return;
    }

    public void Register(){
        // base.Start();
        // add this objective to the list contained in the objective manager
        ObjectiveManager objectiveManager = FindObjectOfType<ObjectiveManager>();
        DebugUtility.HandleErrorIfNullFindObject<ObjectiveManager, Objective>(objectiveManager, this);
        objectiveManager.RegisterObjective(this);

        // register this objective in the ObjectiveHUDManger
        m_ObjectiveHUDManger = FindObjectOfType<ObjectiveHUDManger>();
        DebugUtility.HandleErrorIfNullFindObject<ObjectiveHUDManger, Objective>(m_ObjectiveHUDManger, this);
        m_ObjectiveHUDManger.RegisterObjective(this);

        // register this objective in the NotificationHUDManager
        m_NotificationHUDManager = FindObjectOfType<NotificationHUDManager>();
        DebugUtility.HandleErrorIfNullFindObject<NotificationHUDManager, Objective>(m_NotificationHUDManager, this);
        m_NotificationHUDManager.RegisterObjective(this);
    }
}
