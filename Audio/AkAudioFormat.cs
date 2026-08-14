using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D5B")]
public class AkAudioFormat : _Attribute
{
	[Token(Token = "0x401A16F")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A170")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A1A")]
	public uint uSampleRate
	{
		[Token(Token = "0x6018E6E")]
		[Address(RVA = "0x35C1224", Offset = "0x35C1224", VA = "0x35C1224")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018E6D")]
		[Address(RVA = "0x35C1194", Offset = "0x35C1194", VA = "0x35C1194")]
		set
		{
		}
	}

	[Token(Token = "0x17001A1B")]
	public AkChannelConfig channelConfig
	{
		[Token(Token = "0x6018E70")]
		[Address(RVA = "0x35C13DC", Offset = "0x35C13DC", VA = "0x35C13DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018E6F")]
		[Address(RVA = "0x35C12AC", Offset = "0x35C12AC", VA = "0x35C12AC")]
		set
		{
		}
	}

	[Token(Token = "0x17001A1C")]
	public uint uBitsPerSample
	{
		[Token(Token = "0x6018E72")]
		[Address(RVA = "0x35C1568", Offset = "0x35C1568", VA = "0x35C1568")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018E71")]
		[Address(RVA = "0x35C14D8", Offset = "0x35C14D8", VA = "0x35C14D8")]
		set
		{
		}
	}

	[Token(Token = "0x17001A1D")]
	public uint uBlockAlign
	{
		[Token(Token = "0x6018E74")]
		[Address(RVA = "0x35C1680", Offset = "0x35C1680", VA = "0x35C1680")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018E73")]
		[Address(RVA = "0x35C15F0", Offset = "0x35C15F0", VA = "0x35C15F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A1E")]
	public uint uTypeID
	{
		[Token(Token = "0x6018E76")]
		[Address(RVA = "0x35C1798", Offset = "0x35C1798", VA = "0x35C1798")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018E75")]
		[Address(RVA = "0x35C1708", Offset = "0x35C1708", VA = "0x35C1708")]
		set
		{
		}
	}

	[Token(Token = "0x17001A1F")]
	public uint uInterleaveID
	{
		[Token(Token = "0x6018E78")]
		[Address(RVA = "0x35C18B0", Offset = "0x35C18B0", VA = "0x35C18B0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018E77")]
		[Address(RVA = "0x35C1820", Offset = "0x35C1820", VA = "0x35C1820")]
		set
		{
		}
	}

	[Token(Token = "0x6018E67")]
	[Address(RVA = "0x35C0EAC", Offset = "0x35C0EAC", VA = "0x35C0EAC")]
	internal AkAudioFormat(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018E68")]
	[Address(RVA = "0x35C0ED4", Offset = "0x35C0ED4", VA = "0x35C0ED4")]
	public AkAudioFormat()
	{
	}

	[Token(Token = "0x6018E69")]
	[Address(RVA = "0x35C0F70", Offset = "0x35C0F70", VA = "0x35C0F70")]
	internal static IntPtr getCPtr(AkAudioFormat obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018E6A")]
	[Address(RVA = "0x35C0FC8", Offset = "0x35C0FC8", VA = "0x35C0FC8", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018E6B")]
	[Address(RVA = "0x35C0FF4", Offset = "0x35C0FF4", VA = "0x35C0FF4", Slot = "1")]
	~AkAudioFormat()
	{
	}

	[Token(Token = "0x6018E6C")]
	[Address(RVA = "0x35C1068", Offset = "0x35C1068", VA = "0x35C1068", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6018E79")]
	[Address(RVA = "0x35C1938", Offset = "0x35C1938", VA = "0x35C1938")]
	public uint GetNumChannels()
	{
		return default(uint);
	}

	[Token(Token = "0x6018E7A")]
	[Address(RVA = "0x35C19C0", Offset = "0x35C19C0", VA = "0x35C19C0")]
	public uint GetBitsPerSample()
	{
		return default(uint);
	}

	[Token(Token = "0x6018E7B")]
	[Address(RVA = "0x35C1A48", Offset = "0x35C1A48", VA = "0x35C1A48")]
	public uint GetBlockAlign()
	{
		return default(uint);
	}

	[Token(Token = "0x6018E7C")]
	[Address(RVA = "0x35C1AD0", Offset = "0x35C1AD0", VA = "0x35C1AD0")]
	public uint GetTypeID()
	{
		return default(uint);
	}

	[Token(Token = "0x6018E7D")]
	[Address(RVA = "0x35C1B58", Offset = "0x35C1B58", VA = "0x35C1B58")]
	public uint GetInterleaveID()
	{
		return default(uint);
	}

	[Token(Token = "0x6018E7E")]
	[Address(RVA = "0x35C1BE0", Offset = "0x35C1BE0", VA = "0x35C1BE0")]
	public void SetAll(uint in_uSampleRate, AkChannelConfig in_channelConfig, uint in_uBitsPerSample, uint in_uBlockAlign, uint in_uTypeID, uint in_uInterleaveID)
	{
	}

	[Token(Token = "0x6018E7F")]
	[Address(RVA = "0x35C1CE0", Offset = "0x35C1CE0", VA = "0x35C1CE0")]
	public bool IsChannelConfigSupported()
	{
		return default(bool);
	}
}
