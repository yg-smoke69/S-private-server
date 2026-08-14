using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D8E")]
public class AkMonitoringCallbackInfo : _Attribute
{
	[Token(Token = "0x401A2DC")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A2DD")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001AB2")]
	public AkMonitorErrorCode errorCode
	{
		[Token(Token = "0x6019078")]
		[Address(RVA = "0x36B9D2C", Offset = "0x36B9D2C", VA = "0x36B9D2C")]
		get
		{
			return default(AkMonitorErrorCode);
		}
	}

	[Token(Token = "0x17001AB3")]
	public AkMonitorErrorLevel errorLevel
	{
		[Token(Token = "0x6019079")]
		[Address(RVA = "0x36B9DB4", Offset = "0x36B9DB4", VA = "0x36B9DB4")]
		get
		{
			return default(AkMonitorErrorLevel);
		}
	}

	[Token(Token = "0x17001AB4")]
	public uint playingID
	{
		[Token(Token = "0x601907A")]
		[Address(RVA = "0x36B9E3C", Offset = "0x36B9E3C", VA = "0x36B9E3C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001AB5")]
	public ulong gameObjID
	{
		[Token(Token = "0x601907B")]
		[Address(RVA = "0x36B9EC4", Offset = "0x36B9EC4", VA = "0x36B9EC4")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17001AB6")]
	public string message
	{
		[Token(Token = "0x601907C")]
		[Address(RVA = "0x36B9F4C", Offset = "0x36B9F4C", VA = "0x36B9F4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019072")]
	[Address(RVA = "0x36B9A44", Offset = "0x36B9A44", VA = "0x36B9A44")]
	internal AkMonitoringCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6019073")]
	[Address(RVA = "0x36B9A6C", Offset = "0x36B9A6C", VA = "0x36B9A6C")]
	public AkMonitoringCallbackInfo()
	{
	}

	[Token(Token = "0x6019074")]
	[Address(RVA = "0x36B9B08", Offset = "0x36B9B08", VA = "0x36B9B08")]
	internal static IntPtr getCPtr(AkMonitoringCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6019075")]
	[Address(RVA = "0x36B9B60", Offset = "0x36B9B60", VA = "0x36B9B60", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6019076")]
	[Address(RVA = "0x36B9B8C", Offset = "0x36B9B8C", VA = "0x36B9B8C", Slot = "1")]
	~AkMonitoringCallbackInfo()
	{
	}

	[Token(Token = "0x6019077")]
	[Address(RVA = "0x36B9C00", Offset = "0x36B9C00", VA = "0x36B9C00", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
