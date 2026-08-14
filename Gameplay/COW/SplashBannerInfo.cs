using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200326F")]
public class SplashBannerInfo
{
	[Token(Token = "0x401330E")]
	[FieldOffset(Offset = "0x8")]
	public uint Id;

	[Token(Token = "0x401330F")]
	[FieldOffset(Offset = "0xC")]
	public uint Type;

	[Token(Token = "0x4013310")]
	[FieldOffset(Offset = "0x10")]
	public string Name;

	[Token(Token = "0x4013311")]
	[FieldOffset(Offset = "0x14")]
	public uint SortId;

	[Token(Token = "0x4013312")]
	[FieldOffset(Offset = "0x18")]
	public string ImageUrl;

	[Token(Token = "0x4013313")]
	[FieldOffset(Offset = "0x1C")]
	public uint GosPos;

	[Token(Token = "0x4013314")]
	[FieldOffset(Offset = "0x20")]
	public string GosUrl;

	[Token(Token = "0x4013315")]
	[FieldOffset(Offset = "0x24")]
	public bool UseEmbeddedBrowser;

	[Token(Token = "0x4013316")]
	[FieldOffset(Offset = "0x28")]
	public string SubGoPos;

	[Token(Token = "0x4013317")]
	[FieldOffset(Offset = "0x2C")]
	public string VideoUrl;

	[Token(Token = "0x4013318")]
	[FieldOffset(Offset = "0x30")]
	public string BGImgUrl;

	[Token(Token = "0x4013319")]
	[FieldOffset(Offset = "0x34")]
	public EAnnouncement.Platform Platform;

	[Token(Token = "0x401331A")]
	[FieldOffset(Offset = "0x38")]
	public bool Showed;

	[Token(Token = "0x401331B")]
	[FieldOffset(Offset = "0x3C")]
	public uint dynamicid;

	[Token(Token = "0x401331C")]
	[FieldOffset(Offset = "0x40")]
	public float dynamicsize;

	[Token(Token = "0x6015450")]
	[Address(RVA = "0x288DEFC", Offset = "0x288DEFC", VA = "0x288DEFC")]
	public SplashBannerInfo()
	{
	}

	[Token(Token = "0x6015451")]
	[Address(RVA = "0x288DF04", Offset = "0x288DF04", VA = "0x288DF04")]
	public static implicit operator SplashBannerInfo(SplashBannerDesc data)
	{
		return null;
	}
}
