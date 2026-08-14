using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028C6")]
public class HistroyPlayerInfo
{
	[Token(Token = "0x400FADB")]
	[FieldOffset(Offset = "0x8")]
	public int PlayerColorIndex;

	[Token(Token = "0x400FADC")]
	[FieldOffset(Offset = "0xC")]
	public string PlayerName;

	[Token(Token = "0x400FADD")]
	[FieldOffset(Offset = "0x10")]
	public bool IsOut;

	[Token(Token = "0x400FADE")]
	[FieldOffset(Offset = "0x11")]
	public bool IsWolf;

	[Token(Token = "0x400FADF")]
	[FieldOffset(Offset = "0x14")]
	public List<int> votePlayerColorIndexs;

	[Token(Token = "0x60100E3")]
	[Address(RVA = "0x190DDA8", Offset = "0x190DDA8", VA = "0x190DDA8")]
	public HistroyPlayerInfo()
	{
	}
}
