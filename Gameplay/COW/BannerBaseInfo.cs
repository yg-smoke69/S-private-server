using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002F9F")]
public class BannerBaseInfo : CollectionBaseInfo, _Attribute
{
	[Token(Token = "0x4012277")]
	[FieldOffset(Offset = "0x20")]
	public uint banner_id;

	[Token(Token = "0x4012278")]
	[FieldOffset(Offset = "0x24")]
	public BannerData banner_data;

	[Token(Token = "0x4012279")]
	[FieldOffset(Offset = "0x28")]
	public Item banner_item;

	[Token(Token = "0x6013E84")]
	[Address(RVA = "0x2E50624", Offset = "0x2E50624", VA = "0x2E50624")]
	public BannerBaseInfo()
	{
	}

	[Token(Token = "0x6013E85")]
	[Address(RVA = "0x2E5062C", Offset = "0x2E5062C", VA = "0x2E5062C")]
	public BannerBaseInfo(uint bannerId)
	{
	}

	[Token(Token = "0x6013E86")]
	[Address(RVA = "0x2E50900", Offset = "0x2E50900", VA = "0x2E50900")]
	public static implicit operator BannerBaseInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6013E87")]
	[Address(RVA = "0x2E509CC", Offset = "0x2E509CC", VA = "0x2E509CC")]
	public static implicit operator BannerBaseInfo(BannerData bd)
	{
		return null;
	}

	[Token(Token = "0x6013E88")]
	[Address(RVA = "0x2E50A98", Offset = "0x2E50A98", VA = "0x2E50A98", Slot = "5")]
	public override uint GetCurrentId()
	{
		return default(uint);
	}

	[Token(Token = "0x6013E89")]
	[Address(RVA = "0x2E50BD0", Offset = "0x2E50BD0", VA = "0x2E50BD0", Slot = "6")]
	public int CompareTo(BannerBaseInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x6013E8A")]
	[Address(RVA = "0x2E50C40", Offset = "0x2E50C40", VA = "0x2E50C40")]
	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return default(uint);
	}
}
