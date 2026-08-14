using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D7C")]
public class AkIterator : _Attribute
{
	[Token(Token = "0x401A1EE")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A1EF")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A7E")]
	public AkPlaylistItem pItem
	{
		[Token(Token = "0x6018FCC")]
		[Address(RVA = "0x36B1950", Offset = "0x36B1950", VA = "0x36B1950")]
		get
		{
			return null;
		}
		[Token(Token = "0x6018FCB")]
		[Address(RVA = "0x36B1820", Offset = "0x36B1820", VA = "0x36B1820")]
		set
		{
		}
	}

	[Token(Token = "0x6018FC5")]
	[Address(RVA = "0x36B1538", Offset = "0x36B1538", VA = "0x36B1538")]
	internal AkIterator(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018FC6")]
	[Address(RVA = "0x36B1560", Offset = "0x36B1560", VA = "0x36B1560")]
	public AkIterator()
	{
	}

	[Token(Token = "0x6018FC7")]
	[Address(RVA = "0x36B15FC", Offset = "0x36B15FC", VA = "0x36B15FC")]
	internal static IntPtr getCPtr(AkIterator obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018FC8")]
	[Address(RVA = "0x36B1654", Offset = "0x36B1654", VA = "0x36B1654", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018FC9")]
	[Address(RVA = "0x36B1680", Offset = "0x36B1680", VA = "0x36B1680", Slot = "1")]
	~AkIterator()
	{
	}

	[Token(Token = "0x6018FCA")]
	[Address(RVA = "0x36B16F4", Offset = "0x36B16F4", VA = "0x36B16F4", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6018FCD")]
	[Address(RVA = "0x36B1A4C", Offset = "0x36B1A4C", VA = "0x36B1A4C")]
	public AkIterator NextIter()
	{
		return null;
	}

	[Token(Token = "0x6018FCE")]
	[Address(RVA = "0x36B1B08", Offset = "0x36B1B08", VA = "0x36B1B08")]
	public AkIterator PrevIter()
	{
		return null;
	}

	[Token(Token = "0x6018FCF")]
	[Address(RVA = "0x36B1BC4", Offset = "0x36B1BC4", VA = "0x36B1BC4")]
	public AkPlaylistItem GetItem()
	{
		return null;
	}

	[Token(Token = "0x6018FD0")]
	[Address(RVA = "0x36B1C80", Offset = "0x36B1C80", VA = "0x36B1C80")]
	public bool IsEqualTo(AkIterator in_rOp)
	{
		return default(bool);
	}

	[Token(Token = "0x6018FD1")]
	[Address(RVA = "0x36B1D58", Offset = "0x36B1D58", VA = "0x36B1D58")]
	public bool IsDifferentFrom(AkIterator in_rOp)
	{
		return default(bool);
	}
}
