using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20011D6")]
internal class ALCLBMLOKEP : UDPClientMessageBase
{
	[Token(Token = "0x4007FD5")]
	[FieldOffset(Offset = "0xC")]
	public uint FOHBKMCOFCI;

	[Token(Token = "0x4007FD6")]
	[FieldOffset(Offset = "0x10")]
	public byte OKIDGMNALAK;

	[Token(Token = "0x600753E")]
	[Address(RVA = "0x337D17C", Offset = "0x337D17C", VA = "0x337D17C")]
	public ALCLBMLOKEP()
	{
	}

	[Token(Token = "0x600753F")]
	[Address(RVA = "0x337D200", Offset = "0x337D200", VA = "0x337D200", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007540")]
	[Address(RVA = "0x337D28C", Offset = "0x337D28C", VA = "0x337D28C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007541")]
	[Address(RVA = "0x337D2C0", Offset = "0x337D2C0", VA = "0x337D2C0", Slot = "9")]
	public override void Recycle()
	{
	}
}
