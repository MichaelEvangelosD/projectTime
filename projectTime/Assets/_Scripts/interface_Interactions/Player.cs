using System;
using UnityEngine;

/// <summary>
/// This is a sample player class for demonstration purposes of the IInteractable interface implementation.
/// </summary>
public class Player : MonoBehaviour, I_Interactable
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Grab the I_Interactable class from the collision
        //(which now is the Enemy class because it implements the interface) ...
        I_Interactable interaction = collision.gameObject.GetComponent<I_Interactable>();

        //Check if we got something...
        if (interaction == null)
        {
            Debug.Log("interaction failed");
            return;
        }

        //Then call the attack interaction through the interface (which actually calls the collision's AttackInteraction();)
        interaction.AttackInteraction();
    }

    //Interface implementation
    public void AttackInteraction()
    {
        Debug.Log("Player attacked.");
    }

    public void StunInteraction()
    {
        Debug.Log("Player stunned.");
    }
}

