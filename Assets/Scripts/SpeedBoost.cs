using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    // Polymorphism: Implement ตรรกะเฉพาะตัว
    public override void ApplyEffect(Player player)
    {
        // ใช้งาน Property ที่สืบทอดมา
        if (!IsEffectActive)
        {
            player.SetMoveSpeed(player.MoveSpeed * 2);
            IsEffectActive = true; // กำหนดสถานะใช้ Protected Setter
        }
    }
}
