using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20011D2")]
internal class EBDLMAHABAD : UDPClientMessageBase
{
	[Token(Token = "0x4007FCD")]
	[FieldOffset(Offset = "0xC")]
	public List<uint> FOHBKMCOFCI;

	[Token(Token = "0x4007FCE")]
	[FieldOffset(Offset = "0x10")]
	public byte OKIDGMNALAK;

	[Token(Token = "0x600752E")]
	[Address(RVA = "0x3623CFC", Offset = "0x3623CFC", VA = "0x3623CFC")]
	public EBDLMAHABAD()
	{
	}

	[Token(Token = "0x600752F")]
	[Address(RVA = "0x3623D80", Offset = "0x3623D80", VA = "0x3623D80", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007530")]
	[Address(RVA = "0x3623FA0", Offset = "0x3623FA0", VA = "0x3623FA0", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007531")]
	[Address(RVA = "0x36240C8", Offset = "0x36240C8", VA = "0x36240C8", Slot = "9")]
	public override void Recycle()
	{
	}
}
