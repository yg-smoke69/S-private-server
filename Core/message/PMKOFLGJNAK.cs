using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000ED6")]
internal class PMKOFLGJNAK : UDPClientMessageBase
{
	[Token(Token = "0x4007882")]
	[FieldOffset(Offset = "0xC")]
	public List<KLGKMCNCIAJ> OODGPKACHFN;

	[Token(Token = "0x4007883")]
	[FieldOffset(Offset = "0x10")]
	public uint CEDJCPLOLNE;

	[Token(Token = "0x6006938")]
	[Address(RVA = "0x31770C8", Offset = "0x31770C8", VA = "0x31770C8")]
	public PMKOFLGJNAK()
	{
	}

	[Token(Token = "0x6006939")]
	[Address(RVA = "0x317714C", Offset = "0x317714C", VA = "0x317714C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600693A")]
	[Address(RVA = "0x317736C", Offset = "0x317736C", VA = "0x317736C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600693B")]
	[Address(RVA = "0x3177544", Offset = "0x3177544", VA = "0x3177544", Slot = "9")]
	public override void Recycle()
	{
	}

	[Token(Token = "0x600693C")]
	[Address(RVA = "0x317768C", Offset = "0x317768C", VA = "0x317768C", Slot = "8")]
	public override bool CanCache()
	{
		return default(bool);
	}
}
