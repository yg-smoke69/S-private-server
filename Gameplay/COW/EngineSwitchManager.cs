using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000288")]
public static class EngineSwitchManager
{
	[Token(Token = "0x4000F75")]
	[FieldOffset(Offset = "0x0")]
	private static uint m_CurrentShaderKeyword;

	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x2537568", Offset = "0x2537568", VA = "0x2537568")]
	public static void ApplyEngineSwitch()
	{
	}

	[Token(Token = "0x6000C57")]
	[Address(RVA = "0x2537828", Offset = "0x2537828", VA = "0x2537828")]
	public static void ApplyEngineAction(EngineActionFlag action_flag, uint external_value = 0u)
	{
	}

	[Token(Token = "0x6000C58")]
	[Address(RVA = "0x2537BBC", Offset = "0x2537BBC", VA = "0x2537BBC")]
	public static void EnableShaderKeyword(uint[] flags)
	{
	}

	[Token(Token = "0x6000C59")]
	[Address(RVA = "0x2537DDC", Offset = "0x2537DDC", VA = "0x2537DDC")]
	public static void DisableShaderKeyword(uint[] flags)
	{
	}

	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0x2537FFC", Offset = "0x2537FFC", VA = "0x2537FFC")]
	public static void EnableParticleMemOpt(bool enable)
	{
	}
}
