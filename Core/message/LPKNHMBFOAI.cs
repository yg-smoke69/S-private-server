using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20011A8")]
internal class LPKNHMBFOAI : UDPClientMessageBase
{
	[Token(Token = "0x4007F6C")]
	[FieldOffset(Offset = "0xC")]
	public List<KDDCLBPDCFB> JBHHDGLFDJH;

	[Token(Token = "0x6007486")]
	[Address(RVA = "0x343A848", Offset = "0x343A848", VA = "0x343A848")]
	public LPKNHMBFOAI()
	{
	}

	[Token(Token = "0x6007487")]
	[Address(RVA = "0x343A8CC", Offset = "0x343A8CC", VA = "0x343A8CC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007488")]
	[Address(RVA = "0x343AABC", Offset = "0x343AABC", VA = "0x343AABC", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007489")]
	[Address(RVA = "0x343AC7C", Offset = "0x343AC7C", VA = "0x343AC7C", Slot = "9")]
	public override void Recycle()
	{
	}
}
