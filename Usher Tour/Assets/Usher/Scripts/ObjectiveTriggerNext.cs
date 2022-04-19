using UnityEngine;

[RequireComponent(typeof(Objective))]
public class ObjectiveTriggerNext : MonoBehaviour
{
    [Tooltip("Next objective to trigger")]
    public string nextObjective;   

    void OnDestroy(){
        DelayedObjective obj = GameObject.Find(nextObjective).GetComponent(typeof(DelayedObjective)) as DelayedObjective;
        obj.Register();
    }

}
