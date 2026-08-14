using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20011DD")]
internal class IKBMBPBHMPA : UDPClientMessageBase
{
	[Token(Token = "0x4007FE7")]
	[FieldOffset(Offset = "0xC")]
	public uint NICEOKJBEDK;

	[Token(Token = "0x4007FE8")]
	[FieldOffset(Offset = "0x10")]
	public uint OLNEAONMMDO;

	[Token(Token = "0x4007FE9")]
	[FieldOffset(Offset = "0x14")]
	public uint BPJECBDKDIM;

	[Token(Token = "0x4007FEA")]
	[FieldOffset(Offset = "0x18")]
	public List<byte> CLCFBJIKGBN;

	[Token(Token = "0x600755A")]
	[Address(RVA = "0x361C654", Offset = "0x361C654", VA = "0x361C654")]
	public IKBMBPBHMPA()
	{
	}

	[Token(Token = "0x600755B")]
	[Address(RVA = "0x361C6D8", Offset = "0x361C6D8", VA = "0x361C6D8", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600755C")]
	[Address(RVA = "0x361C94C", Offset = "0x361C94C", VA = "0x361C94C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600755D")]
	[Address(RVA = "0x361CA9C", Offset = "0x361CA9C", VA = "0x361CA9C", Slot = "9")]
	public override void Recycle()
	{
	}
}
