using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(AchievementCollection), menuName = "Achievements/Collection")]
public class AchievementCollection : ScriptableObject
{
    [SerializeField]
    private List<AchievementData> _dataAchievements;

    public List<AchievementData> DataAchievements => _dataAchievements;
}