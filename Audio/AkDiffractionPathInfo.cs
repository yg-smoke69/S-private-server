using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D6E")]
public class AkDiffractionPathInfo : _Attribute
{
	[Token(Token = "0x401A1C2")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A1C3")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x401A1C4")]
	public const uint kMaxNodes = 8u;

	[Token(Token = "0x17001A3D")]
	public AkTransform virtualPos
	{
		[Token(Token = "0x6018F08")]
		[Address(RVA = "0x35D290C", Offset = "0x35D290C", VA = "0x35D290C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018F07")]
		[Address(RVA = "0x35D286C", Offset = "0x35D286C", VA = "0x35D286C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A3E")]
	public uint nodeCount
	{
		[Token(Token = "0x6018F0A")]
		[Address(RVA = "0x35D2A6C", Offset = "0x35D2A6C", VA = "0x35D2A6C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018F09")]
		[Address(RVA = "0x35D29DC", Offset = "0x35D29DC", VA = "0x35D29DC")]
		set
		{
		}
	}

	[Token(Token = "0x17001A3F")]
	public float diffraction
	{
		[Token(Token = "0x6018F0C")]
		[Address(RVA = "0x35D2B84", Offset = "0x35D2B84", VA = "0x35D2B84")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6018F0B")]
		[Address(RVA = "0x35D2AF4", Offset = "0x35D2AF4", VA = "0x35D2AF4")]
		set
		{
		}
	}

	[Token(Token = "0x17001A40")]
	public float totLength
	{
		[Token(Token = "0x6018F0E")]
		[Address(RVA = "0x35D2C9C", Offset = "0x35D2C9C", VA = "0x35D2C9C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6018F0D")]
		[Address(RVA = "0x35D2C0C", Offset = "0x35D2C0C", VA = "0x35D2C0C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A41")]
	public float obstructionValue
	{
		[Token(Token = "0x6018F10")]
		[Address(RVA = "0x35D2DB4", Offset = "0x35D2DB4", VA = "0x35D2DB4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6018F0F")]
		[Address(RVA = "0x35D2D24", Offset = "0x35D2D24", VA = "0x35D2D24")]
		set
		{
		}
	}

	[Token(Token = "0x6018F01")]
	[Address(RVA = "0x35D2584", Offset = "0x35D2584", VA = "0x35D2584")]
	internal AkDiffractionPathInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018F02")]
	[Address(RVA = "0x35D25AC", Offset = "0x35D25AC", VA = "0x35D25AC")]
	public AkDiffractionPathInfo()
	{
	}

	[Token(Token = "0x6018F03")]
	[Address(RVA = "0x35D2648", Offset = "0x35D2648", VA = "0x35D2648")]
	internal static IntPtr getCPtr(AkDiffractionPathInfo obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018F04")]
	[Address(RVA = "0x35D26A0", Offset = "0x35D26A0", VA = "0x35D26A0", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018F05")]
	[Address(RVA = "0x35D26CC", Offset = "0x35D26CC", VA = "0x35D26CC", Slot = "1")]
	~AkDiffractionPathInfo()
	{
	}

	[Token(Token = "0x6018F06")]
	[Address(RVA = "0x35D2740", Offset = "0x35D2740", VA = "0x35D2740", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6018F11")]
	[Address(RVA = "0x35D2E3C", Offset = "0x35D2E3C", VA = "0x35D2E3C")]
	public static int GetSizeOf()
	{
		return default(int);
	}

	[Token(Token = "0x6018F12")]
	[Address(RVA = "0x35D2EB8", Offset = "0x35D2EB8", VA = "0x35D2EB8")]
	public AkVector GetNodes(uint idx)
	{
		return null;
	}

	[Token(Token = "0x6018F13")]
	[Address(RVA = "0x35D2F90", Offset = "0x35D2F90", VA = "0x35D2F90")]
	public float GetAngles(uint idx)
	{
		return default(float);
	}

	[Token(Token = "0x6018F14")]
	[Address(RVA = "0x35D3020", Offset = "0x35D3020", VA = "0x35D3020")]
	public ulong GetPortals(uint idx)
	{
		return default(ulong);
	}

	[Token(Token = "0x6018F15")]
	[Address(RVA = "0x35D30B0", Offset = "0x35D30B0", VA = "0x35D30B0")]
	public ulong GetRooms(uint idx)
	{
		return default(ulong);
	}

	[Token(Token = "0x6018F16")]
	[Address(RVA = "0x35D3140", Offset = "0x35D3140", VA = "0x35D3140")]
	public void Clone(AkDiffractionPathInfo other)
	{
	}
}
