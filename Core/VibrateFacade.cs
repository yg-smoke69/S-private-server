using Il2CppDummyDll;

[Token(Token = "0x200404B")]
public static class VibrateFacade
{
	[Token(Token = "0x401B0F4")]
	[FieldOffset(Offset = "0x0")]
	private static IVibrateInterface m_Impl;

	[Token(Token = "0x17001CB4")]
	public static bool EnableVibrateFeature
	{
		[Token(Token = "0x601A2B0")]
		[Address(RVA = "0x2A69F6C", Offset = "0x2A69F6C", VA = "0x2A69F6C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601A2AF")]
	[Address(RVA = "0x2A69EB4", Offset = "0x2A69EB4", VA = "0x2A69EB4")]
	public static void SetImpl(IVibrateInterface impl)
	{
	}
}
