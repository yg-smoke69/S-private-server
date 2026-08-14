using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20011DC")]
internal class ANFEBONPNFH : UDPClientMessageBase
{
	[Token(Token = "0x4007FE5")]
	[FieldOffset(Offset = "0xC")]
	public uint POBGKMDJMDC;

	[Token(Token = "0x4007FE6")]
	[FieldOffset(Offset = "0x10")]
	public byte IMHDIHCCAJL;

	[Token(Token = "0x6007556")]
	[Address(RVA = "0x337E988", Offset = "0x337E988", VA = "0x337E988")]
	public ANFEBONPNFH()
	{
	}

	[Token(Token = "0x6007557")]
	[Address(RVA = "0x337EA0C", Offset = "0x337EA0C", VA = "0x337EA0C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007558")]
	[Address(RVA = "0x337EA98", Offset = "0x337EA98", VA = "0x337EA98", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007559")]
	[Address(RVA = "0x337EACC", Offset = "0x337EACC", VA = "0x337EACC", Slot = "9")]
	public override void Recycle()
	{
	}
}
