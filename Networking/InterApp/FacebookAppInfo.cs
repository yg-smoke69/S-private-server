using Il2CppDummyDll;

namespace InterApp;

[Token(Token = "0x2003EEE")]
public class FacebookAppInfo : BaseAppInfo
{
	[Token(Token = "0x17001C04")]
	public override string URLScheme_iOS
	{
		[Token(Token = "0x6019A2B")]
		[Address(RVA = "0x310BF6C", Offset = "0x310BF6C", VA = "0x310BF6C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C05")]
	public override string URLScheme_Android
	{
		[Token(Token = "0x6019A2C")]
		[Address(RVA = "0x310BFC8", Offset = "0x310BFC8", VA = "0x310BFC8", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C06")]
	public override string[] BundleIdentifiers_Android
	{
		[Token(Token = "0x6019A2D")]
		[Address(RVA = "0x310C024", Offset = "0x310C024", VA = "0x310C024", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019A2A")]
	[Address(RVA = "0x310BF64", Offset = "0x310BF64", VA = "0x310BF64")]
	public FacebookAppInfo()
	{
	}

	[Token(Token = "0x6019A2E")]
	[Address(RVA = "0x310C108", Offset = "0x310C108", VA = "0x310C108", Slot = "10")]
	public override bool CanShareText()
	{
		return default(bool);
	}

	[Token(Token = "0x6019A2F")]
	[Address(RVA = "0x310C118", Offset = "0x310C118", VA = "0x310C118", Slot = "12")]
	public override bool CanShareImage()
	{
		return default(bool);
	}
}
