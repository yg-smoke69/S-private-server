using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001024")]
internal class FGCGPEPDCDA : UDPClientMessageBase
{
	[Token(Token = "0x4007BF9")]
	[FieldOffset(Offset = "0xC")]
	public List<ODHOKEODKPH> DGDAGDHAHBL;

	[Token(Token = "0x6006E74")]
	[Address(RVA = "0x3633814", Offset = "0x3633814", VA = "0x3633814")]
	public FGCGPEPDCDA()
	{
	}

	[Token(Token = "0x6006E75")]
	[Address(RVA = "0x3633898", Offset = "0x3633898", VA = "0x3633898", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006E76")]
	[Address(RVA = "0x3633A88", Offset = "0x3633A88", VA = "0x3633A88", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006E77")]
	[Address(RVA = "0x3633C48", Offset = "0x3633C48", VA = "0x3633C48", Slot = "9")]
	public override void Recycle()
	{
	}
}
