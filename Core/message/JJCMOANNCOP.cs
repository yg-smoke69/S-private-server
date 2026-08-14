using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200110A")]
internal class JJCMOANNCOP : UDPClientMessageBase
{
	[Token(Token = "0x4007E0C")]
	[FieldOffset(Offset = "0xC")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x4007E0D")]
	[FieldOffset(Offset = "0x10")]
	public uint HHGNJHALBGJ;

	[Token(Token = "0x4007E0E")]
	[FieldOffset(Offset = "0x14")]
	public List<DPLLONDLNOL> JFHGEIICJNA;

	[Token(Token = "0x600720E")]
	[Address(RVA = "0x367CE80", Offset = "0x367CE80", VA = "0x367CE80")]
	public JJCMOANNCOP()
	{
	}

	[Token(Token = "0x600720F")]
	[Address(RVA = "0x367CF04", Offset = "0x367CF04", VA = "0x367CF04", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007210")]
	[Address(RVA = "0x367D14C", Offset = "0x367D14C", VA = "0x367D14C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007211")]
	[Address(RVA = "0x367D334", Offset = "0x367D334", VA = "0x367D334", Slot = "9")]
	public override void Recycle()
	{
	}
}
