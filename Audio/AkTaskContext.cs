using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003DAA")]
public class AkTaskContext : _Attribute
{
	[Token(Token = "0x401A362")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A363")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001B0E")]
	public uint uIdxThread
	{
		[Token(Token = "0x60191C9")]
		[Address(RVA = "0x2EBACDC", Offset = "0x2EBACDC", VA = "0x2EBACDC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60191C8")]
		[Address(RVA = "0x2EBAC4C", Offset = "0x2EBAC4C", VA = "0x2EBAC4C")]
		set
		{
		}
	}

	[Token(Token = "0x60191C2")]
	[Address(RVA = "0x2EBA964", Offset = "0x2EBA964", VA = "0x2EBA964")]
	internal AkTaskContext(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x60191C3")]
	[Address(RVA = "0x2EBA98C", Offset = "0x2EBA98C", VA = "0x2EBA98C")]
	public AkTaskContext()
	{
	}

	[Token(Token = "0x60191C4")]
	[Address(RVA = "0x2EBAA28", Offset = "0x2EBAA28", VA = "0x2EBAA28")]
	internal static IntPtr getCPtr(AkTaskContext obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60191C5")]
	[Address(RVA = "0x2EBAA80", Offset = "0x2EBAA80", VA = "0x2EBAA80", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60191C6")]
	[Address(RVA = "0x2EBAAAC", Offset = "0x2EBAAAC", VA = "0x2EBAAAC", Slot = "1")]
	~AkTaskContext()
	{
	}

	[Token(Token = "0x60191C7")]
	[Address(RVA = "0x2EBAB20", Offset = "0x2EBAB20", VA = "0x2EBAB20", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
