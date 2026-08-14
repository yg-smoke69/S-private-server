using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D7A")]
public class AkInitializationSettings : _Attribute
{
	[Token(Token = "0x401A1EA")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A1EB")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A63")]
	public AkMemSettings memSettings
	{
		[Token(Token = "0x6018F8A")]
		[Address(RVA = "0x36B0090", Offset = "0x36B0090", VA = "0x36B0090")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018F89")]
		[Address(RVA = "0x36AFF60", Offset = "0x36AFF60", VA = "0x36AFF60")]
		set
		{
		}
	}

	[Token(Token = "0x17001A64")]
	public AkStreamMgrSettings streamMgrSettings
	{
		[Token(Token = "0x6018F8C")]
		[Address(RVA = "0x36B022C", Offset = "0x36B022C", VA = "0x36B022C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018F8B")]
		[Address(RVA = "0x36B018C", Offset = "0x36B018C", VA = "0x36B018C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A65")]
	public AkDeviceSettings deviceSettings
	{
		[Token(Token = "0x6018F8E")]
		[Address(RVA = "0x36B039C", Offset = "0x36B039C", VA = "0x36B039C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018F8D")]
		[Address(RVA = "0x36B02FC", Offset = "0x36B02FC", VA = "0x36B02FC")]
		set
		{
		}
	}

	[Token(Token = "0x17001A66")]
	public AkInitSettings initSettings
	{
		[Token(Token = "0x6018F90")]
		[Address(RVA = "0x36B0544", Offset = "0x36B0544", VA = "0x36B0544")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018F8F")]
		[Address(RVA = "0x36B046C", Offset = "0x36B046C", VA = "0x36B046C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A67")]
	public AkPlatformInitSettings platformSettings
	{
		[Token(Token = "0x6018F92")]
		[Address(RVA = "0x36B0748", Offset = "0x36B0748", VA = "0x36B0748")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018F91")]
		[Address(RVA = "0x36B0618", Offset = "0x36B0618", VA = "0x36B0618")]
		set
		{
		}
	}

	[Token(Token = "0x17001A68")]
	public AkMusicSettings musicSettings
	{
		[Token(Token = "0x6018F94")]
		[Address(RVA = "0x36B0974", Offset = "0x36B0974", VA = "0x36B0974")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018F93")]
		[Address(RVA = "0x36B0844", Offset = "0x36B0844", VA = "0x36B0844")]
		set
		{
		}
	}

	[Token(Token = "0x17001A69")]
	public uint preparePoolSize
	{
		[Token(Token = "0x6018F96")]
		[Address(RVA = "0x36B0B00", Offset = "0x36B0B00", VA = "0x36B0B00")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018F95")]
		[Address(RVA = "0x36B0A70", Offset = "0x36B0A70", VA = "0x36B0A70")]
		set
		{
		}
	}

	[Token(Token = "0x17001A6A")]
	public AkUnityPlatformSpecificSettings unityPlatformSpecificSettings
	{
		[Token(Token = "0x6018F98")]
		[Address(RVA = "0x36B0C28", Offset = "0x36B0C28", VA = "0x36B0C28")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018F97")]
		[Address(RVA = "0x36B0B88", Offset = "0x36B0B88", VA = "0x36B0B88")]
		set
		{
		}
	}

	[Token(Token = "0x17001A6B")]
	public bool useAsyncOpen
	{
		[Token(Token = "0x6018F9A")]
		[Address(RVA = "0x36B0D88", Offset = "0x36B0D88", VA = "0x36B0D88")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6018F99")]
		[Address(RVA = "0x36B0CF8", Offset = "0x36B0CF8", VA = "0x36B0CF8")]
		set
		{
		}
	}

	[Token(Token = "0x6018F83")]
	[Address(RVA = "0x36AFC78", Offset = "0x36AFC78", VA = "0x36AFC78")]
	internal AkInitializationSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018F84")]
	[Address(RVA = "0x36AFCA0", Offset = "0x36AFCA0", VA = "0x36AFCA0")]
	public AkInitializationSettings()
	{
	}

	[Token(Token = "0x6018F85")]
	[Address(RVA = "0x36AFD3C", Offset = "0x36AFD3C", VA = "0x36AFD3C")]
	internal static IntPtr getCPtr(AkInitializationSettings obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018F86")]
	[Address(RVA = "0x36AFD94", Offset = "0x36AFD94", VA = "0x36AFD94", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018F87")]
	[Address(RVA = "0x36AFDC0", Offset = "0x36AFDC0", VA = "0x36AFDC0", Slot = "1")]
	~AkInitializationSettings()
	{
	}

	[Token(Token = "0x6018F88")]
	[Address(RVA = "0x36AFE34", Offset = "0x36AFE34", VA = "0x36AFE34", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
