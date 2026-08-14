using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001063")]
internal class NIHEPMHCKCO : UDPClientMessageBase
{
	[Token(Token = "0x4007C9F")]
	[FieldOffset(Offset = "0xC")]
	public List<BKFACHPBPFO> DGDAGDHAHBL;

	[Token(Token = "0x6006F71")]
	[Address(RVA = "0x36474BC", Offset = "0x36474BC", VA = "0x36474BC")]
	public NIHEPMHCKCO()
	{
	}

	[Token(Token = "0x6006F72")]
	[Address(RVA = "0x3647540", Offset = "0x3647540", VA = "0x3647540", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006F73")]
	[Address(RVA = "0x3647730", Offset = "0x3647730", VA = "0x3647730", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006F74")]
	[Address(RVA = "0x36478F0", Offset = "0x36478F0", VA = "0x36478F0", Slot = "9")]
	public override void Recycle()
	{
	}
}
