using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D78")]
public class AkImageSourceParams : _Attribute
{
	[Token(Token = "0x401A1E6")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A1E7")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A5C")]
	public AkVector sourcePosition
	{
		[Token(Token = "0x6018F6D")]
		[Address(RVA = "0x35DBBDC", Offset = "0x35DBBDC", VA = "0x35DBBDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018F6C")]
		[Address(RVA = "0x35DBB3C", Offset = "0x35DBB3C", VA = "0x35DBB3C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A5D")]
	public float fDistanceScalingFactor
	{
		[Token(Token = "0x6018F6F")]
		[Address(RVA = "0x35DBD3C", Offset = "0x35DBD3C", VA = "0x35DBD3C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6018F6E")]
		[Address(RVA = "0x35DBCAC", Offset = "0x35DBCAC", VA = "0x35DBCAC")]
		set
		{
		}
	}

	[Token(Token = "0x17001A5E")]
	public float fLevel
	{
		[Token(Token = "0x6018F71")]
		[Address(RVA = "0x35DBE54", Offset = "0x35DBE54", VA = "0x35DBE54")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6018F70")]
		[Address(RVA = "0x35DBDC4", Offset = "0x35DBDC4", VA = "0x35DBDC4")]
		set
		{
		}
	}

	[Token(Token = "0x17001A5F")]
	public float fDiffraction
	{
		[Token(Token = "0x6018F73")]
		[Address(RVA = "0x35DBF6C", Offset = "0x35DBF6C", VA = "0x35DBF6C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6018F72")]
		[Address(RVA = "0x35DBEDC", Offset = "0x35DBEDC", VA = "0x35DBEDC")]
		set
		{
		}
	}

	[Token(Token = "0x17001A60")]
	public byte uDiffractionEmitterSide
	{
		[Token(Token = "0x6018F75")]
		[Address(RVA = "0x35DC084", Offset = "0x35DC084", VA = "0x35DC084")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6018F74")]
		[Address(RVA = "0x35DBFF4", Offset = "0x35DBFF4", VA = "0x35DBFF4")]
		set
		{
		}
	}

	[Token(Token = "0x17001A61")]
	public byte uDiffractionListenerSide
	{
		[Token(Token = "0x6018F77")]
		[Address(RVA = "0x35DC19C", Offset = "0x35DC19C", VA = "0x35DC19C")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6018F76")]
		[Address(RVA = "0x35DC10C", Offset = "0x35DC10C", VA = "0x35DC10C")]
		set
		{
		}
	}

	[Token(Token = "0x6018F65")]
	[Address(RVA = "0x35DB790", Offset = "0x35DB790", VA = "0x35DB790")]
	internal AkImageSourceParams(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018F66")]
	[Address(RVA = "0x35DB7B8", Offset = "0x35DB7B8", VA = "0x35DB7B8")]
	public AkImageSourceParams()
	{
	}

	[Token(Token = "0x6018F67")]
	[Address(RVA = "0x35DB854", Offset = "0x35DB854", VA = "0x35DB854")]
	public AkImageSourceParams(AkVector in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel)
	{
	}

	[Token(Token = "0x6018F68")]
	[Address(RVA = "0x35DB918", Offset = "0x35DB918", VA = "0x35DB918")]
	internal static IntPtr getCPtr(AkImageSourceParams obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018F69")]
	[Address(RVA = "0x35DB970", Offset = "0x35DB970", VA = "0x35DB970", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018F6A")]
	[Address(RVA = "0x35DB99C", Offset = "0x35DB99C", VA = "0x35DB99C", Slot = "1")]
	~AkImageSourceParams()
	{
	}

	[Token(Token = "0x6018F6B")]
	[Address(RVA = "0x35DBA10", Offset = "0x35DBA10", VA = "0x35DBA10", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
