using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20010EB")]
internal class BNCMBMEFNLK : UDPClientMessageBase
{
	[Token(Token = "0x4007DB6")]
	[FieldOffset(Offset = "0xC")]
	public uint HBKLJILMHKL;

	[Token(Token = "0x4007DB7")]
	[FieldOffset(Offset = "0x10")]
	public List<uint> IPCIBPENHME;

	[Token(Token = "0x4007DB8")]
	[FieldOffset(Offset = "0x14")]
	public uint JKHMCHDOHJD;

	[Token(Token = "0x6007191")]
	[Address(RVA = "0x374C284", Offset = "0x374C284", VA = "0x374C284")]
	public BNCMBMEFNLK()
	{
	}

	[Token(Token = "0x6007192")]
	[Address(RVA = "0x374C308", Offset = "0x374C308", VA = "0x374C308", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007193")]
	[Address(RVA = "0x374C54C", Offset = "0x374C54C", VA = "0x374C54C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007194")]
	[Address(RVA = "0x374C68C", Offset = "0x374C68C", VA = "0x374C68C", Slot = "9")]
	public override void Recycle()
	{
	}
}
