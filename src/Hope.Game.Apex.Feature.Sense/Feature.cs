﻿using Hope.Game.Apex.Core;
using Hope.Game.Apex.Core.Interfaces;
using Hope.Game.Apex.Core.Models;
using Hope.Core.Models;

namespace Hope.Game.Apex.Feature.Sense
{
    public class Feature : IFeature
    {
        private readonly Config _config;

        #region Constructors

        public Feature(Config config)
        {
            _config = config;
        }

        #endregion

        #region Implementation of IFeature

        public void Tick(DateTime frameTime, State state)
        {
            if (state.Players.TryGetValue(state.LocalPlayer, out var localPlayer))
            {
                foreach (var (_, player) in state.Players)
                {
                    if (player.IsValid() && !player.IsSameTeam(localPlayer))
                    {
                        if (localPlayer.LocalOrigin.Distance2(player.LocalOrigin) * Constants.UnitToMeter < _config.Distance)
                        {
                            player.GlowEnable = (byte)1;
                            player.GlowThroughWalls = (byte)(player.Visible ? 1 : 2);
                            player.GlowColor = (player.Visible? new Vector(10.0f, 0.0f, 0.0f) : new Vector(0.0f, 11.0f, 15.0f));
                        }
                        else if (player.GlowEnable is 1 or 7)
                        {
                            player.GlowEnable = 2;
                            player.GlowThroughWalls = 5;
                        }
                    }
                }
            }
        }

        #endregion
    }
}
