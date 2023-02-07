using System.Threading.Tasks;
using UnityEngine;
using Xenxei.AchievementSystem;

public class GameManager : MonoBehaviour
{
    private int _counter;
    
    private AchievementTrigger _counterTrigger;

    private void Awake()
    {
        _counter = 0;
    }

    private void Start()
    {
        _counterTrigger = new AchievementTrigger(AchievementType.Counter);
        IncrementCounter();
    }
    
    private async void IncrementCounter()
    {
        _counter++;
        Debug.Log($"Counter incremented to {_counter}");
        
        if (_counter >= 5)
        {
            _counterTrigger.Trigger();
        }

        await Task.Delay(1000);

        if (_counter == 10)
        {
            return;
        }
        
        IncrementCounter();
    }
}