﻿using EloBuddy;
using EloBuddy.SDK;
using static Mario_s_Lux.SpellsManager;

namespace Mario_s_Lux.Modes
{
    internal class AutoHarass
    {
        public static void Execute()
        {
            var target = TargetSelector.GetTarget(E.Range, DamageType.Mixed);

            Q.TryToCast(target, Menus.AutoHarassMenu);
            E.TryToCast(target, Menus.AutoHarassMenu);
        }
    }
}
