﻿namespace Featurz.Application.Command.Feature
{
	using System;
	using Archer.Core.Command;

	public class EditFeatureCommand : ICommand
	{
		public EditFeatureCommand(string id, string name, string userId, string ticket = "", bool isActive = false, bool isEnabled = false, int strategyId = 0)
		{
			this.Id = id;
			this.Name = name;
			this.IsActive = isActive;
			this.IsEnabled = isEnabled;
			this.StrategyId = strategyId;
			this.Ticket = ticket;
			this.UserId = userId;
			this.Valid = true;
		}

		public string Id { get; private set; }

		public string InvalidName { get; set; }

		public string InvalidTicket { get; set; }

		public bool IsActive { get; private set; }

		public bool IsEnabled { get; private set; }

		public string Message { get; set; }

		public string Name { get; private set; }

		public int StrategyId { get; private set; }

		public string Ticket { get; private set; }

		public string UserId { get; private set; }

		public bool Valid { get; set; }
	}
}