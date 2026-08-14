using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20011DB")]
internal class FHOAOPOOLHJ : UDPClientMessageBase
{
	[Token(Token = "0x4007FE3")]
	[FieldOffset(Offset = "0xC")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x4007FE4")]
	[FieldOffset(Offset = "0x10")]
	public List<uint> KDNILIFJHHK;

	[Token(Token = "0x6007552")]
	[Address(RVA = "0x3634F28", Offset = "0x3634F28", VA = "0x3634F28")]
	public FHOAOPOOLHJ()
	{
	}

	[Token(Token = "0x6007553")]
	[Address(RVA = "0x3634FAC", Offset = "0x3634FAC", VA = "0x3634FAC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007554")]
	[Address(RVA = "0x36351C0", Offset = "0x36351C0", VA = "0x36351C0", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007555")]
	[Address(RVA = "0x36352E8", Offset = "0x36352E8", VA = "0x36352E8", Slot = "9")]
	public override void Recycle()
	{
	}
}
