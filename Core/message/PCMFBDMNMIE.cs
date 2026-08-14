using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F1E")]
internal class PCMFBDMNMIE : UDPClientMessageBase
{
	[Token(Token = "0x4007997")]
	[FieldOffset(Offset = "0xC")]
	public List<KIOJBBGCECB> GBEHIPBDLCB;

	[Token(Token = "0x6006A5C")]
	[Address(RVA = "0x365C138", Offset = "0x365C138", VA = "0x365C138")]
	public PCMFBDMNMIE()
	{
	}

	[Token(Token = "0x6006A5D")]
	[Address(RVA = "0x365C1BC", Offset = "0x365C1BC", VA = "0x365C1BC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006A5E")]
	[Address(RVA = "0x365C3AC", Offset = "0x365C3AC", VA = "0x365C3AC", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006A5F")]
	[Address(RVA = "0x365C56C", Offset = "0x365C56C", VA = "0x365C56C", Slot = "9")]
	public override void Recycle()
	{
	}
}
