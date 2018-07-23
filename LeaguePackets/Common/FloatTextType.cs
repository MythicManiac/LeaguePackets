﻿using System;
namespace LeaguePackets.Common
{
    public enum FloatTextType
    {
        Invulnerable = 0x0,
        Special = 0x1,
        Heal = 0x2,
        ManaHeal = 0x3,
        ManaDamage = 0x4,
        Dodge = 0x5,
        PhysicalDamageCritical = 0x6,
        MagicalDamageCritical = 0x7,
        TrueDamageCritical = 0x8,
        Experience = 0x9,
        Gold = 0xA,
        Level = 0xB,
        Disable = 0xC,
        QuestReceived = 0xD,
        QuestComplete = 0xE,
        Score = 0xF,
        PhysicalDamage = 0x10,
        MagicalDamage = 0x11,
        TrueDamage = 0x12,
        EnemyPhysicalDamage = 0x13,
        EnemyMagicalDamage = 0x14,
        EnemyTrueDamage = 0x15,
        EnemyPhysicalDamageCritical = 0x16,
        EnemyMagicalDamageCritical = 0x17,
        EnemyTrueDamageCritical = 0x18,
        Countdown = 0x19,
        OnMyWay = 0x1A,
        Absorbed = 0x1B,
        Debug = 0x1C,
    }
}
