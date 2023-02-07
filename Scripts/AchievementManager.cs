using System;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public event Action<AchievementData> OnAchievementTriggered;
    
    [SerializeField]
    private AchievementCollection _achievementCollection;

    private AchievementsMapper _achievementsMapper;
    
    public static AchievementManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        _achievementsMapper = new AchievementsMapper(_achievementCollection);
    }

    public void TriggerAchievement(AchievementType achievementType)
    {
        AchievementData achievementData = _achievementsMapper.GetAchievement(achievementType);
        OnAchievementTriggered?.Invoke(achievementData);
    }
}