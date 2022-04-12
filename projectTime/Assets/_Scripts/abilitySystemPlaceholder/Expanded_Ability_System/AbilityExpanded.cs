using UnityEngine;

public enum AbilityTier
{
    Tier_1 = 0,
    Tier_2 = 1,
    Tier_3 = 2,
}

[CreateAssetMenu(fileName = "Expanded Ability", menuName = "Abilities/Expanded Ability", order = 2)]
public class AbilityExpanded : Ability
{
    [SerializeField] AbilityTier abilityTier;

    /// <summary>
    /// Grab the ability tier and do X things with it.
    /// </summary>
    public void GetAbilityTier()
    {
        return;
    }
}
