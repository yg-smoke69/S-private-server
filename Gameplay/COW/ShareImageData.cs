using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028DD")]
internal class ShareImageData
{
	[Token(Token = "0x400FB54")]
	[FieldOffset(Offset = "0x8")]
	public UIUtils.ScreenshotType ScreenshotType;

	[Token(Token = "0x400FB55")]
	[FieldOffset(Offset = "0xC")]
	public string FilePath;

	[Token(Token = "0x400FB56")]
	[FieldOffset(Offset = "0x10")]
	public UIUtils.EShareScreenType ShareScreenType;

	[Token(Token = "0x6010200")]
	[Address(RVA = "0x20E5444", Offset = "0x20E5444", VA = "0x20E5444")]
	public ShareImageData()
	{
	}
}
