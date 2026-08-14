using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20010E5")]
internal class JGCALMFCGOP : UDPClientMessageBase
{
	[Token(Token = "0x4007DAE")]
	[FieldOffset(Offset = "0xC")]
	public List<string> MHOFNBLGEOL;

	[Token(Token = "0x6007179")]
	[Address(RVA = "0x3678FFC", Offset = "0x3678FFC", VA = "0x3678FFC")]
	public JGCALMFCGOP()
	{
	}

	[Token(Token = "0x600717A")]
	[Address(RVA = "0x3679080", Offset = "0x3679080", VA = "0x3679080", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600717B")]
	[Address(RVA = "0x3679258", Offset = "0x3679258", VA = "0x3679258", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600717C")]
	[Address(RVA = "0x367936C", Offset = "0x367936C", VA = "0x367936C", Slot = "9")]
	public override void Recycle()
	{
	}
}
