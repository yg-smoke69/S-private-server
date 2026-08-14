using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001101")]
internal class DNBECGLAPFM : UDPClientMessageBase
{
	[Token(Token = "0x4007DF7")]
	[FieldOffset(Offset = "0xC")]
	public uint POBGKMDJMDC;

	[Token(Token = "0x4007DF8")]
	[FieldOffset(Offset = "0x10")]
	public List<byte> LNOLNLMIEHC;

	[Token(Token = "0x60071E9")]
	[Address(RVA = "0x3764B68", Offset = "0x3764B68", VA = "0x3764B68")]
	public DNBECGLAPFM()
	{
	}

	[Token(Token = "0x60071EA")]
	[Address(RVA = "0x3764BEC", Offset = "0x3764BEC", VA = "0x3764BEC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60071EB")]
	[Address(RVA = "0x3764E00", Offset = "0x3764E00", VA = "0x3764E00", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60071EC")]
	[Address(RVA = "0x3764F28", Offset = "0x3764F28", VA = "0x3764F28", Slot = "9")]
	public override void Recycle()
	{
	}
}
