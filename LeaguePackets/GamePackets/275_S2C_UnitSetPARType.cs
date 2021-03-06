﻿using LeaguePackets.Common;
using LeaguePackets.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LeaguePackets.GamePackets
{
    public class S2C_UnitSetPARType : GamePacket // 0x113
    {
        public override GamePacketID ID => GamePacketID.S2C_UnitSetPARType;
        public PARType PARType { get; set; }
        public static S2C_UnitSetPARType CreateBody(PacketReader reader, NetID sender)
        {
            var result = new S2C_UnitSetPARType();
            result.SenderNetID = sender;
            result.PARType = reader.ReadPARType();
        
            return result;
        }
        public override void WriteBody(PacketWriter writer)
        {
            writer.WritePARType(PARType);
        }
    }
}
