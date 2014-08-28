﻿namespace Featurz.Application.Query
{
	using System;
	using Archer.Core.Query;

	public class GetFeatureByIdQuery : IQuery
	{
		public GetFeatureByIdQuery(string featureId)
		{
			this.FeatureId = featureId;
		}

		public string FeatureId { get; private set; }
	}
}