using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D68")]
public class AkChannelEmitter : _Attribute
{
	[Token(Token = "0x401A1A6")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A1A7")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A30")]
	public AkTransform position
	{
		[Token(Token = "0x6018EE2")]
		[Address(RVA = "0x35CF100", Offset = "0x35CF100", VA = "0x35CF100")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018EE1")]
		[Address(RVA = "0x35CF060", Offset = "0x35CF060", VA = "0x35CF060")]
		set
		{
		}
	}

	[Token(Token = "0x17001A31")]
	public uint uInputChannels
	{
		[Token(Token = "0x6018EE4")]
		[Address(RVA = "0x35CF260", Offset = "0x35CF260", VA = "0x35CF260")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018EE3")]
		[Address(RVA = "0x35CF1D0", Offset = "0x35CF1D0", VA = "0x35CF1D0")]
		set
		{
		}
	}

	[Token(Token = "0x6018EDC")]
	[Address(RVA = "0x35CEE14", Offset = "0x35CEE14", VA = "0x35CEE14")]
	internal AkChannelEmitter(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018EDD")]
	[Address(RVA = "0x35CEE3C", Offset = "0x35CEE3C", VA = "0x35CEE3C")]
	internal static IntPtr getCPtr(AkChannelEmitter obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018EDE")]
	[Address(RVA = "0x35CEE94", Offset = "0x35CEE94", VA = "0x35CEE94", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018EDF")]
	[Address(RVA = "0x35CEEC0", Offset = "0x35CEEC0", VA = "0x35CEEC0", Slot = "1")]
	~AkChannelEmitter()
	{
	}

	[Token(Token = "0x6018EE0")]
	[Address(RVA = "0x35CEF34", Offset = "0x35CEF34", VA = "0x35CEF34", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
