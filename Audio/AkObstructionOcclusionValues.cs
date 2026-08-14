using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D94")]
public class AkObstructionOcclusionValues : _Attribute
{
	[Token(Token = "0x401A2E8")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A2E9")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001ACB")]
	public float occlusion
	{
		[Token(Token = "0x60190B7")]
		[Address(RVA = "0x36BD028", Offset = "0x36BD028", VA = "0x36BD028")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60190B6")]
		[Address(RVA = "0x36BCF98", Offset = "0x36BCF98", VA = "0x36BCF98")]
		set
		{
		}
	}

	[Token(Token = "0x17001ACC")]
	public float obstruction
	{
		[Token(Token = "0x60190B9")]
		[Address(RVA = "0x36BD140", Offset = "0x36BD140", VA = "0x36BD140")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60190B8")]
		[Address(RVA = "0x36BD0B0", Offset = "0x36BD0B0", VA = "0x36BD0B0")]
		set
		{
		}
	}

	[Token(Token = "0x60190B0")]
	[Address(RVA = "0x36BCCB0", Offset = "0x36BCCB0", VA = "0x36BCCB0")]
	internal AkObstructionOcclusionValues(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x60190B1")]
	[Address(RVA = "0x36BCCD8", Offset = "0x36BCCD8", VA = "0x36BCCD8")]
	public AkObstructionOcclusionValues()
	{
	}

	[Token(Token = "0x60190B2")]
	[Address(RVA = "0x36BCD74", Offset = "0x36BCD74", VA = "0x36BCD74")]
	internal static IntPtr getCPtr(AkObstructionOcclusionValues obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60190B3")]
	[Address(RVA = "0x36BCDCC", Offset = "0x36BCDCC", VA = "0x36BCDCC", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60190B4")]
	[Address(RVA = "0x36BCDF8", Offset = "0x36BCDF8", VA = "0x36BCDF8", Slot = "1")]
	~AkObstructionOcclusionValues()
	{
	}

	[Token(Token = "0x60190B5")]
	[Address(RVA = "0x36BCE6C", Offset = "0x36BCE6C", VA = "0x36BCE6C", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x60190BA")]
	[Address(RVA = "0x36BD1C8", Offset = "0x36BD1C8", VA = "0x36BD1C8")]
	public void Clear()
	{
	}

	[Token(Token = "0x60190BB")]
	[Address(RVA = "0x36BD250", Offset = "0x36BD250", VA = "0x36BD250")]
	public static int GetSizeOf()
	{
		return default(int);
	}

	[Token(Token = "0x60190BC")]
	[Address(RVA = "0x36BD2CC", Offset = "0x36BD2CC", VA = "0x36BD2CC")]
	public void Clone(AkObstructionOcclusionValues other)
	{
	}
}
