using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D6C")]
public class AkDeviceSettings : _Attribute
{
	[Token(Token = "0x401A1BB")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A1BC")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A32")]
	public IntPtr pIOMemory
	{
		[Token(Token = "0x6018EEC")]
		[Address(RVA = "0x35D1BF4", Offset = "0x35D1BF4", VA = "0x35D1BF4")]
		get
		{
			return default(IntPtr);
		}
		[Token(Token = "0x6018EEB")]
		[Address(RVA = "0x35D1B64", Offset = "0x35D1B64", VA = "0x35D1B64")]
		set
		{
		}
	}

	[Token(Token = "0x17001A33")]
	public uint uIOMemorySize
	{
		[Token(Token = "0x6018EEE")]
		[Address(RVA = "0x35D1C7C", Offset = "0x35D1C7C", VA = "0x35D1C7C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018EED")]
		[Address(RVA = "0x35CF9AC", Offset = "0x35CF9AC", VA = "0x35CF9AC")]
		set
		{
		}
	}

	[Token(Token = "0x17001A34")]
	public uint uIOMemoryAlignment
	{
		[Token(Token = "0x6018EF0")]
		[Address(RVA = "0x35D1D94", Offset = "0x35D1D94", VA = "0x35D1D94")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018EEF")]
		[Address(RVA = "0x35D1D04", Offset = "0x35D1D04", VA = "0x35D1D04")]
		set
		{
		}
	}

	[Token(Token = "0x17001A35")]
	public int ePoolAttributes
	{
		[Token(Token = "0x6018EF2")]
		[Address(RVA = "0x35D1EAC", Offset = "0x35D1EAC", VA = "0x35D1EAC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6018EF1")]
		[Address(RVA = "0x35D1E1C", Offset = "0x35D1E1C", VA = "0x35D1E1C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A36")]
	public uint uGranularity
	{
		[Token(Token = "0x6018EF4")]
		[Address(RVA = "0x35D1FC4", Offset = "0x35D1FC4", VA = "0x35D1FC4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018EF3")]
		[Address(RVA = "0x35D1F34", Offset = "0x35D1F34", VA = "0x35D1F34")]
		set
		{
		}
	}

	[Token(Token = "0x17001A37")]
	public uint uSchedulerTypeFlags
	{
		[Token(Token = "0x6018EF6")]
		[Address(RVA = "0x35D20DC", Offset = "0x35D20DC", VA = "0x35D20DC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018EF5")]
		[Address(RVA = "0x35D204C", Offset = "0x35D204C", VA = "0x35D204C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A38")]
	public AkThreadProperties threadProperties
	{
		[Token(Token = "0x6018EF8")]
		[Address(RVA = "0x35D2204", Offset = "0x35D2204", VA = "0x35D2204")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018EF7")]
		[Address(RVA = "0x35D2164", Offset = "0x35D2164", VA = "0x35D2164")]
		set
		{
		}
	}

	[Token(Token = "0x17001A39")]
	public float fTargetAutoStmBufferLength
	{
		[Token(Token = "0x6018EFA")]
		[Address(RVA = "0x35D22D4", Offset = "0x35D22D4", VA = "0x35D22D4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6018EF9")]
		[Address(RVA = "0x35CFA3C", Offset = "0x35CFA3C", VA = "0x35CFA3C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A3A")]
	public uint uMaxConcurrentIO
	{
		[Token(Token = "0x6018EFC")]
		[Address(RVA = "0x35D23EC", Offset = "0x35D23EC", VA = "0x35D23EC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018EFB")]
		[Address(RVA = "0x35D235C", Offset = "0x35D235C", VA = "0x35D235C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A3B")]
	public bool bUseStreamCache
	{
		[Token(Token = "0x6018EFE")]
		[Address(RVA = "0x35D2474", Offset = "0x35D2474", VA = "0x35D2474")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6018EFD")]
		[Address(RVA = "0x35CFACC", Offset = "0x35CFACC", VA = "0x35CFACC")]
		set
		{
		}
	}

	[Token(Token = "0x17001A3C")]
	public uint uMaxCachePinnedBytes
	{
		[Token(Token = "0x6018F00")]
		[Address(RVA = "0x35D24FC", Offset = "0x35D24FC", VA = "0x35D24FC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018EFF")]
		[Address(RVA = "0x35CFB5C", Offset = "0x35CFB5C", VA = "0x35CFB5C")]
		set
		{
		}
	}

	[Token(Token = "0x6018EE5")]
	[Address(RVA = "0x35D187C", Offset = "0x35D187C", VA = "0x35D187C")]
	internal AkDeviceSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018EE6")]
	[Address(RVA = "0x35D18A4", Offset = "0x35D18A4", VA = "0x35D18A4")]
	public AkDeviceSettings()
	{
	}

	[Token(Token = "0x6018EE7")]
	[Address(RVA = "0x35D1940", Offset = "0x35D1940", VA = "0x35D1940")]
	internal static IntPtr getCPtr(AkDeviceSettings obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018EE8")]
	[Address(RVA = "0x35D1998", Offset = "0x35D1998", VA = "0x35D1998", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018EE9")]
	[Address(RVA = "0x35D19C4", Offset = "0x35D19C4", VA = "0x35D19C4", Slot = "1")]
	~AkDeviceSettings()
	{
	}

	[Token(Token = "0x6018EEA")]
	[Address(RVA = "0x35D1A38", Offset = "0x35D1A38", VA = "0x35D1A38", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
