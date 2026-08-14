using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FA0")]
public class HeadPicBaseInfo : CollectionBaseInfo, _Attribute
{
	[Token(Token = "0x401227A")]
	[FieldOffset(Offset = "0x20")]
	public uint headpic_id;

	[Token(Token = "0x401227B")]
	[FieldOffset(Offset = "0x24")]
	public HeadPicData headpic_data;

	[Token(Token = "0x401227C")]
	[FieldOffset(Offset = "0x28")]
	public Item headpic_item;

	[Token(Token = "0x6013E8B")]
	[Address(RVA = "0x190C3D0", Offset = "0x190C3D0", VA = "0x190C3D0")]
	public HeadPicBaseInfo()
	{
	}

	[Token(Token = "0x6013E8C")]
	[Address(RVA = "0x190C3D8", Offset = "0x190C3D8", VA = "0x190C3D8")]
	public HeadPicBaseInfo(uint headpicId)
	{
	}

	[Token(Token = "0x6013E8D")]
	[Address(RVA = "0x190C6B0", Offset = "0x190C6B0", VA = "0x190C6B0")]
	public static implicit operator HeadPicBaseInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6013E8E")]
	[Address(RVA = "0x190C77C", Offset = "0x190C77C", VA = "0x190C77C")]
	public static implicit operator HeadPicBaseInfo(HeadPicData pd)
	{
		return null;
	}

	[Token(Token = "0x6013E8F")]
	[Address(RVA = "0x190C848", Offset = "0x190C848", VA = "0x190C848", Slot = "5")]
	public override uint GetCurrentId()
	{
		return default(uint);
	}

	[Token(Token = "0x6013E90")]
	[Address(RVA = "0x190C980", Offset = "0x190C980", VA = "0x190C980", Slot = "6")]
	public int CompareTo(HeadPicBaseInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x6013E91")]
	[Address(RVA = "0x190C9F0", Offset = "0x190C9F0", VA = "0x190C9F0")]
	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return default(uint);
	}
}
