﻿namespace Featurz.Application.Tests.Unit.CommandHandler.User
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Archer.Core.Repository;
	using Featurz.Application.Command.User;
	using Featurz.Application.CommandHandler.User;
	using Featurz.Application.CommandResult.User;
	using Featurz.Application.Entity;
	using Featurz.Application.Exceptions;
	using Featurz.Application.Message;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using NSubstitute;

	[TestClass]
	public class AddUserCommandHandlerTest
	{
		[TestClass]
		public class ExecuteTest
		{
			[TestMethod]
			public void Execute_Should_Not_Add_Invalid_User()
			{
				AddUserCommandHandler sut = GetCommandHandler();

				AddUserCommand command = UserCommandHandlerTestHelper.GetAddCommand("a".PadLeft(101, 'a'));

				string expectedInvalid = string.Format(MessagesModel.MaxLength, "100");

				UserCommandResult result = sut.Execute(command);

				var calls = sut.WriteRepository.ReceivedCalls().Count();

				Assert.AreEqual(0, calls);
			}

			private AddUserCommandHandler GetCommandHandler()
			{
				AddUserCommandHandler sut = new AddUserCommandHandler();
				IReadRepository<User> read = Substitute.For<IReadRepository<User>>();
				sut.ReadRepository = read;
				IWriteRepository<User> write = Substitute.For<IWriteRepository<User>>();
				sut.WriteRepository = write;
				return sut;
			}			
		}
	}
}