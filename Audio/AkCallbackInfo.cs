using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D63")]
public class AkCallbackInfo : _Attribute
{
	[Token(Token = "0x401A182")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A183")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A2B")]
	public IntPtr pCookie
	{
		[Token(Token = "0x6018EB6")]
		[Address(RVA = "0x35C9CB8", Offset = "0x35C9CB8", VA = "0x35C9CB8")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17001A2C")]
	public ulong gameObjID
	{
		[Token(Token = "0x6018EB7")]
		[Address(RVA = "0x35C9D40", Offset = "0x35C9D40", VA = "0x35C9D40")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x6018EB0")]
	[Address(RVA = "0x35C99D0", Offset = "0x35C99D0", VA = "0x35C99D0")]
	internal AkCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018EB1")]
	[Address(RVA = "0x35C99F8", Offset = "0x35C99F8", VA = "0x35C99F8")]
	public AkCallbackInfo()
	{
	}

	[Token(Token = "0x6018EB2")]
	[Address(RVA = "0x35C9A94", Offset = "0x35C9A94", VA = "0x35C9A94")]
	internal static IntPtr getCPtr(AkCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018EB3")]
	[Address(RVA = "0x35C9AEC", Offset = "0x35C9AEC", VA = "0x35C9AEC", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018EB4")]
	[Address(RVA = "0x35C9B18", Offset = "0x35C9B18", VA = "0x35C9B18", Slot = "1")]
	~AkCallbackInfo()
	{
	}

	[Token(Token = "0x6018EB5")]
	[Address(RVA = "0x35C9B8C", Offset = "0x35C9B8C", VA = "0x35C9B8C", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
