using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001015")]
internal class MNIFNEOLBLN : UDPClientMessageBase
{
	[Token(Token = "0x4007BE0")]
	[FieldOffset(Offset = "0x9")]
	public byte CNBBKLIEPFL;

	[Token(Token = "0x4007BE1")]
	[FieldOffset(Offset = "0xC")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x4007BE2")]
	[FieldOffset(Offset = "0x10")]
	public List<uint> ILPCJAMCJMH;

	[Token(Token = "0x6006E38")]
	[Address(RVA = "0x3446FE0", Offset = "0x3446FE0", VA = "0x3446FE0")]
	public MNIFNEOLBLN()
	{
	}

	[Token(Token = "0x6006E39")]
	[Address(RVA = "0x3447064", Offset = "0x3447064", VA = "0x3447064", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006E3A")]
	[Address(RVA = "0x34472AC", Offset = "0x34472AC", VA = "0x34472AC", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006E3B")]
	[Address(RVA = "0x34473E8", Offset = "0x34473E8", VA = "0x34473E8", Slot = "9")]
	public override void Recycle()
	{
	}
}
