using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001100")]
internal class GGAPHBDEDDP : UDPClientMessageBase
{
	[Token(Token = "0x4007DF4")]
	[FieldOffset(Offset = "0xC")]
	public uint POBGKMDJMDC;

	[Token(Token = "0x4007DF5")]
	[FieldOffset(Offset = "0x10")]
	public byte MMJMADPFKIF;

	[Token(Token = "0x4007DF6")]
	[FieldOffset(Offset = "0x14")]
	public List<byte> LNOLNLMIEHC;

	[Token(Token = "0x60071E5")]
	[Address(RVA = "0x36019B8", Offset = "0x36019B8", VA = "0x36019B8")]
	public GGAPHBDEDDP()
	{
	}

	[Token(Token = "0x60071E6")]
	[Address(RVA = "0x3601A3C", Offset = "0x3601A3C", VA = "0x3601A3C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60071E7")]
	[Address(RVA = "0x3601C84", Offset = "0x3601C84", VA = "0x3601C84", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60071E8")]
	[Address(RVA = "0x3601DC0", Offset = "0x3601DC0", VA = "0x3601DC0", Slot = "9")]
	public override void Recycle()
	{
	}
}
