using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F0C")]
internal class JHMFPMMDOLP : UDPClientMessageBase
{
	[Token(Token = "0x400795F")]
	[FieldOffset(Offset = "0x9")]
	public byte EBOKCJFLINE;

	[Token(Token = "0x4007960")]
	[FieldOffset(Offset = "0xC")]
	public uint DGLCOGJJFMI;

	[Token(Token = "0x4007961")]
	[FieldOffset(Offset = "0x10")]
	public List<uint> AFNMHMPPLLF;

	[Token(Token = "0x6006A14")]
	[Address(RVA = "0x367ABC8", Offset = "0x367ABC8", VA = "0x367ABC8")]
	public JHMFPMMDOLP()
	{
	}

	[Token(Token = "0x6006A15")]
	[Address(RVA = "0x367AC4C", Offset = "0x367AC4C", VA = "0x367AC4C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006A16")]
	[Address(RVA = "0x367AE94", Offset = "0x367AE94", VA = "0x367AE94", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006A17")]
	[Address(RVA = "0x367AFD0", Offset = "0x367AFD0", VA = "0x367AFD0", Slot = "9")]
	public override void Recycle()
	{
	}
}
