using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D91")]
public class AkMusicSettings : _Attribute
{
	[Token(Token = "0x401A2E3")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A2E4")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001ABB")]
	public float fStreamingLookAheadRatio
	{
		[Token(Token = "0x601908E")]
		[Address(RVA = "0x36BA990", Offset = "0x36BA990", VA = "0x36BA990")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601908D")]
		[Address(RVA = "0x36BA900", Offset = "0x36BA900", VA = "0x36BA900")]
		set
		{
		}
	}

	[Token(Token = "0x6019087")]
	[Address(RVA = "0x36B0A48", Offset = "0x36B0A48", VA = "0x36B0A48")]
	internal AkMusicSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6019088")]
	[Address(RVA = "0x36BA698", Offset = "0x36BA698", VA = "0x36BA698")]
	public AkMusicSettings()
	{
	}

	[Token(Token = "0x6019089")]
	[Address(RVA = "0x36B091C", Offset = "0x36B091C", VA = "0x36B091C")]
	internal static IntPtr getCPtr(AkMusicSettings obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x601908A")]
	[Address(RVA = "0x36BA734", Offset = "0x36BA734", VA = "0x36BA734", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x601908B")]
	[Address(RVA = "0x36BA760", Offset = "0x36BA760", VA = "0x36BA760", Slot = "1")]
	~AkMusicSettings()
	{
	}

	[Token(Token = "0x601908C")]
	[Address(RVA = "0x36BA7D4", Offset = "0x36BA7D4", VA = "0x36BA7D4", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
