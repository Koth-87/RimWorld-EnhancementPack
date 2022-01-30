﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using HarmonyLib;

namespace TD_Enhancement_Pack
{
	[HarmonyPatch(typeof(AreaManager), nameof(AreaManager.CanMakeNewAllowed))]
	public static class AreaManager_CanMakeNewAllowed
	{
		static bool Prefix(ref bool __result)
		{
			if (Mod.settings.areasUnlimited)
			{
				__result = true;
				return false;
			}
			return true;
		}
	}
}
