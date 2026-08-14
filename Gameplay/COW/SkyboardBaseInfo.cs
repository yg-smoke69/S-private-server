using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FA5")]
public class SkyboardBaseInfo : CollectionBaseInfo, _Attribute
{
	[Token(Token = "0x4012287")]
	[FieldOffset(Offset = "0x20")]
	public SkyboardData skyboard_data;

	[Token(Token = "0x6013EAA")]
	[Address(RVA = "0x20F0A10", Offset = "0x20F0A10", VA = "0x20F0A10")]
	public SkyboardBaseInfo()
	{
	}

	[Token(Token = "0x6013EAB")]
	[Address(RVA = "0x20F0A18", Offset = "0x20F0A18", VA = "0x20F0A18")]
	public SkyboardBaseInfo(uint itemid)
	{
	}

	[Token(Token = "0x6013EAC")]
	[Address(RVA = "0x20F0CF4", Offset = "0x20F0CF4", VA = "0x20F0CF4")]
	public static implicit operator SkyboardBaseInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6013EAD")]
	[Address(RVA = "0x20F0DC0", Offset = "0x20F0DC0", VA = "0x20F0DC0")]
	public static implicit operator SkyboardBaseInfo(SkyboardData data)
	{
		return null;
	}

	[Token(Token = "0x6013EAE")]
	[Address(RVA = "0x20F0E8C", Offset = "0x20F0E8C", VA = "0x20F0E8C", Slot = "5")]
	public override uint GetCurrentId()
	{
		return default(uint);
	}

	[Token(Token = "0x6013EAF")]
	[Address(RVA = "0x20F0FC4", Offset = "0x20F0FC4", VA = "0x20F0FC4", Slot = "6")]
	public int CompareTo(SkyboardBaseInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x6013EB0")]
	[Address(RVA = "0x20F1034", Offset = "0x20F1034", VA = "0x20F1034")]
	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return default(uint);
	}
}
