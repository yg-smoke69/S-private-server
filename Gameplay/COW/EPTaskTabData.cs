using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025E3")]
public class EPTaskTabData
{
	[Token(Token = "0x400EA2A")]
	[FieldOffset(Offset = "0x8")]
	public EEPTaskTab m_Tab;

	[Token(Token = "0x400EA2B")]
	[FieldOffset(Offset = "0xC")]
	public string m_TabKey;

	[Token(Token = "0x400EA2C")]
	[FieldOffset(Offset = "0x10")]
	public ETipsType m_RedDot;

	[Token(Token = "0x400EA2D")]
	[FieldOffset(Offset = "0x14")]
	public Action m_OnSelectTab;

	[Token(Token = "0x400EA2E")]
	[FieldOffset(Offset = "0x18")]
	public List<int> m_SubTabs;

	[Token(Token = "0x600DF2D")]
	[Address(RVA = "0x251B238", Offset = "0x251B238", VA = "0x251B238")]
	public EPTaskTabData(EEPTaskTab tab, string tabKey)
	{
	}

	[Token(Token = "0x600DF2E")]
	[Address(RVA = "0x251B260", Offset = "0x251B260", VA = "0x251B260")]
	public EPTaskTabData()
	{
	}
}
