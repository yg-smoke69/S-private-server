using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000FF4")]
internal class EEEPKGOOIII : UDPClientMessageBase
{
	[Token(Token = "0x4007BA6")]
	[FieldOffset(Offset = "0xC")]
	public List<byte> AFKAIMGAINI;

	[Token(Token = "0x4007BA7")]
	[FieldOffset(Offset = "0x10")]
	public uint NCPCEMPOMPK;

	[Token(Token = "0x6006DB4")]
	[Address(RVA = "0x3626080", Offset = "0x3626080", VA = "0x3626080")]
	public EEEPKGOOIII()
	{
	}

	[Token(Token = "0x6006DB5")]
	[Address(RVA = "0x3626104", Offset = "0x3626104", VA = "0x3626104", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006DB6")]
	[Address(RVA = "0x3626324", Offset = "0x3626324", VA = "0x3626324", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006DB7")]
	[Address(RVA = "0x362644C", Offset = "0x362644C", VA = "0x362644C", Slot = "9")]
	public override void Recycle()
	{
	}
}
