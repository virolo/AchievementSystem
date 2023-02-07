using UnityEngine;

[CreateAssetMenu(fileName = "AchievementData", menuName = "Achievements/Achievement")]
public class AchievementData : ScriptableObject
{
    [SerializeField]
    private string _tittle;

    [SerializeField]
    private string _description;

    [SerializeField]
    private Sprite _sprite;

    [SerializeField]
    private AchievementType _achievementType;

    public string Tittle => _tittle;

    public string Description => _description;

    public Sprite Sprite => _sprite;
    public AchievementType Type => _achievementType;
}