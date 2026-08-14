using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003DAC")]
public class AkTriangle : _Attribute
{
	[Token(Token = "0x401A366")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A367")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001B0F")]
	public ushort point0
	{
		[Token(Token = "0x60191E1")]
		[Address(RVA = "0x2EBC32C", Offset = "0x2EBC32C", VA = "0x2EBC32C")]
		get
		{
			return default(ushort);
		}
		[Token(Token = "0x60191E0")]
		[Address(RVA = "0x2EBA200", Offset = "0x2EBA200", VA = "0x2EBA200")]
		set
		{
		}
	}

	[Token(Token = "0x17001B10")]
	public ushort point1
	{
		[Token(Token = "0x60191E3")]
		[Address(RVA = "0x2EBC3B4", Offset = "0x2EBC3B4", VA = "0x2EBC3B4")]
		get
		{
			return default(ushort);
		}
		[Token(Token = "0x60191E2")]
		[Address(RVA = "0x2EBA290", Offset = "0x2EBA290", VA = "0x2EBA290")]
		set
		{
		}
	}

	[Token(Token = "0x17001B11")]
	public ushort point2
	{
		[Token(Token = "0x60191E5")]
		[Address(RVA = "0x2EBC43C", Offset = "0x2EBC43C", VA = "0x2EBC43C")]
		get
		{
			return default(ushort);
		}
		[Token(Token = "0x60191E4")]
		[Address(RVA = "0x2EBA320", Offset = "0x2EBA320", VA = "0x2EBA320")]
		set
		{
		}
	}

	[Token(Token = "0x17001B12")]
	public ushort surface
	{
		[Token(Token = "0x60191E7")]
		[Address(RVA = "0x2EBC4C4", Offset = "0x2EBC4C4", VA = "0x2EBC4C4")]
		get
		{
			return default(ushort);
		}
		[Token(Token = "0x60191E6")]
		[Address(RVA = "0x2EBA3B0", Offset = "0x2EBA3B0", VA = "0x2EBA3B0")]
		set
		{
		}
	}

	[Token(Token = "0x60191D9")]
	[Address(RVA = "0x2EBBF7C", Offset = "0x2EBBF7C", VA = "0x2EBBF7C")]
	internal AkTriangle(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x60191DA")]
	[Address(RVA = "0x2EBBFA4", Offset = "0x2EBBFA4", VA = "0x2EBBFA4")]
	public AkTriangle()
	{
	}

	[Token(Token = "0x60191DB")]
	[Address(RVA = "0x2EBC040", Offset = "0x2EBC040", VA = "0x2EBC040")]
	public AkTriangle(ushort in_pt0, ushort in_pt1, ushort in_pt2, ushort in_surfaceInfo)
	{
	}

	[Token(Token = "0x60191DC")]
	[Address(RVA = "0x2EBC108", Offset = "0x2EBC108", VA = "0x2EBC108")]
	internal static IntPtr getCPtr(AkTriangle obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60191DD")]
	[Address(RVA = "0x2EBC160", Offset = "0x2EBC160", VA = "0x2EBC160", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60191DE")]
	[Address(RVA = "0x2EBC18C", Offset = "0x2EBC18C", VA = "0x2EBC18C", Slot = "1")]
	~AkTriangle()
	{
	}

	[Token(Token = "0x60191DF")]
	[Address(RVA = "0x2EBC200", Offset = "0x2EBC200", VA = "0x2EBC200", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x60191E8")]
	[Address(RVA = "0x2EBC54C", Offset = "0x2EBC54C", VA = "0x2EBC54C")]
	public void Clear()
	{
	}

	[Token(Token = "0x60191E9")]
	[Address(RVA = "0x2EBC5D4", Offset = "0x2EBC5D4", VA = "0x2EBC5D4")]
	public static int GetSizeOf()
	{
		return default(int);
	}

	[Token(Token = "0x60191EA")]
	[Address(RVA = "0x2EBC650", Offset = "0x2EBC650", VA = "0x2EBC650")]
	public void Clone(AkTriangle other)
	{
	}
}
