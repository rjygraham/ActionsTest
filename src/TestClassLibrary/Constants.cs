using System;
using SourceGenSecrets;

namespace TestClassLibrary
{
	public static partial class Constants
	{
		public static partial class Api
		{
			[SourceGenSecret(EnvironmentVariableName = "API_HOST_URL")]
			public static string HostUrl { get; private set; }
		}
	}
}
