using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20011AC")]
internal class LMGAGDLMDDD : UDPClientMessageBase
{
	[Token(Token = "0x4007F71")]
	[FieldOffset(Offset = "0xC")]
	public List<byte> PDOFBMMMPHB;

	[Token(Token = "0x6007496")]
	[Address(RVA = "0x3437B80", Offset = "0x3437B80", VA = "0x3437B80")]
	public LMGAGDLMDDD()
	{
	}

	[Token(Token = "0x6007497")]
	[Address(RVA = "0x3437C04", Offset = "0x3437C04", VA = "0x3437C04", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007498")]
	[Address(RVA = "0x3437DF4", Offset = "0x3437DF4", VA = "0x3437DF4", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007499")]
	[Address(RVA = "0x3437F08", Offset = "0x3437F08", VA = "0x3437F08", Slot = "9")]
	public override void Recycle()
	{
	}
}
