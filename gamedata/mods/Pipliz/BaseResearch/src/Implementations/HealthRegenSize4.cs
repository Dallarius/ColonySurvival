﻿using Pipliz.APIProvider.Science;
using Server.Science;

namespace Pipliz.BaseResearch.Implementations
{
	[AutoLoadedResearchable]
	public class HealthRegenSize4 : BaseResearchable
	{
		public HealthRegenSize4 ()
		{
			key = "pipliz.baseresearch.healthregensize4";
			icon = "baseresearch_healthregensize4.png";
			iterationCount = 50;
			AddIterationRequirement("sciencebagbasic", 3);
			AddIterationRequirement("sciencebaglife", 5);
			AddDependency("pipliz.baseresearch.healthregensize3");
		}

		public override void OnResearchComplete (ScienceManagerPlayer manager)
		{
			manager.Player.SetTemporaryValue("pipliz.healthregenmax", 100f);
		}
	}
}
