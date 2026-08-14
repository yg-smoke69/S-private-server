using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200114E")]
internal class NMAIHAMENDA : UDPClientMessageBase
{
	[Token(Token = "0x4007EA5")]
	[FieldOffset(Offset = "0xC")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x4007EA6")]
	[FieldOffset(Offset = "0x10")]
	public uint EIDFILIJPIK;

	[Token(Token = "0x4007EA7")]
	[FieldOffset(Offset = "0x14")]
	public ushort HHCMAFJHLOM;

	[Token(Token = "0x4007EA8")]
	[FieldOffset(Offset = "0x16")]
	public bool HONFFHPBPOJ;

	[Token(Token = "0x600731E")]
	[Address(RVA = "0x364A460", Offset = "0x364A460", VA = "0x364A460")]
	public NMAIHAMENDA()
	{
	}

	[Token(Token = "0x600731F")]
	[Address(RVA = "0x364A4E4", Offset = "0x364A4E4", VA = "0x364A4E4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007320")]
	[Address(RVA = "0x364A5D8", Offset = "0x364A5D8", VA = "0x364A5D8", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007321")]
	[Address(RVA = "0x364A634", Offset = "0x364A634", VA = "0x364A634", Slot = "9")]
	public override void Recycle()
	{
	}
}
