using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D52")]
public class AkUnityPlatformSpecificSettings : _Attribute
{
	[Token(Token = "0x401A151")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A152")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x6018E3C")]
	[Address(RVA = "0x2EBEBBC", Offset = "0x2EBEBBC", VA = "0x2EBEBBC")]
	internal AkUnityPlatformSpecificSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018E3D")]
	[Address(RVA = "0x2EBEBE4", Offset = "0x2EBEBE4", VA = "0x2EBEBE4")]
	public AkUnityPlatformSpecificSettings()
	{
	}

	[Token(Token = "0x6018E3E")]
	[Address(RVA = "0x2EBEC80", Offset = "0x2EBEC80", VA = "0x2EBEC80")]
	internal static IntPtr getCPtr(AkUnityPlatformSpecificSettings obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018E3F")]
	[Address(RVA = "0x2EBECD8", Offset = "0x2EBECD8", VA = "0x2EBECD8", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018E40")]
	[Address(RVA = "0x2EBED04", Offset = "0x2EBED04", VA = "0x2EBED04", Slot = "1")]
	~AkUnityPlatformSpecificSettings()
	{
	}

	[Token(Token = "0x6018E41")]
	[Address(RVA = "0x2EBED78", Offset = "0x2EBED78", VA = "0x2EBED78", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
