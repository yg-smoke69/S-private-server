using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200115F")]
internal class PDENFIHPMBL : UDPClientMessageBase
{
	[Token(Token = "0x4007EC0")]
	[FieldOffset(Offset = "0x9")]
	public byte DNHMEPGDDOD;

	[Token(Token = "0x6007362")]
	[Address(RVA = "0x365CE70", Offset = "0x365CE70", VA = "0x365CE70")]
	public PDENFIHPMBL()
	{
	}

	[Token(Token = "0x6007363")]
	[Address(RVA = "0x365CEF4", Offset = "0x365CEF4", VA = "0x365CEF4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007364")]
	[Address(RVA = "0x365CF50", Offset = "0x365CF50", VA = "0x365CF50", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007365")]
	[Address(RVA = "0x365CF6C", Offset = "0x365CF6C", VA = "0x365CF6C", Slot = "9")]
	public override void Recycle()
	{
	}
}
