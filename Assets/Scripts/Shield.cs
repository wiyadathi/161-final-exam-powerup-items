using UnityEngine;

public class Shield : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        // ใช้งาน Property ที่สืบทอดมา
        if (!IsEffectActive)
        {
            player.SetInvulnerability(true);
            IsEffectActive = true; // กำหนดสถานะใช้ Protected Setter
        }
    }
}
