using Il2CppDummyDll;

namespace InterApp;

[Token(Token = "0x2003EF6")]
public class LineAppInfo : BaseAppInfo
{
	[Token(Token = "0x17001C0B")]
	public override string URLScheme_iOS
	{
		[Token(Token = "0x6019A47")]
		[Address(RVA = "0x310D7FC", Offset = "0x310D7FC", VA = "0x310D7FC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C0C")]
	public override string URLScheme_Android
	{
		[Token(Token = "0x6019A48")]
		[Address(RVA = "0x310D858", Offset = "0x310D858", VA = "0x310D858", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C0D")]
	public override string[] BundleIdentifiers_Android
	{
		[Token(Token = "0x6019A49")]
		[Address(RVA = "0x310D8B4", Offset = "0x310D8B4", VA = "0x310D8B4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019A46")]
	[Address(RVA = "0x310D7A8", Offset = "0x310D7A8", VA = "0x310D7A8")]
	public LineAppInfo()
	{
	}

	[Token(Token = "0x6019A4A")]
	[Address(RVA = "0x310D998", Offset = "0x310D998", VA = "0x310D998", Slot = "10")]
	public override bool CanShareText()
	{
		return default(bool);
	}

	[Token(Token = "0x6019A4B")]
	[Address(RVA = "0x310D9A8", Offset = "0x310D9A8", VA = "0x310D9A8", Slot = "11")]
	public override void ShareText(string text)
	{
	}

	[Token(Token = "0x6019A4C")]
	[Address(RVA = "0x310DBC4", Offset = "0x310DBC4", VA = "0x310DBC4", Slot = "12")]
	public override bool CanShareImage()
	{
		return default(bool);
	}

	[Token(Token = "0x6019A4D")]
	[Address(RVA = "0x310DBD4", Offset = "0x310DBD4", VA = "0x310DBD4", Slot = "13")]
	public override void ShareImage(string filePath)
	{
	}
}
