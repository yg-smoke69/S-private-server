using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001216")]
internal class MMIIMCHFBLF : UDPClientMessageBase
{
	[Token(Token = "0x4008070")]
	[FieldOffset(Offset = "0xC")]
	public uint CELIGAILOGJ;

	[Token(Token = "0x600763E")]
	[Address(RVA = "0x3446D98", Offset = "0x3446D98", VA = "0x3446D98")]
	public MMIIMCHFBLF()
	{
	}

	[Token(Token = "0x600763F")]
	[Address(RVA = "0x3446E1C", Offset = "0x3446E1C", VA = "0x3446E1C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007640")]
	[Address(RVA = "0x3446E78", Offset = "0x3446E78", VA = "0x3446E78", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007641")]
	[Address(RVA = "0x3446E94", Offset = "0x3446E94", VA = "0x3446E94", Slot = "9")]
	public override void Recycle()
	{
	}
}
