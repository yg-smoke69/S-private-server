using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D5E")]
public class AkAudioSourceChangeCallbackInfo : _Attribute
{
	[Token(Token = "0x401A175")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A176")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A23")]
	public bool bOtherAudioPlaying
	{
		[Token(Token = "0x6018E97")]
		[Address(RVA = "0x35C5614", Offset = "0x35C5614", VA = "0x35C5614")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6018E91")]
	[Address(RVA = "0x35C532C", Offset = "0x35C532C", VA = "0x35C532C")]
	internal AkAudioSourceChangeCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018E92")]
	[Address(RVA = "0x35C5354", Offset = "0x35C5354", VA = "0x35C5354")]
	public AkAudioSourceChangeCallbackInfo()
	{
	}

	[Token(Token = "0x6018E93")]
	[Address(RVA = "0x35C53F0", Offset = "0x35C53F0", VA = "0x35C53F0")]
	internal static IntPtr getCPtr(AkAudioSourceChangeCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018E94")]
	[Address(RVA = "0x35C5448", Offset = "0x35C5448", VA = "0x35C5448", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018E95")]
	[Address(RVA = "0x35C5474", Offset = "0x35C5474", VA = "0x35C5474", Slot = "1")]
	~AkAudioSourceChangeCallbackInfo()
	{
	}

	[Token(Token = "0x6018E96")]
	[Address(RVA = "0x35C54E8", Offset = "0x35C54E8", VA = "0x35C54E8", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
