using UnityEngine;

public class AchievementTrigger
{
    private readonly AchievementType _achievementType;

    public AchievementTrigger(AchievementType achievementType)
    {
        _achievementType = achievementType;
        AddListeners();
    }

    private void AchievementTriggered(AchievementData achievementData)
    {
        if (IsThisAchievement(achievementData))
        {
            return;
        }

        RemoveListeners();
        Debug.Log($"Triggered achievement {achievementData.Tittle}");
    }

    private void AddListeners()
    {
        AchievementManager.Instance.OnAchievementTriggered += AchievementTriggered;
    }

    private void RemoveListeners()
    {
        AchievementManager.Instance.OnAchievementTriggered -= AchievementTriggered;
    }

    private bool IsThisAchievement(AchievementData achievementData)
    {
        return achievementData.Type != _achievementType;
    }

    public void Trigger()
    {
        AchievementManager.Instance.TriggerAchievement(_achievementType);
    }
}