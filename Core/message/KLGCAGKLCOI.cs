using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200100A")]
internal class KLGCAGKLCOI : UDPClientMessageBase
{
	[Token(Token = "0x4007BD3")]
	[FieldOffset(Offset = "0xC")]
	public List<uint> JLGIBBAPKOB;

	[Token(Token = "0x4007BD4")]
	[FieldOffset(Offset = "0x10")]
	public List<uint> NPNKAHHBOCP;

	[Token(Token = "0x6006E0C")]
	[Address(RVA = "0x3690118", Offset = "0x3690118", VA = "0x3690118")]
	public KLGCAGKLCOI()
	{
	}

	[Token(Token = "0x6006E0D")]
	[Address(RVA = "0x369019C", Offset = "0x369019C", VA = "0x369019C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006E0E")]
	[Address(RVA = "0x36904FC", Offset = "0x36904FC", VA = "0x36904FC", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006E0F")]
	[Address(RVA = "0x36906D4", Offset = "0x36906D4", VA = "0x36906D4", Slot = "9")]
	public override void Recycle()
	{
	}
}
