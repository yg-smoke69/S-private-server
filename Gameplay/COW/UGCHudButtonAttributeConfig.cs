using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002410")]
public class UGCHudButtonAttributeConfig : UGCHudWidgetAttributeConfig
{
	[Token(Token = "0x400E0B5")]
	[FieldOffset(Offset = "0x0")]
	public static UGCHudButtonAttributeConfig Instance;

	[Token(Token = "0x400E0B6")]
	[FieldOffset(Offset = "0x14")]
	private List<int> m_ButtonAttributes;

	[Token(Token = "0x600CBBD")]
	[Address(RVA = "0x23428B4", Offset = "0x23428B4", VA = "0x23428B4")]
	public UGCHudButtonAttributeConfig()
	{
	}

	[Token(Token = "0x600CBBE")]
	[Address(RVA = "0x23429B0", Offset = "0x23429B0", VA = "0x23429B0", Slot = "4")]
	protected override void AddAttributesConfig()
	{
	}

	[Token(Token = "0x600CBC0")]
	[Address(RVA = "0x2342AF8", Offset = "0x2342AF8", VA = "0x2342AF8")]
	public void _003C_003EiFixBaseProxy_AddAttributesConfig()
	{
	}
}
