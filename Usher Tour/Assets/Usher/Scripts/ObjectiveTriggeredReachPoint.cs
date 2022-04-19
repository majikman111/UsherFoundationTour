using UnityEngine;

[RequireComponent(typeof(DelayedObjective), typeof(Collider))]
public class ObjectiveTriggeredReachPoint : MonoBehaviour
{
    [Tooltip("Visible transform that will be destroyed once the objective is completed")]
    Transform destroyRoot;

    DelayedObjective m_Objective;

    void Awake()
    {
        m_Objective = GetComponent<DelayedObjective>();
        DebugUtility.HandleErrorIfNullGetComponent<Objective, ObjectiveReachPoint>(m_Objective, this, gameObject);

        if (destroyRoot == null)
            destroyRoot = transform;
    }

    // void OnStartTriggerEnter(Collider other)
    // {
    //     if (m_Objective.isCompleted)
    //         return;

    //     var player = other.GetComponent<PlayerCharacterController>();
    //     // test if the other collider contains a PlayerCharacterController, then complete
    //     if (player != null)
    //     {
    //         // m_Objective.CompleteObjective(string.Empty, string.Empty, "Objective complete : " + m_Objective.title);

    //         // destroy the transform, will remove the compass marker if it has one
    //         Destroy(other); 

    //         // Register ourselves with the objective manager
    //         m_Objective.Register();
    //     }
    // }

    void OnTriggerEnter(Collider other)
    {
        if (m_Objective.isCompleted)
            return;

        var player = other.GetComponent<PlayerCharacterController>();
        // test if the other collider contains a PlayerCharacterController, then complete
        if (player != null)
        {
            m_Objective.CompleteObjective(string.Empty, string.Empty, "Objective complete : " + m_Objective.title);

            // destroy the transform, will remove the compass marker if it has one
            Destroy(destroyRoot.gameObject); 
        }
    }
}
