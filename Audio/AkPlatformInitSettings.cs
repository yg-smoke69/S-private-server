using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D4C")]
public class AkPlatformInitSettings : _Attribute
{
	[Token(Token = "0x4019FF5")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x4019FF6")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x170019F5")]
	public AkThreadProperties threadLEngine
	{
		[Token(Token = "0x6018852")]
		[Address(RVA = "0x36BEA54", Offset = "0x36BEA54", VA = "0x36BEA54")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018851")]
		[Address(RVA = "0x36BE9B4", Offset = "0x36BE9B4", VA = "0x36BE9B4")]
		set
		{
		}
	}

	[Token(Token = "0x170019F6")]
	public AkThreadProperties threadOutputMgr
	{
		[Token(Token = "0x6018854")]
		[Address(RVA = "0x36BEBC4", Offset = "0x36BEBC4", VA = "0x36BEBC4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018853")]
		[Address(RVA = "0x36BEB24", Offset = "0x36BEB24", VA = "0x36BEB24")]
		set
		{
		}
	}

	[Token(Token = "0x170019F7")]
	public AkThreadProperties threadBankManager
	{
		[Token(Token = "0x6018856")]
		[Address(RVA = "0x36BED34", Offset = "0x36BED34", VA = "0x36BED34")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018855")]
		[Address(RVA = "0x36BEC94", Offset = "0x36BEC94", VA = "0x36BEC94")]
		set
		{
		}
	}

	[Token(Token = "0x170019F8")]
	public AkThreadProperties threadMonitor
	{
		[Token(Token = "0x6018858")]
		[Address(RVA = "0x36BEEA4", Offset = "0x36BEEA4", VA = "0x36BEEA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018857")]
		[Address(RVA = "0x36BEE04", Offset = "0x36BEE04", VA = "0x36BEE04")]
		set
		{
		}
	}

	[Token(Token = "0x170019F9")]
	public float fLEngineDefaultPoolRatioThreshold
	{
		[Token(Token = "0x601885A")]
		[Address(RVA = "0x36BF004", Offset = "0x36BF004", VA = "0x36BF004")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6018859")]
		[Address(RVA = "0x36BEF74", Offset = "0x36BEF74", VA = "0x36BEF74")]
		set
		{
		}
	}

	[Token(Token = "0x170019FA")]
	public uint uLEngineDefaultPoolSize
	{
		[Token(Token = "0x601885C")]
		[Address(RVA = "0x36BF11C", Offset = "0x36BF11C", VA = "0x36BF11C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601885B")]
		[Address(RVA = "0x36BF08C", Offset = "0x36BF08C", VA = "0x36BF08C")]
		set
		{
		}
	}

	[Token(Token = "0x170019FB")]
	public AkAudioAPI eAudioAPI
	{
		[Token(Token = "0x601885E")]
		[Address(RVA = "0x36BF234", Offset = "0x36BF234", VA = "0x36BF234")]
		get
		{
			return default(AkAudioAPI);
		}
		[Token(Token = "0x601885D")]
		[Address(RVA = "0x36BF1A4", Offset = "0x36BF1A4", VA = "0x36BF1A4")]
		set
		{
		}
	}

	[Token(Token = "0x170019FC")]
	public uint uSampleRate
	{
		[Token(Token = "0x6018860")]
		[Address(RVA = "0x36BF34C", Offset = "0x36BF34C", VA = "0x36BF34C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601885F")]
		[Address(RVA = "0x36BF2BC", Offset = "0x36BF2BC", VA = "0x36BF2BC")]
		set
		{
		}
	}

	[Token(Token = "0x170019FD")]
	public ushort uNumRefillsInVoice
	{
		[Token(Token = "0x6018862")]
		[Address(RVA = "0x36BF464", Offset = "0x36BF464", VA = "0x36BF464")]
		get
		{
			return default(ushort);
		}
		[Token(Token = "0x6018861")]
		[Address(RVA = "0x36BF3D4", Offset = "0x36BF3D4", VA = "0x36BF3D4")]
		set
		{
		}
	}

	[Token(Token = "0x170019FE")]
	public uint uChannelMask
	{
		[Token(Token = "0x6018864")]
		[Address(RVA = "0x36BF57C", Offset = "0x36BF57C", VA = "0x36BF57C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018863")]
		[Address(RVA = "0x36BF4EC", Offset = "0x36BF4EC", VA = "0x36BF4EC")]
		set
		{
		}
	}

	[Token(Token = "0x170019FF")]
	public bool bRoundFrameSizeToHWSize
	{
		[Token(Token = "0x6018866")]
		[Address(RVA = "0x36BF694", Offset = "0x36BF694", VA = "0x36BF694")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6018865")]
		[Address(RVA = "0x36BF604", Offset = "0x36BF604", VA = "0x36BF604")]
		set
		{
		}
	}

	[Token(Token = "0x601884B")]
	[Address(RVA = "0x36B081C", Offset = "0x36B081C", VA = "0x36B081C")]
	internal AkPlatformInitSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x601884C")]
	[Address(RVA = "0x36BE74C", Offset = "0x36BE74C", VA = "0x36BE74C")]
	public AkPlatformInitSettings()
	{
	}

	[Token(Token = "0x601884D")]
	[Address(RVA = "0x36B06F0", Offset = "0x36B06F0", VA = "0x36B06F0")]
	internal static IntPtr getCPtr(AkPlatformInitSettings obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x601884E")]
	[Address(RVA = "0x36BE7E8", Offset = "0x36BE7E8", VA = "0x36BE7E8", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x601884F")]
	[Address(RVA = "0x36BE814", Offset = "0x36BE814", VA = "0x36BE814", Slot = "1")]
	~AkPlatformInitSettings()
	{
	}

	[Token(Token = "0x6018850")]
	[Address(RVA = "0x36BE888", Offset = "0x36BE888", VA = "0x36BE888", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
