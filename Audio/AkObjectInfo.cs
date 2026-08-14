using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D93")]
public class AkObjectInfo : _Attribute
{
	[Token(Token = "0x401A2E6")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A2E7")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001AC8")]
	public uint objID
	{
		[Token(Token = "0x60190A8")]
		[Address(RVA = "0x36BB7FC", Offset = "0x36BB7FC", VA = "0x36BB7FC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60190A7")]
		[Address(RVA = "0x36BB76C", Offset = "0x36BB76C", VA = "0x36BB76C")]
		set
		{
		}
	}

	[Token(Token = "0x17001AC9")]
	public uint parentID
	{
		[Token(Token = "0x60190AA")]
		[Address(RVA = "0x36BB914", Offset = "0x36BB914", VA = "0x36BB914")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60190A9")]
		[Address(RVA = "0x36BB884", Offset = "0x36BB884", VA = "0x36BB884")]
		set
		{
		}
	}

	[Token(Token = "0x17001ACA")]
	public int iDepth
	{
		[Token(Token = "0x60190AC")]
		[Address(RVA = "0x36BBA2C", Offset = "0x36BBA2C", VA = "0x36BBA2C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60190AB")]
		[Address(RVA = "0x36BB99C", Offset = "0x36BB99C", VA = "0x36BB99C")]
		set
		{
		}
	}

	[Token(Token = "0x60190A1")]
	[Address(RVA = "0x36BB484", Offset = "0x36BB484", VA = "0x36BB484")]
	internal AkObjectInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x60190A2")]
	[Address(RVA = "0x36BB4AC", Offset = "0x36BB4AC", VA = "0x36BB4AC")]
	public AkObjectInfo()
	{
	}

	[Token(Token = "0x60190A3")]
	[Address(RVA = "0x36BB548", Offset = "0x36BB548", VA = "0x36BB548")]
	internal static IntPtr getCPtr(AkObjectInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60190A4")]
	[Address(RVA = "0x36BB5A0", Offset = "0x36BB5A0", VA = "0x36BB5A0", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60190A5")]
	[Address(RVA = "0x36BB5CC", Offset = "0x36BB5CC", VA = "0x36BB5CC", Slot = "1")]
	~AkObjectInfo()
	{
	}

	[Token(Token = "0x60190A6")]
	[Address(RVA = "0x36BB640", Offset = "0x36BB640", VA = "0x36BB640", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x60190AD")]
	[Address(RVA = "0x36BBAB4", Offset = "0x36BBAB4", VA = "0x36BBAB4")]
	public void Clear()
	{
	}

	[Token(Token = "0x60190AE")]
	[Address(RVA = "0x36BBB3C", Offset = "0x36BBB3C", VA = "0x36BBB3C")]
	public static int GetSizeOf()
	{
		return default(int);
	}

	[Token(Token = "0x60190AF")]
	[Address(RVA = "0x36BBBB8", Offset = "0x36BBBB8", VA = "0x36BBBB8")]
	public void Clone(AkObjectInfo other)
	{
	}
}
