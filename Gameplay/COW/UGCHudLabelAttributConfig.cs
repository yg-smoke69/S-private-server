using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200240E")]
public class UGCHudLabelAttributConfig : UGCHudWidgetAttributeConfig
{
	[Token(Token = "0x400E0B1")]
	[FieldOffset(Offset = "0x0")]
	public static UGCHudLabelAttributConfig Instance;

	[Token(Token = "0x400E0B2")]
	[FieldOffset(Offset = "0x14")]
	private List<int> m_TextAttributes;

	[Token(Token = "0x600CBB5")]
	[Address(RVA = "0x29F081C", Offset = "0x29F081C", VA = "0x29F081C")]
	public UGCHudLabelAttributConfig()
	{
	}

	[Token(Token = "0x600CBB6")]
	[Address(RVA = "0x29F0964", Offset = "0x29F0964", VA = "0x29F0964", Slot = "4")]
	protected override void AddAttributesConfig()
	{
	}

	[Token(Token = "0x600CBB8")]
	[Address(RVA = "0x29F0AA8", Offset = "0x29F0AA8", VA = "0x29F0AA8")]
	public void _003C_003EiFixBaseProxy_AddAttributesConfig()
	{
	}
}
