using Il2CppDummyDll;

[Token(Token = "0x2004075")]
public static class NetworkFacade
{
	[Token(Token = "0x401B1C9")]
	[FieldOffset(Offset = "0x0")]
	private static INetworkInterface m_Impl;

	[Token(Token = "0x17001CC3")]
	public static bool EnableVibrateFeature
	{
		[Token(Token = "0x601A390")]
		[Address(RVA = "0x1C72B70", Offset = "0x1C72B70", VA = "0x1C72B70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601A38F")]
	[Address(RVA = "0x1C72AB8", Offset = "0x1C72AB8", VA = "0x1C72AB8")]
	public static void SetImpl(INetworkInterface impl)
	{
	}
}
