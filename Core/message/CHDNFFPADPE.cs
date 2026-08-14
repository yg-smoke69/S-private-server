using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200108A")]
internal class CHDNFFPADPE : UDPClientMessageBase
{
	[Token(Token = "0x4007CFB")]
	[FieldOffset(Offset = "0xA")]
	public ushort LLHLOCCAJGA;

	[Token(Token = "0x4007CFC")]
	[FieldOffset(Offset = "0xC")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x600700D")]
	[Address(RVA = "0x3753B00", Offset = "0x3753B00", VA = "0x3753B00")]
	public CHDNFFPADPE()
	{
	}

	[Token(Token = "0x600700E")]
	[Address(RVA = "0x3753B84", Offset = "0x3753B84", VA = "0x3753B84", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600700F")]
	[Address(RVA = "0x3753C10", Offset = "0x3753C10", VA = "0x3753C10", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007010")]
	[Address(RVA = "0x3753C44", Offset = "0x3753C44", VA = "0x3753C44", Slot = "9")]
	public override void Recycle()
	{
	}
}
