using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D5D")]
public class AkAudioSettings : _Attribute
{
	[Token(Token = "0x401A173")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A174")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A21")]
	public uint uNumSamplesPerFrame
	{
		[Token(Token = "0x6018E8E")]
		[Address(RVA = "0x35C518C", Offset = "0x35C518C", VA = "0x35C518C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018E8D")]
		[Address(RVA = "0x35C50FC", Offset = "0x35C50FC", VA = "0x35C50FC")]
		set
		{
		}
	}

	[Token(Token = "0x17001A22")]
	public uint uNumSamplesPerSecond
	{
		[Token(Token = "0x6018E90")]
		[Address(RVA = "0x35C52A4", Offset = "0x35C52A4", VA = "0x35C52A4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018E8F")]
		[Address(RVA = "0x35C5214", Offset = "0x35C5214", VA = "0x35C5214")]
		set
		{
		}
	}

	[Token(Token = "0x6018E87")]
	[Address(RVA = "0x35C4E14", Offset = "0x35C4E14", VA = "0x35C4E14")]
	internal AkAudioSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018E88")]
	[Address(RVA = "0x35C4E3C", Offset = "0x35C4E3C", VA = "0x35C4E3C")]
	public AkAudioSettings()
	{
	}

	[Token(Token = "0x6018E89")]
	[Address(RVA = "0x35C4ED8", Offset = "0x35C4ED8", VA = "0x35C4ED8")]
	internal static IntPtr getCPtr(AkAudioSettings obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018E8A")]
	[Address(RVA = "0x35C4F30", Offset = "0x35C4F30", VA = "0x35C4F30", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018E8B")]
	[Address(RVA = "0x35C4F5C", Offset = "0x35C4F5C", VA = "0x35C4F5C", Slot = "1")]
	~AkAudioSettings()
	{
	}

	[Token(Token = "0x6018E8C")]
	[Address(RVA = "0x35C4FD0", Offset = "0x35C4FD0", VA = "0x35C4FD0", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
