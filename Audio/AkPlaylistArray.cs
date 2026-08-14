using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003D99")]
public class AkPlaylistArray : _Attribute
{
	[Token(Token = "0x401A2F2")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A2F3")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x60190E6")]
	[Address(RVA = "0x36BF7C4", Offset = "0x36BF7C4", VA = "0x36BF7C4")]
	internal AkPlaylistArray(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x60190E7")]
	[Address(RVA = "0x36C0058", Offset = "0x36C0058", VA = "0x36C0058")]
	public AkPlaylistArray()
	{
	}

	[Token(Token = "0x60190E8")]
	[Address(RVA = "0x36C00F4", Offset = "0x36C00F4", VA = "0x36C00F4")]
	internal static IntPtr getCPtr(AkPlaylistArray obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60190E9")]
	[Address(RVA = "0x36BF97C", Offset = "0x36BF97C", VA = "0x36BF97C", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60190EA")]
	[Address(RVA = "0x36BFA14", Offset = "0x36BFA14", VA = "0x36BFA14", Slot = "1")]
	~AkPlaylistArray()
	{
	}

	[Token(Token = "0x60190EB")]
	[Address(RVA = "0x36BFBBC", Offset = "0x36BFBBC", VA = "0x36BFBBC", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x60190EC")]
	[Address(RVA = "0x36C014C", Offset = "0x36C014C", VA = "0x36C014C")]
	public AkIterator Begin()
	{
		return null;
	}

	[Token(Token = "0x60190ED")]
	[Address(RVA = "0x36C0208", Offset = "0x36C0208", VA = "0x36C0208")]
	public AkIterator End()
	{
		return null;
	}

	[Token(Token = "0x60190EE")]
	[Address(RVA = "0x36C02C4", Offset = "0x36C02C4", VA = "0x36C02C4")]
	public AkIterator FindEx(AkPlaylistItem in_Item)
	{
		return null;
	}

	[Token(Token = "0x60190EF")]
	[Address(RVA = "0x36C03D0", Offset = "0x36C03D0", VA = "0x36C03D0")]
	public AkIterator Erase(AkIterator in_rIter)
	{
		return null;
	}

	[Token(Token = "0x60190F0")]
	[Address(RVA = "0x36C04DC", Offset = "0x36C04DC", VA = "0x36C04DC")]
	public void Erase(uint in_uIndex)
	{
	}

	[Token(Token = "0x60190F1")]
	[Address(RVA = "0x36C056C", Offset = "0x36C056C", VA = "0x36C056C")]
	public AkIterator EraseSwap(AkIterator in_rIter)
	{
		return null;
	}

	[Token(Token = "0x60190F2")]
	[Address(RVA = "0x36C0678", Offset = "0x36C0678", VA = "0x36C0678")]
	public AKRESULT Reserve(uint in_ulReserve)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60190F3")]
	[Address(RVA = "0x36C0708", Offset = "0x36C0708", VA = "0x36C0708")]
	public uint Reserved()
	{
		return default(uint);
	}

	[Token(Token = "0x60190F4")]
	[Address(RVA = "0x36C0790", Offset = "0x36C0790", VA = "0x36C0790")]
	public void Term()
	{
	}

	[Token(Token = "0x60190F5")]
	[Address(RVA = "0x36C0818", Offset = "0x36C0818", VA = "0x36C0818")]
	public uint Length()
	{
		return default(uint);
	}

	[Token(Token = "0x60190F6")]
	[Address(RVA = "0x36C08A0", Offset = "0x36C08A0", VA = "0x36C08A0")]
	public AkPlaylistItem Data()
	{
		return null;
	}

	[Token(Token = "0x60190F7")]
	[Address(RVA = "0x36C0974", Offset = "0x36C0974", VA = "0x36C0974")]
	public bool IsEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x60190F8")]
	[Address(RVA = "0x36C09FC", Offset = "0x36C09FC", VA = "0x36C09FC")]
	public AkPlaylistItem Exists(AkPlaylistItem in_Item)
	{
		return null;
	}

	[Token(Token = "0x60190F9")]
	[Address(RVA = "0x36C0B20", Offset = "0x36C0B20", VA = "0x36C0B20")]
	public AkPlaylistItem AddLast()
	{
		return null;
	}

	[Token(Token = "0x60190FA")]
	[Address(RVA = "0x36C0BF4", Offset = "0x36C0BF4", VA = "0x36C0BF4")]
	public AkPlaylistItem AddLast(AkPlaylistItem in_rItem)
	{
		return null;
	}

	[Token(Token = "0x60190FB")]
	[Address(RVA = "0x36C0D18", Offset = "0x36C0D18", VA = "0x36C0D18")]
	public AkPlaylistItem Last()
	{
		return null;
	}

	[Token(Token = "0x60190FC")]
	[Address(RVA = "0x36C0DD4", Offset = "0x36C0DD4", VA = "0x36C0DD4")]
	public void RemoveLast()
	{
	}

	[Token(Token = "0x60190FD")]
	[Address(RVA = "0x36C0E5C", Offset = "0x36C0E5C", VA = "0x36C0E5C")]
	public AKRESULT Remove(AkPlaylistItem in_rItem)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60190FE")]
	[Address(RVA = "0x36C0F34", Offset = "0x36C0F34", VA = "0x36C0F34")]
	public AKRESULT RemoveSwap(AkPlaylistItem in_rItem)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60190FF")]
	[Address(RVA = "0x36C100C", Offset = "0x36C100C", VA = "0x36C100C")]
	public void RemoveAll()
	{
	}

	[Token(Token = "0x6019100")]
	[Address(RVA = "0x36C1094", Offset = "0x36C1094", VA = "0x36C1094")]
	public AkPlaylistItem ItemAtIndex(uint uiIndex)
	{
		return null;
	}

	[Token(Token = "0x6019101")]
	[Address(RVA = "0x36C1158", Offset = "0x36C1158", VA = "0x36C1158")]
	public AkPlaylistItem Insert(uint in_uIndex)
	{
		return null;
	}

	[Token(Token = "0x6019102")]
	[Address(RVA = "0x36C1234", Offset = "0x36C1234", VA = "0x36C1234")]
	public bool GrowArray(uint in_uGrowBy)
	{
		return default(bool);
	}

	[Token(Token = "0x6019103")]
	[Address(RVA = "0x36C12C4", Offset = "0x36C12C4", VA = "0x36C12C4")]
	public bool GrowArray()
	{
		return default(bool);
	}

	[Token(Token = "0x6019104")]
	[Address(RVA = "0x36C134C", Offset = "0x36C134C", VA = "0x36C134C")]
	public bool Resize(uint in_uiSize)
	{
		return default(bool);
	}

	[Token(Token = "0x6019105")]
	[Address(RVA = "0x36C13DC", Offset = "0x36C13DC", VA = "0x36C13DC")]
	public void Transfer(AkPlaylistArray in_rSource)
	{
	}

	[Token(Token = "0x6019106")]
	[Address(RVA = "0x36C14B4", Offset = "0x36C14B4", VA = "0x36C14B4")]
	public AKRESULT Copy(AkPlaylistArray in_rSource)
	{
		return default(AKRESULT);
	}
}
