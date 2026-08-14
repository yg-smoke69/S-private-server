using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002EA7")]
public class AnnoucementInfo : _Attribute
{
	[Token(Token = "0x4011CF6")]
	[FieldOffset(Offset = "0x8")]
	public AnnouncementDesc Data;

	[Token(Token = "0x4011CF7")]
	[FieldOffset(Offset = "0xC")]
	public EEventTag EventTagType;

	[Token(Token = "0x60137FC")]
	[Address(RVA = "0x14C7C2C", Offset = "0x14C7C2C", VA = "0x14C7C2C")]
	public AnnoucementInfo()
	{
	}

	[Token(Token = "0x60137FD")]
	[Address(RVA = "0x14C7CB0", Offset = "0x14C7CB0", VA = "0x14C7CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60137FE")]
	[Address(RVA = "0x14C7D14", Offset = "0x14C7D14", VA = "0x14C7D14", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60137FF")]
	[Address(RVA = "0x14C7E54", Offset = "0x14C7E54", VA = "0x14C7E54", Slot = "4")]
	public int CompareTo(AnnoucementInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x6013800")]
	[Address(RVA = "0x14C8024", Offset = "0x14C8024", VA = "0x14C8024")]
	public static implicit operator AnnoucementInfo(AnnouncementDesc data)
	{
		return null;
	}

	[Token(Token = "0x6013801")]
	[Address(RVA = "0x14C80F4", Offset = "0x14C80F4", VA = "0x14C80F4")]
	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6013802")]
	[Address(RVA = "0x14C80FC", Offset = "0x14C80FC", VA = "0x14C80FC")]
	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return default(bool);
	}
}
