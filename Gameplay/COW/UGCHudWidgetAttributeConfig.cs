using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200240D")]
public class UGCHudWidgetAttributeConfig
{
	[Token(Token = "0x400E0AE")]
	[FieldOffset(Offset = "0x8")]
	protected Dictionary<int, List<int>> m_AttributesConfig;

	[Token(Token = "0x400E0AF")]
	[FieldOffset(Offset = "0xC")]
	private List<int> m_HeadAttributes;

	[Token(Token = "0x400E0B0")]
	[FieldOffset(Offset = "0x10")]
	private List<int> m_TransformAttributes;

	[Token(Token = "0x170010F9")]
	public Dictionary<int, List<int>> AttributesConfig
	{
		[Token(Token = "0x600CBB3")]
		[Address(RVA = "0x29F0AB4", Offset = "0x29F0AB4", VA = "0x29F0AB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600CBB2")]
	[Address(RVA = "0x29F04FC", Offset = "0x29F04FC", VA = "0x29F04FC")]
	public UGCHudWidgetAttributeConfig()
	{
	}

	[Token(Token = "0x600CBB4")]
	[Address(RVA = "0x29F0754", Offset = "0x29F0754", VA = "0x29F0754", Slot = "4")]
	protected virtual void AddAttributesConfig()
	{
	}
}
