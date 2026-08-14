using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003DA9")]
public class AkStreamMgrSettings : _Attribute
{
	[Token(Token = "0x401A360")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A361")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001B0D")]
	public uint uMemorySize
	{
		[Token(Token = "0x60191C1")]
		[Address(RVA = "0x2EB8D4C", Offset = "0x2EB8D4C", VA = "0x2EB8D4C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60191C0")]
		[Address(RVA = "0x2EB8CBC", Offset = "0x2EB8CBC", VA = "0x2EB8CBC")]
		set
		{
		}
	}

	[Token(Token = "0x60191BA")]
	[Address(RVA = "0x2EB89D4", Offset = "0x2EB89D4", VA = "0x2EB89D4")]
	internal AkStreamMgrSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x60191BB")]
	[Address(RVA = "0x2EB89FC", Offset = "0x2EB89FC", VA = "0x2EB89FC")]
	public AkStreamMgrSettings()
	{
	}

	[Token(Token = "0x60191BC")]
	[Address(RVA = "0x2EB8A98", Offset = "0x2EB8A98", VA = "0x2EB8A98")]
	internal static IntPtr getCPtr(AkStreamMgrSettings obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60191BD")]
	[Address(RVA = "0x2EB8AF0", Offset = "0x2EB8AF0", VA = "0x2EB8AF0", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60191BE")]
	[Address(RVA = "0x2EB8B1C", Offset = "0x2EB8B1C", VA = "0x2EB8B1C", Slot = "1")]
	~AkStreamMgrSettings()
	{
	}

	[Token(Token = "0x60191BF")]
	[Address(RVA = "0x2EB8B90", Offset = "0x2EB8B90", VA = "0x2EB8B90", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
