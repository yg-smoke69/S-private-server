using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FAA")]
public class EmoteBaseInfo : CollectionBaseInfo, _Attribute
{
	[Token(Token = "0x401228E")]
	[FieldOffset(Offset = "0x20")]
	public EmoteData emote_data;

	[Token(Token = "0x401228F")]
	[FieldOffset(Offset = "0x24")]
	public uint emoteId;

	[Token(Token = "0x6013ECC")]
	[Address(RVA = "0x2530DC8", Offset = "0x2530DC8", VA = "0x2530DC8")]
	public EmoteBaseInfo()
	{
	}

	[Token(Token = "0x6013ECD")]
	[Address(RVA = "0x2530DD0", Offset = "0x2530DD0", VA = "0x2530DD0")]
	public EmoteBaseInfo(uint itemid)
	{
	}

	[Token(Token = "0x6013ECE")]
	[Address(RVA = "0x25310A4", Offset = "0x25310A4", VA = "0x25310A4")]
	public static implicit operator EmoteBaseInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6013ECF")]
	[Address(RVA = "0x2531170", Offset = "0x2531170", VA = "0x2531170")]
	public static implicit operator EmoteBaseInfo(EmoteData data)
	{
		return null;
	}

	[Token(Token = "0x6013ED0")]
	[Address(RVA = "0x253123C", Offset = "0x253123C", VA = "0x253123C", Slot = "6")]
	public int CompareTo(EmoteBaseInfo other)
	{
		return default(int);
	}
}
