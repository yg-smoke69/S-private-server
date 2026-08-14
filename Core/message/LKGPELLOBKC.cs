using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001154")]
internal class LKGPELLOBKC : UDPClientMessageBase
{
	[Token(Token = "0x4007EAF")]
	[FieldOffset(Offset = "0x9")]
	public byte DBNFHMGAJAG;

	[Token(Token = "0x4007EB0")]
	[FieldOffset(Offset = "0xC")]
	public List<uint> KHHNCIBNEFL;

	[Token(Token = "0x6007336")]
	[Address(RVA = "0x3435180", Offset = "0x3435180", VA = "0x3435180")]
	public LKGPELLOBKC()
	{
	}

	[Token(Token = "0x6007337")]
	[Address(RVA = "0x3435204", Offset = "0x3435204", VA = "0x3435204", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007338")]
	[Address(RVA = "0x3435418", Offset = "0x3435418", VA = "0x3435418", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007339")]
	[Address(RVA = "0x3435540", Offset = "0x3435540", VA = "0x3435540", Slot = "9")]
	public override void Recycle()
	{
	}
}
