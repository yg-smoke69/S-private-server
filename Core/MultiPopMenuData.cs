using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20029CE")]
public class MultiPopMenuData
{
	[Token(Token = "0x401011B")]
	[FieldOffset(Offset = "0x8")]
	public string m_Key;

	[Token(Token = "0x401011C")]
	[FieldOffset(Offset = "0xC")]
	public string m_Label;

	[Token(Token = "0x401011D")]
	[FieldOffset(Offset = "0x10")]
	public bool m_CanSelect;

	[Token(Token = "0x401011E")]
	[FieldOffset(Offset = "0x14")]
	public string m_SelectTip;

	[Token(Token = "0x401011F")]
	[FieldOffset(Offset = "0x18")]
	public List<MultiPopMenuData> m_Values;

	[Token(Token = "0x6010D20")]
	[Address(RVA = "0x1C726D4", Offset = "0x1C726D4", VA = "0x1C726D4")]
	public MultiPopMenuData()
	{
	}
}
