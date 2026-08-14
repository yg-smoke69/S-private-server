using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F03")]
internal class NIPFBIIPAPD : UDPClientMessageBase
{
	[Token(Token = "0x4007948")]
	[FieldOffset(Offset = "0xC")]
	public uint DGLCOGJJFMI;

	[Token(Token = "0x4007949")]
	[FieldOffset(Offset = "0x10")]
	public uint HFPGENNDGME;

	[Token(Token = "0x60069F0")]
	[Address(RVA = "0x3647B80", Offset = "0x3647B80", VA = "0x3647B80")]
	public NIPFBIIPAPD()
	{
	}

	[Token(Token = "0x60069F1")]
	[Address(RVA = "0x3647C04", Offset = "0x3647C04", VA = "0x3647C04", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60069F2")]
	[Address(RVA = "0x3647C90", Offset = "0x3647C90", VA = "0x3647C90", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60069F3")]
	[Address(RVA = "0x3647CC4", Offset = "0x3647CC4", VA = "0x3647CC4", Slot = "9")]
	public override void Recycle()
	{
	}
}
