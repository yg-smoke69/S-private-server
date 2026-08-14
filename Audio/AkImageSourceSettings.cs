using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D79")]
public class AkImageSourceSettings : _Attribute
{
	[Token(Token = "0x401A1E8")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A1E9")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A62")]
	public AkImageSourceParams params_
	{
		[Token(Token = "0x6018F82")]
		[Address(RVA = "0x35DC7C8", Offset = "0x35DC7C8", VA = "0x35DC7C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018F81")]
		[Address(RVA = "0x35DC6F0", Offset = "0x35DC6F0", VA = "0x35DC6F0")]
		set
		{
		}
	}

	[Token(Token = "0x6018F78")]
	[Address(RVA = "0x35DC224", Offset = "0x35DC224", VA = "0x35DC224")]
	internal AkImageSourceSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018F79")]
	[Address(RVA = "0x35DC24C", Offset = "0x35DC24C", VA = "0x35DC24C")]
	public AkImageSourceSettings()
	{
	}

	[Token(Token = "0x6018F7A")]
	[Address(RVA = "0x35DC2E8", Offset = "0x35DC2E8", VA = "0x35DC2E8")]
	public AkImageSourceSettings(AkVector in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel)
	{
	}

	[Token(Token = "0x6018F7B")]
	[Address(RVA = "0x35DC3AC", Offset = "0x35DC3AC", VA = "0x35DC3AC")]
	internal static IntPtr getCPtr(AkImageSourceSettings obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018F7C")]
	[Address(RVA = "0x35DC404", Offset = "0x35DC404", VA = "0x35DC404", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018F7D")]
	[Address(RVA = "0x35DC430", Offset = "0x35DC430", VA = "0x35DC430", Slot = "1")]
	~AkImageSourceSettings()
	{
	}

	[Token(Token = "0x6018F7E")]
	[Address(RVA = "0x35DC4A4", Offset = "0x35DC4A4", VA = "0x35DC4A4", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6018F7F")]
	[Address(RVA = "0x35DC5D0", Offset = "0x35DC5D0", VA = "0x35DC5D0")]
	public void SetOneTexture(uint in_texture)
	{
	}

	[Token(Token = "0x6018F80")]
	[Address(RVA = "0x35DC660", Offset = "0x35DC660", VA = "0x35DC660")]
	public void SetName(string in_pName)
	{
	}
}
