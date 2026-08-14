using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20011FD")]
internal class KAFPFFOPDIM : UDPClientMessageBase
{
	[Token(Token = "0x4008033")]
	[FieldOffset(Offset = "0xC")]
	public List<CKJFOOMOBCI> CELKOEBHKLM;

	[Token(Token = "0x4008034")]
	[FieldOffset(Offset = "0x10")]
	public List<AHIGEGEHPFP> CDDLPAGIFFH;

	[Token(Token = "0x60075DA")]
	[Address(RVA = "0x36860C8", Offset = "0x36860C8", VA = "0x36860C8")]
	public KAFPFFOPDIM()
	{
	}

	[Token(Token = "0x60075DB")]
	[Address(RVA = "0x368614C", Offset = "0x368614C", VA = "0x368614C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60075DC")]
	[Address(RVA = "0x36864B4", Offset = "0x36864B4", VA = "0x36864B4", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60075DD")]
	[Address(RVA = "0x36867B8", Offset = "0x36867B8", VA = "0x36867B8", Slot = "9")]
	public override void Recycle()
	{
	}
}
