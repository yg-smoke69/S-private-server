using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D51")]
public class AkThreadProperties : _Attribute
{
	[Token(Token = "0x401A14F")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A150")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A13")]
	public int nPriority
	{
		[Token(Token = "0x6018E35")]
		[Address(RVA = "0x2EBB0E4", Offset = "0x2EBB0E4", VA = "0x2EBB0E4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6018E34")]
		[Address(RVA = "0x2EBB054", Offset = "0x2EBB054", VA = "0x2EBB054")]
		set
		{
		}
	}

	[Token(Token = "0x17001A14")]
	public uint uStackSize
	{
		[Token(Token = "0x6018E37")]
		[Address(RVA = "0x2EBB1FC", Offset = "0x2EBB1FC", VA = "0x2EBB1FC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018E36")]
		[Address(RVA = "0x2EBB16C", Offset = "0x2EBB16C", VA = "0x2EBB16C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A15")]
	public int uSchedPolicy
	{
		[Token(Token = "0x6018E39")]
		[Address(RVA = "0x2EBB314", Offset = "0x2EBB314", VA = "0x2EBB314")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6018E38")]
		[Address(RVA = "0x2EBB284", Offset = "0x2EBB284", VA = "0x2EBB284")]
		set
		{
		}
	}

	[Token(Token = "0x17001A16")]
	public uint dwAffinityMask
	{
		[Token(Token = "0x6018E3B")]
		[Address(RVA = "0x2EBB42C", Offset = "0x2EBB42C", VA = "0x2EBB42C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018E3A")]
		[Address(RVA = "0x2EBB39C", Offset = "0x2EBB39C", VA = "0x2EBB39C")]
		set
		{
		}
	}

	[Token(Token = "0x6018E2E")]
	[Address(RVA = "0x2EBAD6C", Offset = "0x2EBAD6C", VA = "0x2EBAD6C")]
	internal AkThreadProperties(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018E2F")]
	[Address(RVA = "0x2EBAD94", Offset = "0x2EBAD94", VA = "0x2EBAD94")]
	public AkThreadProperties()
	{
	}

	[Token(Token = "0x6018E30")]
	[Address(RVA = "0x2EBAE30", Offset = "0x2EBAE30", VA = "0x2EBAE30")]
	internal static IntPtr getCPtr(AkThreadProperties obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018E31")]
	[Address(RVA = "0x2EBAE88", Offset = "0x2EBAE88", VA = "0x2EBAE88", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018E32")]
	[Address(RVA = "0x2EBAEB4", Offset = "0x2EBAEB4", VA = "0x2EBAEB4", Slot = "1")]
	~AkThreadProperties()
	{
	}

	[Token(Token = "0x6018E33")]
	[Address(RVA = "0x2EBAF28", Offset = "0x2EBAF28", VA = "0x2EBAF28", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
