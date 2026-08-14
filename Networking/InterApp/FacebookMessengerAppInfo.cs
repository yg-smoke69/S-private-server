using Il2CppDummyDll;

namespace InterApp;

[Token(Token = "0x2003EEF")]
public class FacebookMessengerAppInfo : BaseAppInfo
{
	[Token(Token = "0x17001C07")]
	public override string URLScheme_iOS
	{
		[Token(Token = "0x6019A31")]
		[Address(RVA = "0x310C128", Offset = "0x310C128", VA = "0x310C128", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C08")]
	public override string URLScheme_Android
	{
		[Token(Token = "0x6019A32")]
		[Address(RVA = "0x310C184", Offset = "0x310C184", VA = "0x310C184", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C09")]
	public override string[] BundleIdentifiers_Android
	{
		[Token(Token = "0x6019A33")]
		[Address(RVA = "0x310C1E0", Offset = "0x310C1E0", VA = "0x310C1E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019A30")]
	[Address(RVA = "0x310C120", Offset = "0x310C120", VA = "0x310C120")]
	public FacebookMessengerAppInfo()
	{
	}

	[Token(Token = "0x6019A34")]
	[Address(RVA = "0x310C2C4", Offset = "0x310C2C4", VA = "0x310C2C4", Slot = "10")]
	public override bool CanShareText()
	{
		return default(bool);
	}

	[Token(Token = "0x6019A35")]
	[Address(RVA = "0x310C2D4", Offset = "0x310C2D4", VA = "0x310C2D4", Slot = "12")]
	public override bool CanShareImage()
	{
		return default(bool);
	}
}
