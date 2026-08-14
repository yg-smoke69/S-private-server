using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200240F")]
public class UGCHudImageAttributeConfig : UGCHudWidgetAttributeConfig
{
	[Token(Token = "0x400E0B3")]
	[FieldOffset(Offset = "0x0")]
	public static UGCHudImageAttributeConfig Instance;

	[Token(Token = "0x400E0B4")]
	[FieldOffset(Offset = "0x14")]
	private List<int> m_ImageAttributes;

	[Token(Token = "0x600CBB9")]
	[Address(RVA = "0x29F03DC", Offset = "0x29F03DC", VA = "0x29F03DC")]
	public UGCHudImageAttributeConfig()
	{
	}

	[Token(Token = "0x600CBBA")]
	[Address(RVA = "0x29F0680", Offset = "0x29F0680", VA = "0x29F0680", Slot = "4")]
	protected override void AddAttributesConfig()
	{
	}

	[Token(Token = "0x600CBBC")]
	[Address(RVA = "0x29F0818", Offset = "0x29F0818", VA = "0x29F0818")]
	public void _003C_003EiFixBaseProxy_AddAttributesConfig()
	{
	}
}
