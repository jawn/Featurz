﻿namespace Featurz.Application.Query.Feature
{
	using System;
	using Archer.Core.Entity;

	public class GetFeatureOwnersQuery : PageableQuery
	{
		public GetFeatureOwnersQuery(int pageSize, int page, string sortColumn, SortDirection sortDirection)
			: base(pageSize, page, sortColumn, sortDirection)
		{
		}
	}
}