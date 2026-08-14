using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D97")]
public class AkPathParams : _Attribute
{
	[Token(Token = "0x401A2EF")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A2F0")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001AD1")]
	public AkVector listenerPos
	{
		[Token(Token = "0x60190D6")]
		[Address(RVA = "0x36BE3F4", Offset = "0x36BE3F4", VA = "0x36BE3F4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60190D5")]
		[Address(RVA = "0x36BE354", Offset = "0x36BE354", VA = "0x36BE354")]
		set
		{
		}
	}

	[Token(Token = "0x17001AD2")]
	public AkVector emitterPos
	{
		[Token(Token = "0x60190D8")]
		[Address(RVA = "0x36BE564", Offset = "0x36BE564", VA = "0x36BE564")]
		get
		{
			return null;
		}
		[Token(Token = "0x60190D7")]
		[Address(RVA = "0x36BE4C4", Offset = "0x36BE4C4", VA = "0x36BE4C4")]
		set
		{
		}
	}

	[Token(Token = "0x17001AD3")]
	public uint numValidPaths
	{
		[Token(Token = "0x60190DA")]
		[Address(RVA = "0x36BE6C4", Offset = "0x36BE6C4", VA = "0x36BE6C4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60190D9")]
		[Address(RVA = "0x36BE634", Offset = "0x36BE634", VA = "0x36BE634")]
		set
		{
		}
	}

	[Token(Token = "0x60190CF")]
	[Address(RVA = "0x36BE06C", Offset = "0x36BE06C", VA = "0x36BE06C")]
	internal AkPathParams(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x60190D0")]
	[Address(RVA = "0x36BE094", Offset = "0x36BE094", VA = "0x36BE094")]
	public AkPathParams()
	{
	}

	[Token(Token = "0x60190D1")]
	[Address(RVA = "0x36BE130", Offset = "0x36BE130", VA = "0x36BE130")]
	internal static IntPtr getCPtr(AkPathParams obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60190D2")]
	[Address(RVA = "0x36BE188", Offset = "0x36BE188", VA = "0x36BE188", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60190D3")]
	[Address(RVA = "0x36BE1B4", Offset = "0x36BE1B4", VA = "0x36BE1B4", Slot = "1")]
	~AkPathParams()
	{
	}

	[Token(Token = "0x60190D4")]
	[Address(RVA = "0x36BE228", Offset = "0x36BE228", VA = "0x36BE228", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
