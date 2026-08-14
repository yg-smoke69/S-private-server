using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001265")]
internal class JBNPOIBIONB : UDPClientMessageBase
{
	[Token(Token = "0x4008115")]
	[FieldOffset(Offset = "0xC")]
	public uint AJJGDGGOHAF;

	[Token(Token = "0x4008116")]
	[FieldOffset(Offset = "0x10")]
	public uint BNMIJIJLBLD;

	[Token(Token = "0x4008117")]
	[FieldOffset(Offset = "0x14")]
	public int CCNKOGNNMOM;

	[Token(Token = "0x4008118")]
	[FieldOffset(Offset = "0x18")]
	public List<FJOPCENPAFA> IAADOGKEIIA;

	[Token(Token = "0x600777A")]
	[Address(RVA = "0x3674F68", Offset = "0x3674F68", VA = "0x3674F68")]
	public JBNPOIBIONB()
	{
	}

	[Token(Token = "0x600777B")]
	[Address(RVA = "0x3674FEC", Offset = "0x3674FEC", VA = "0x3674FEC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600777C")]
	[Address(RVA = "0x3675260", Offset = "0x3675260", VA = "0x3675260", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600777D")]
	[Address(RVA = "0x367545C", Offset = "0x367545C", VA = "0x367545C", Slot = "9")]
	public override void Recycle()
	{
	}
}
