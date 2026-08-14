using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003DA6")]
public class AkSourceSettings : _Attribute
{
	[Token(Token = "0x401A359")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A35A")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001B03")]
	public uint sourceID
	{
		[Token(Token = "0x601919E")]
		[Address(RVA = "0x2EB6308", Offset = "0x2EB6308", VA = "0x2EB6308")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601919D")]
		[Address(RVA = "0x2EB6278", Offset = "0x2EB6278", VA = "0x2EB6278")]
		set
		{
		}
	}

	[Token(Token = "0x17001B04")]
	public IntPtr pMediaMemory
	{
		[Token(Token = "0x60191A0")]
		[Address(RVA = "0x2EB6420", Offset = "0x2EB6420", VA = "0x2EB6420")]
		get
		{
			return default(IntPtr);
		}
		[Token(Token = "0x601919F")]
		[Address(RVA = "0x2EB6390", Offset = "0x2EB6390", VA = "0x2EB6390")]
		set
		{
		}
	}

	[Token(Token = "0x17001B05")]
	public uint uMediaSize
	{
		[Token(Token = "0x60191A2")]
		[Address(RVA = "0x2EB6538", Offset = "0x2EB6538", VA = "0x2EB6538")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60191A1")]
		[Address(RVA = "0x2EB64A8", Offset = "0x2EB64A8", VA = "0x2EB64A8")]
		set
		{
		}
	}

	[Token(Token = "0x6019197")]
	[Address(RVA = "0x2EB5F90", Offset = "0x2EB5F90", VA = "0x2EB5F90")]
	internal AkSourceSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6019198")]
	[Address(RVA = "0x2EB5FB8", Offset = "0x2EB5FB8", VA = "0x2EB5FB8")]
	public AkSourceSettings()
	{
	}

	[Token(Token = "0x6019199")]
	[Address(RVA = "0x2EB6054", Offset = "0x2EB6054", VA = "0x2EB6054")]
	internal static IntPtr getCPtr(AkSourceSettings obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x601919A")]
	[Address(RVA = "0x2EB60AC", Offset = "0x2EB60AC", VA = "0x2EB60AC", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x601919B")]
	[Address(RVA = "0x2EB60D8", Offset = "0x2EB60D8", VA = "0x2EB60D8", Slot = "1")]
	~AkSourceSettings()
	{
	}

	[Token(Token = "0x601919C")]
	[Address(RVA = "0x2EB614C", Offset = "0x2EB614C", VA = "0x2EB614C", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x60191A3")]
	[Address(RVA = "0x2EB65C0", Offset = "0x2EB65C0", VA = "0x2EB65C0")]
	public void Clear()
	{
	}

	[Token(Token = "0x60191A4")]
	[Address(RVA = "0x2EB6648", Offset = "0x2EB6648", VA = "0x2EB6648")]
	public static int GetSizeOf()
	{
		return default(int);
	}

	[Token(Token = "0x60191A5")]
	[Address(RVA = "0x2EB66C4", Offset = "0x2EB66C4", VA = "0x2EB66C4")]
	public void Clone(AkSourceSettings other)
	{
	}
}
