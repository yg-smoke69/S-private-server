using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029F4")]
public class UINewVaultItemViewData
{
	[Token(Token = "0x4010208")]
	[FieldOffset(Offset = "0x8")]
	public UIModelNewVault.eSecondTab Tab;

	[Token(Token = "0x4010209")]
	[FieldOffset(Offset = "0xC")]
	public int Index;

	[Token(Token = "0x401020A")]
	[FieldOffset(Offset = "0x10")]
	public int ID;

	[Token(Token = "0x401020B")]
	[FieldOffset(Offset = "0x14")]
	public Action<int> OnClick;

	[Token(Token = "0x401020C")]
	[FieldOffset(Offset = "0x18")]
	public bool IsEquiped;

	[Token(Token = "0x6010E8B")]
	[Address(RVA = "0x26C8138", Offset = "0x26C8138", VA = "0x26C8138")]
	public UINewVaultItemViewData()
	{
	}
}
