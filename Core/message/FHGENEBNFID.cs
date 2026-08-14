using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000FDB")]
internal class FHGENEBNFID : UDPClientMessageBase
{
	[Token(Token = "0x4007B71")]
	[FieldOffset(Offset = "0x9")]
	public bool IMPPEOAFEAI;

	[Token(Token = "0x4007B72")]
	[FieldOffset(Offset = "0xA")]
	public byte PIFEGMBOLDN;

	[Token(Token = "0x6006D50")]
	[Address(RVA = "0x363490C", Offset = "0x363490C", VA = "0x363490C")]
	public FHGENEBNFID()
	{
	}

	[Token(Token = "0x6006D51")]
	[Address(RVA = "0x3634990", Offset = "0x3634990", VA = "0x3634990", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006D52")]
	[Address(RVA = "0x3634A2C", Offset = "0x3634A2C", VA = "0x3634A2C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006D53")]
	[Address(RVA = "0x3634A60", Offset = "0x3634A60", VA = "0x3634A60", Slot = "9")]
	public override void Recycle()
	{
	}
}
