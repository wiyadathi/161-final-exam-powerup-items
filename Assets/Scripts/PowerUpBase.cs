using UnityEngine;

// Abstract Class: กำหนด Contract พื้นฐานและสถานะร่วม
public abstract class PowerUpBase : MonoBehaviour
{
    // Shared Property (Inheritance):
    // Public Getter - เปิดให้อ่านจากภายนอก
    // Protected Setter - อนุญาตให้คลาสลูกเท่านั้นที่สามารถกำหนดค่าได้
    public bool IsEffectActive { get; protected set; } = false;
    
    // Abstract Method: บังคับให้ Subclass ต้อง Implement
    public abstract void ApplyEffect(Player player);
}
