using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003DA4")]
public class AkSerializedCallbackHeader : _Attribute
{
	[Token(Token = "0x401A353")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A354")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001B00")]
	public IntPtr pPackage
	{
		[Token(Token = "0x6019193")]
		[Address(RVA = "0x36CB2B8", Offset = "0x36CB2B8", VA = "0x36CB2B8")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17001B01")]
	public AkSerializedCallbackHeader pNext
	{
		[Token(Token = "0x6019194")]
		[Address(RVA = "0x36CB340", Offset = "0x36CB340", VA = "0x36CB340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B02")]
	public AkCallbackType eType
	{
		[Token(Token = "0x6019195")]
		[Address(RVA = "0x36CB414", Offset = "0x36CB414", VA = "0x36CB414")]
		get
		{
			return default(AkCallbackType);
		}
	}

	[Token(Token = "0x601918D")]
	[Address(RVA = "0x36CAFD0", Offset = "0x36CAFD0", VA = "0x36CAFD0")]
	internal AkSerializedCallbackHeader(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x601918E")]
	[Address(RVA = "0x36CAFF8", Offset = "0x36CAFF8", VA = "0x36CAFF8")]
	public AkSerializedCallbackHeader()
	{
	}

	[Token(Token = "0x601918F")]
	[Address(RVA = "0x36CB094", Offset = "0x36CB094", VA = "0x36CB094")]
	internal static IntPtr getCPtr(AkSerializedCallbackHeader obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6019190")]
	[Address(RVA = "0x36CB0EC", Offset = "0x36CB0EC", VA = "0x36CB0EC", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6019191")]
	[Address(RVA = "0x36CB118", Offset = "0x36CB118", VA = "0x36CB118", Slot = "1")]
	~AkSerializedCallbackHeader()
	{
	}

	[Token(Token = "0x6019192")]
	[Address(RVA = "0x36CB18C", Offset = "0x36CB18C", VA = "0x36CB18C", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6019196")]
	[Address(RVA = "0x36CB49C", Offset = "0x36CB49C", VA = "0x36CB49C")]
	public IntPtr GetData()
	{
		return default(IntPtr);
	}
}
