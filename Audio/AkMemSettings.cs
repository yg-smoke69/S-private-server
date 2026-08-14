using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D7E")]
public class AkMemSettings : _Attribute
{
	[Token(Token = "0x401A1F1")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A1F2")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A82")]
	public uint uMaxNumPools
	{
		[Token(Token = "0x6018FE2")]
		[Address(RVA = "0x36B98A4", Offset = "0x36B98A4", VA = "0x36B98A4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018FE1")]
		[Address(RVA = "0x36B9814", Offset = "0x36B9814", VA = "0x36B9814")]
		set
		{
		}
	}

	[Token(Token = "0x17001A83")]
	public uint uDebugFlags
	{
		[Token(Token = "0x6018FE4")]
		[Address(RVA = "0x36B99BC", Offset = "0x36B99BC", VA = "0x36B99BC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018FE3")]
		[Address(RVA = "0x36B992C", Offset = "0x36B992C", VA = "0x36B992C")]
		set
		{
		}
	}

	[Token(Token = "0x6018FDB")]
	[Address(RVA = "0x36B0164", Offset = "0x36B0164", VA = "0x36B0164")]
	internal AkMemSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018FDC")]
	[Address(RVA = "0x36B95AC", Offset = "0x36B95AC", VA = "0x36B95AC")]
	public AkMemSettings()
	{
	}

	[Token(Token = "0x6018FDD")]
	[Address(RVA = "0x36B0038", Offset = "0x36B0038", VA = "0x36B0038")]
	internal static IntPtr getCPtr(AkMemSettings obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018FDE")]
	[Address(RVA = "0x36B9648", Offset = "0x36B9648", VA = "0x36B9648", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018FDF")]
	[Address(RVA = "0x36B9674", Offset = "0x36B9674", VA = "0x36B9674", Slot = "1")]
	~AkMemSettings()
	{
	}

	[Token(Token = "0x6018FE0")]
	[Address(RVA = "0x36B96E8", Offset = "0x36B96E8", VA = "0x36B96E8", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
