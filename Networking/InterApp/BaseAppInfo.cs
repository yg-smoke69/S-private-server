using Il2CppDummyDll;

namespace InterApp;

[Token(Token = "0x2003EED")]
public class BaseAppInfo
{
	[Token(Token = "0x17001BFE")]
	public string URLScheme
	{
		[Token(Token = "0x6019A1E")]
		[Address(RVA = "0x310BB34", Offset = "0x310BB34", VA = "0x310BB34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BFF")]
	public string[] BundleIdentifiers
	{
		[Token(Token = "0x6019A1F")]
		[Address(RVA = "0x310BB44", Offset = "0x310BB44", VA = "0x310BB44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C00")]
	public virtual string URLScheme_iOS
	{
		[Token(Token = "0x6019A20")]
		[Address(RVA = "0x310BB54", Offset = "0x310BB54", VA = "0x310BB54", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C01")]
	public virtual string URLScheme_Android
	{
		[Token(Token = "0x6019A21")]
		[Address(RVA = "0x310BBE0", Offset = "0x310BBE0", VA = "0x310BBE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C02")]
	public virtual string[] BundleIdentifiers_iOS
	{
		[Token(Token = "0x6019A22")]
		[Address(RVA = "0x310BC6C", Offset = "0x310BC6C", VA = "0x310BC6C", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C03")]
	public virtual string[] BundleIdentifiers_Android
	{
		[Token(Token = "0x6019A23")]
		[Address(RVA = "0x310BCCC", Offset = "0x310BCCC", VA = "0x310BCCC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019A1D")]
	[Address(RVA = "0x310BB2C", Offset = "0x310BB2C", VA = "0x310BB2C")]
	public BaseAppInfo()
	{
	}

	[Token(Token = "0x6019A24")]
	[Address(RVA = "0x310BD2C", Offset = "0x310BD2C", VA = "0x310BD2C", Slot = "8")]
	public virtual bool CanLaunch()
	{
		return default(bool);
	}

	[Token(Token = "0x6019A25")]
	[Address(RVA = "0x310BE7C", Offset = "0x310BE7C", VA = "0x310BE7C", Slot = "9")]
	public virtual void Launch()
	{
	}

	[Token(Token = "0x6019A26")]
	[Address(RVA = "0x310BF4C", Offset = "0x310BF4C", VA = "0x310BF4C", Slot = "10")]
	public virtual bool CanShareText()
	{
		return default(bool);
	}

	[Token(Token = "0x6019A27")]
	[Address(RVA = "0x310BF54", Offset = "0x310BF54", VA = "0x310BF54", Slot = "11")]
	public virtual void ShareText(string text)
	{
	}

	[Token(Token = "0x6019A28")]
	[Address(RVA = "0x310BF58", Offset = "0x310BF58", VA = "0x310BF58", Slot = "12")]
	public virtual bool CanShareImage()
	{
		return default(bool);
	}

	[Token(Token = "0x6019A29")]
	[Address(RVA = "0x310BF60", Offset = "0x310BF60", VA = "0x310BF60", Slot = "13")]
	public virtual void ShareImage(string filePath)
	{
	}
}
