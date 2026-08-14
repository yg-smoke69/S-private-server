using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D5C")]
public class AkAudioInterruptionCallbackInfo : _Attribute
{
	[Token(Token = "0x401A171")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A172")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A20")]
	public bool bEnterInterruption
	{
		[Token(Token = "0x6018E86")]
		[Address(RVA = "0x35C3C84", Offset = "0x35C3C84", VA = "0x35C3C84")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6018E80")]
	[Address(RVA = "0x35C399C", Offset = "0x35C399C", VA = "0x35C399C")]
	internal AkAudioInterruptionCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018E81")]
	[Address(RVA = "0x35C39C4", Offset = "0x35C39C4", VA = "0x35C39C4")]
	public AkAudioInterruptionCallbackInfo()
	{
	}

	[Token(Token = "0x6018E82")]
	[Address(RVA = "0x35C3A60", Offset = "0x35C3A60", VA = "0x35C3A60")]
	internal static IntPtr getCPtr(AkAudioInterruptionCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018E83")]
	[Address(RVA = "0x35C3AB8", Offset = "0x35C3AB8", VA = "0x35C3AB8", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018E84")]
	[Address(RVA = "0x35C3AE4", Offset = "0x35C3AE4", VA = "0x35C3AE4", Slot = "1")]
	~AkAudioInterruptionCallbackInfo()
	{
	}

	[Token(Token = "0x6018E85")]
	[Address(RVA = "0x35C3B58", Offset = "0x35C3B58", VA = "0x35C3B58", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
