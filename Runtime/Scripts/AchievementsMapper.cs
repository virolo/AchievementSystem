using System.Collections.Generic;

namespace Xenxei.AchievementSystem
{
    internal class AchievementsMapper
    {
        private Dictionary<AchievementType, AchievementData> _achievementTypeToData;
    
        public AchievementsMapper(AchievementCollection collection)
        {
            Populate(collection.DataAchievements);
        }

        private void Populate(List<AchievementData> dataAchievements)
        {
            _achievementTypeToData = new Dictionary<AchievementType, AchievementData>();
        
            foreach (AchievementData collectionAchievement in dataAchievements)
            {
                _achievementTypeToData.Add(collectionAchievement.Type, collectionAchievement);
            }
        }

        public AchievementData GetAchievement(AchievementType type)
        {
            return _achievementTypeToData[type];
        }
    }
}