﻿using Pipliz.APIProvider.Science;
using Server.Science;

namespace Pipliz.BaseResearch.Implementations
{
	[AutoLoadedResearchable]
	public class HealthSize2 : BaseResearchable
	{
		public HealthSize2 ()
		{
			key = "pipliz.baseresearch.healthsize2";
			icon = "baseresearch_healthsize2.png";
			iterationCount = 50;
			AddIterationRequirement("sciencebagbasic");
			AddIterationRequirement("sciencebaglife");
			AddDependency("pipliz.baseresearch.healthsize1");
		}

		public override void OnResearchComplete (ScienceManagerPlayer manager)
		{
			manager.Player.SetTemporaryValue("pipliz.healthmax", 150f);
		}
	}
}
