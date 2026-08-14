using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000E50")]
internal class GEDBLBAKEHG : UDPClientMessageBase
{
	[Token(Token = "0x400763B")]
	[FieldOffset(Offset = "0xC")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x400763C")]
	[FieldOffset(Offset = "0x10")]
	public List<int> HFPGENNDGME;

	[Token(Token = "0x600671C")]
	[Address(RVA = "0x363D144", Offset = "0x363D144", VA = "0x363D144")]
	public GEDBLBAKEHG()
	{
	}

	[Token(Token = "0x600671D")]
	[Address(RVA = "0x363D1C8", Offset = "0x363D1C8", VA = "0x363D1C8", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600671E")]
	[Address(RVA = "0x363D3DC", Offset = "0x363D3DC", VA = "0x363D3DC", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600671F")]
	[Address(RVA = "0x363D504", Offset = "0x363D504", VA = "0x363D504", Slot = "9")]
	public override void Recycle()
	{
	}
}
