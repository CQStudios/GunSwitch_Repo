using UnityEngine;
using System.Collections;

public class TankControllerBehavior : MonoBehaviour {
    //Variables for tanks and characters that can operate on terrain 
    public float MaximumMovementFromStart, MaxClimbAngle, MinShotAngle, MaxShotAngle, CurrentShotAngle, SelectedShotPower;
    public bool LeftMotionInput, RightMotionInput, FireInput, SwapShotInput, IsTurn;
    public float MaxHP, CurHP, MaxArmor, CurArmor, MaxMagRes, CurMagRes, MaxEnergy, CurEnergy, Strength, MagicPower, HealthRegen, EnergyRegen;

    public float MDTaken, ADTaken, TDTaken;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// takes the specified amount of damage and applies it to the tank after processing resistances.
    /// stores damages taken into tank's records
    /// </summary>
    /// <param name="bullet"> the game object dealing damage to this tank</param>
    /// <param name="AD"> the amount of raw strength-based damage requested </param>
    /// <param name="MD"> the amount of raw MagicPower-based damage requested </param>
    /// <param name="TD"> the amount of True damage to deal. </param>
    /// <returns></returns>
    public float TakeDamage(GameObject bullet, float AD, float MD, float TD = 0)
    {
        //apply true damages
        CurHP -= TD;   TDTaken  += TD;
        
        //calculate strength damage with armor
        float _AD = AD * (100 / (100 + CurArmor ));
        //apply strength based damages after armor calculation.
        CurHP -= _AD; ADTaken  += _AD;

        //calculate magic damage with resist
        float _MD = MD * (100 / (100 + CurMagRes));
        //apply magic based damages after resist calculation.
        CurHP -= _MD; MDTaken  += _MD;

        return (TD+_AD+_MD);
    }

    public float GetHP()
    {
        return CurHP;
    }

    public bool IsDead()
    {
        if (CurHP <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
