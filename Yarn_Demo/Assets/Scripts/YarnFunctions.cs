using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnFunctions : MonoBehaviour
{
    [SerializeField] int money;
    [SerializeField] InMemoryVariableStorage storage;

    /// <summary>
    /// Sets the money value in yarn spinner to the int set as the money variable.
    /// Money can be changed in the inspector.
    /// Called via "SetMoneyToYarn YarnFunctions" in yarn spinner.
    /// </summary>
    [YarnCommand] public void SetMoneyToYarn()
    {
        storage.SetValue("$money", money);
    }

    /// <summary>
    /// Sets the money variable in this script to the value in yarn spinner.
    /// Called via "SetMoneyFromYarn YarnFunctions" in yarn spinner.
    /// </summary>
    [YarnCommand] public void SetMoneyFromYarn()
    {
        float currentMoney;
        storage.TryGetValue("$money", out currentMoney);
        money = (int) currentMoney;
    }

    /// <summary>
    /// Retrieves the value of a variable in yarn spinner (used for demonstration purposes). 
    /// Currently just prints to the consolde. Can be changed to return or set the value retrieved as a C# variable.
    /// Called via "GetVariable YarnFunctions {$variable}" in yarn spinner.
    /// </summary>
    [YarnCommand] public void GetVariable(int num)
    {
        Debug.Log(num);
    }
}
