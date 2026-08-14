using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001230")]
internal class LDGCINLPOMB : UDPClientMessageBase
{
	[Token(Token = "0x40080AB")]
	[FieldOffset(Offset = "0xC")]
	public int APNNIJDMGGF;

	[Token(Token = "0x40080AC")]
	[FieldOffset(Offset = "0x10")]
	public List<string> BMAMCCMDOBB;

	[Token(Token = "0x40080AD")]
	[FieldOffset(Offset = "0x14")]
	public List<string> EMGLFOHCILK;

	[Token(Token = "0x40080AE")]
	[FieldOffset(Offset = "0x18")]
	public List<sbyte> IAOIMPBHJMP;

	[Token(Token = "0x60076A6")]
	[Address(RVA = "0x342F3AC", Offset = "0x342F3AC", VA = "0x342F3AC")]
	public LDGCINLPOMB()
	{
	}

	[Token(Token = "0x60076A7")]
	[Address(RVA = "0x342F430", Offset = "0x342F430", VA = "0x342F430", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60076A8")]
	[Address(RVA = "0x342F94C", Offset = "0x342F94C", VA = "0x342F94C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60076A9")]
	[Address(RVA = "0x342FBFC", Offset = "0x342FBFC", VA = "0x342FBFC", Slot = "9")]
	public override void Recycle()
	{
	}
}
