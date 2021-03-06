﻿using LeaguePackets.Common;
using LeaguePackets.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LeaguePackets.GamePackets
{
    public class WaypointListHeroWithSpeed : GamePacket // 0x83
    {
        public override GamePacketID ID => GamePacketID.WaypointListHeroWithSpeed;
        public int SyncID { get; set; }
        public WaypointSpeedParams WaypointSpeedParams { get; set; }
        public List<Vector2> Waypoints { get; set; } = new List<Vector2>();

        public static WaypointListHeroWithSpeed CreateBody(PacketReader reader, NetID sender)
        {
            var result = new WaypointListHeroWithSpeed();
            result.SenderNetID = sender;
            result.SyncID = reader.ReadInt32();
            result.WaypointSpeedParams = reader.ReadWaypointSpeedParams();
            while((reader.Stream.Length - reader.Stream.Position) >= 8)
            {
                Vector2 waypoint = reader.ReadVector2();
                result.Waypoints.Add(waypoint);
            }
            return result;
        }
        public override void WriteBody(PacketWriter writer)
        {
            writer.WriteInt32(SyncID);
            writer.WriteWaypointSpeedParams(WaypointSpeedParams);
            foreach(var waypoint in Waypoints)
            {
                writer.WriteVector2(waypoint);
            }
        }
    }
}
