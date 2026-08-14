using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FA8")]
public class WeaponSkinBaseInfo : CollectionBaseInfo
{
	[Token(Token = "0x401228A")]
	[FieldOffset(Offset = "0x20")]
	public WeaponSkinData weapon_skin_data;

	[Token(Token = "0x401228B")]
	[FieldOffset(Offset = "0x24")]
	public uint weapon_id;

	[Token(Token = "0x6013EBF")]
	[Address(RVA = "0x21A6228", Offset = "0x21A6228", VA = "0x21A6228")]
	public WeaponSkinBaseInfo()
	{
	}

	[Token(Token = "0x6013EC0")]
	[Address(RVA = "0x21A6230", Offset = "0x21A6230", VA = "0x21A6230")]
	public WeaponSkinBaseInfo(uint itemid)
	{
	}

	[Token(Token = "0x6013EC1")]
	[Address(RVA = "0x21A6510", Offset = "0x21A6510", VA = "0x21A6510")]
	public static implicit operator WeaponSkinBaseInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6013EC2")]
	[Address(RVA = "0x21A65DC", Offset = "0x21A65DC", VA = "0x21A65DC")]
	public static implicit operator WeaponSkinBaseInfo(WeaponSkinData data)
	{
		return null;
	}

	[Token(Token = "0x6013EC3")]
	[Address(RVA = "0x21A66A8", Offset = "0x21A66A8", VA = "0x21A66A8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6013EC4")]
	[Address(RVA = "0x21A69B0", Offset = "0x21A69B0", VA = "0x21A69B0")]
	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
