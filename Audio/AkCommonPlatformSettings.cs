using Il2CppDummyDll;

[Token(Token = "0x2003DD2")]
public abstract class AkCommonPlatformSettings : AkBasePlatformSettings
{
	[Token(Token = "0x17001B23")]
	public override AkInitializationSettings AkInitializationSettings
	{
		[Token(Token = "0x6019294")]
		[Address(RVA = "0x35D07B4", Offset = "0x35D07B4", VA = "0x35D07B4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B24")]
	public override AkSpatialAudioInitSettings AkSpatialAudioInitSettings
	{
		[Token(Token = "0x6019295")]
		[Address(RVA = "0x35D0B9C", Offset = "0x35D0B9C", VA = "0x35D0B9C", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B25")]
	public override AkCallbackManager.InitializationSettings CallbackManagerInitializationSettings
	{
		[Token(Token = "0x6019296")]
		[Address(RVA = "0x35D0C38", Offset = "0x35D0C38", VA = "0x35D0C38", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B26")]
	public override string InitialLanguage
	{
		[Token(Token = "0x6019297")]
		[Address(RVA = "0x35D0D04", Offset = "0x35D0D04", VA = "0x35D0D04", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B27")]
	public override bool RenderDuringFocusLoss
	{
		[Token(Token = "0x6019298")]
		[Address(RVA = "0x35D0D38", Offset = "0x35D0D38", VA = "0x35D0D38", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B28")]
	public override string SoundbankPath
	{
		[Token(Token = "0x6019299")]
		[Address(RVA = "0x35D0D6C", Offset = "0x35D0D6C", VA = "0x35D0D6C", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B29")]
	public override bool UseAsyncOpen
	{
		[Token(Token = "0x601929A")]
		[Address(RVA = "0x35D0DA0", Offset = "0x35D0DA0", VA = "0x35D0DA0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B2A")]
	public override AkCommunicationSettings AkCommunicationSettings
	{
		[Token(Token = "0x601929B")]
		[Address(RVA = "0x35D0DD4", Offset = "0x35D0DD4", VA = "0x35D0DD4", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019290")]
	[Address(RVA = "0x35D07AC", Offset = "0x35D07AC", VA = "0x35D07AC")]
	protected AkCommonPlatformSettings()
	{
	}

	[Token(Token = "0x6019291")]
	protected abstract AkCommonUserSettings GetUserSettings();

	[Token(Token = "0x6019292")]
	protected abstract AkCommonAdvancedSettings GetAdvancedSettings();

	[Token(Token = "0x6019293")]
	protected abstract AkCommonCommSettings GetCommsSettings();
}
