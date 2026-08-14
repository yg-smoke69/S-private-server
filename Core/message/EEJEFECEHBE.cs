using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000E78")]
internal class EEJEFECEHBE : UDPClientMessageBase
{
	[Token(Token = "0x4007709")]
	[FieldOffset(Offset = "0xC")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x400770A")]
	[FieldOffset(Offset = "0x10")]
	public uint HFJHJFBIEIL;

	[Token(Token = "0x400770B")]
	[FieldOffset(Offset = "0x14")]
	public uint FHPGPJDDFJB;

	[Token(Token = "0x400770C")]
	[FieldOffset(Offset = "0x18")]
	public List<uint> MGKCNAJDHEF;

	[Token(Token = "0x60067BC")]
	[Address(RVA = "0x36269CC", Offset = "0x36269CC", VA = "0x36269CC")]
	public EEJEFECEHBE()
	{
	}

	[Token(Token = "0x60067BD")]
	[Address(RVA = "0x3626A50", Offset = "0x3626A50", VA = "0x3626A50", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60067BE")]
	[Address(RVA = "0x3626CC4", Offset = "0x3626CC4", VA = "0x3626CC4", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60067BF")]
	[Address(RVA = "0x3626E14", Offset = "0x3626E14", VA = "0x3626E14", Slot = "9")]
	public override void Recycle()
	{
	}
}
