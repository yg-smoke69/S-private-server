using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003DC5")]
public class AkBasePlatformSettings : ScriptableObject
{
	[Token(Token = "0x17001B1B")]
	public virtual AkInitializationSettings AkInitializationSettings
	{
		[Token(Token = "0x601926B")]
		[Address(RVA = "0x35C95E8", Offset = "0x35C95E8", VA = "0x35C95E8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B1C")]
	public virtual AkSpatialAudioInitSettings AkSpatialAudioInitSettings
	{
		[Token(Token = "0x601926C")]
		[Address(RVA = "0x35C9654", Offset = "0x35C9654", VA = "0x35C9654", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B1D")]
	public virtual AkCallbackManager.InitializationSettings CallbackManagerInitializationSettings
	{
		[Token(Token = "0x601926D")]
		[Address(RVA = "0x35C96C0", Offset = "0x35C96C0", VA = "0x35C96C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B1E")]
	public virtual string InitialLanguage
	{
		[Token(Token = "0x601926E")]
		[Address(RVA = "0x35C97D4", Offset = "0x35C97D4", VA = "0x35C97D4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B1F")]
	public virtual bool RenderDuringFocusLoss
	{
		[Token(Token = "0x601926F")]
		[Address(RVA = "0x35C9830", Offset = "0x35C9830", VA = "0x35C9830", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B20")]
	public virtual string SoundbankPath
	{
		[Token(Token = "0x6019270")]
		[Address(RVA = "0x35C9838", Offset = "0x35C9838", VA = "0x35C9838", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B21")]
	public virtual AkCommunicationSettings AkCommunicationSettings
	{
		[Token(Token = "0x6019271")]
		[Address(RVA = "0x35C98C4", Offset = "0x35C98C4", VA = "0x35C98C4", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B22")]
	public virtual bool UseAsyncOpen
	{
		[Token(Token = "0x6019272")]
		[Address(RVA = "0x35C99C8", Offset = "0x35C99C8", VA = "0x35C99C8", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601926A")]
	[Address(RVA = "0x35C95E0", Offset = "0x35C95E0", VA = "0x35C95E0")]
	public AkBasePlatformSettings()
	{
	}
}
