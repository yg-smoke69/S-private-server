using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000ED7")]
internal class FDODENEJAEI : UDPClientMessageBase
{
	[Token(Token = "0x4007884")]
	[FieldOffset(Offset = "0xC")]
	public List<IGGJJLFFJKB> CLICCKIPIBM;

	[Token(Token = "0x4007885")]
	[FieldOffset(Offset = "0x10")]
	public uint CEDJCPLOLNE;

	[Token(Token = "0x600693D")]
	[Address(RVA = "0x3631684", Offset = "0x3631684", VA = "0x3631684")]
	public FDODENEJAEI()
	{
	}

	[Token(Token = "0x600693E")]
	[Address(RVA = "0x3631708", Offset = "0x3631708", VA = "0x3631708", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600693F")]
	[Address(RVA = "0x3631928", Offset = "0x3631928", VA = "0x3631928", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006940")]
	[Address(RVA = "0x3631B00", Offset = "0x3631B00", VA = "0x3631B00", Slot = "9")]
	public override void Recycle()
	{
	}

	[Token(Token = "0x6006941")]
	[Address(RVA = "0x3631C48", Offset = "0x3631C48", VA = "0x3631C48", Slot = "8")]
	public override bool CanCache()
	{
		return default(bool);
	}
}
