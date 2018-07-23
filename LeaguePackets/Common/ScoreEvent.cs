﻿using System;
namespace LeaguePackets.Common
{
    public enum ScoreEvent : byte
    {
        ChampKill = 0x0,
        ChampAssist = 0x1,
        NodeCapture = 0x2,
        NodeNeutralize = 0x3,
        NodeKillOffense = 0x4,
        TeamObjective = 0x5,
        DefendPointNeutralize = 0x6,
        NodeKillDefense = 0x7,
        NodeTimeDefense = 0x8,
        LastStand = 0x9,
        DefensiveAssist = 0xa,
        DefensiveKill = 0xb,
        OffensiveAssist = 0xc,
        OffensiveKill = 0xd,
        ChampionKill = 0xe,
        ChampionAssist = 0xf,
        Ace = 0x10,
        QuestComplete = 0x11,
        Sentinel = 0x12,
        Duelist = 0x13,
        Guardian = 0x14,
        DoubleKill = 0x15,
        TripleKill = 0x16,
        QuadraKill = 0x17,
        PentaKill = 0x18,
        KillingSpree = 0x19,
        Rampage = 0x1a,
        Unstoppable = 0x1b,
        Dominating = 0x1c,
        GodLike = 0x1d,
        Legendary = 0x1e,
        MinionKill = 0x1f,
        SuperMinionKill = 0x20,
        Avenger = 0x21,
        BountyHunter2 = 0x22,
        BountyHunter3 = 0x23,
        BountyHunter4 = 0x24,
        BountyHunter5 = 0x25,
        BountyHunter6 = 0x26,
        BountyHunter7 = 0x27,
        BountyHunter8 = 0x28,
        Payback = 0x29,
        Angel = 0x2a,
        ArchAngel = 0x2b,
        ScavengerHunt = 0x2c,
        ZoneCapture = 0x2d,
        ZoneNeutralize = 0x2e,
        Survivor = 0x2f,
        Defender = 0x30,
        Counter = 0x31,
        Opportunist = 0x32,
        Strategist = 0x33,
        FirstBlood = 0x34,
        Vanguard = 0x35,
        MajorRelicPickup = 0x36,
        NodeCaptureAssist = 0x37,
        NodeNeutralizeAssist = 0x38,
        Reconnect = 0x39,
    }
}
