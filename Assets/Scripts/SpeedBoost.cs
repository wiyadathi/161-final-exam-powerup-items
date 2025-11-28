using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    private float newSpeed = 10f;

    // Polymorphism: Implement ตรรกะเฉพาะตัว
    public override void ApplyEffect(Player player)
    {
        // ใช้งาน Property ที่สืบทอดมา
        if (!IsEffectActive)
        {
            player.SetMoveSpeed(newSpeed);
            IsEffectActive = true; // กำหนดสถานะใช้ Protected Setter
        }
    }
}
