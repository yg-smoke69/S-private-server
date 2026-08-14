using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200122D")]
internal class IEMKOPMFIID : UDPClientMessageBase
{
	[Token(Token = "0x40080A6")]
	[FieldOffset(Offset = "0xC")]
	public List<MAABCBLEBIC> MHOFNBLGEOL;

	[Token(Token = "0x600769A")]
	[Address(RVA = "0x36188E8", Offset = "0x36188E8", VA = "0x36188E8")]
	public IEMKOPMFIID()
	{
	}

	[Token(Token = "0x600769B")]
	[Address(RVA = "0x361896C", Offset = "0x361896C", VA = "0x361896C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600769C")]
	[Address(RVA = "0x3618B5C", Offset = "0x3618B5C", VA = "0x3618B5C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600769D")]
	[Address(RVA = "0x3618D1C", Offset = "0x3618D1C", VA = "0x3618D1C", Slot = "9")]
	public override void Recycle()
	{
	}
}
