using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FAB")]
public class GroupAnimBaseInfo : CollectionBaseInfo, _Attribute
{
	[Token(Token = "0x4012290")]
	[FieldOffset(Offset = "0x20")]
	public GroupAnimData group_anim_data;

	[Token(Token = "0x6013ED1")]
	[Address(RVA = "0x120F730", Offset = "0x120F730", VA = "0x120F730")]
	public GroupAnimBaseInfo()
	{
	}

	[Token(Token = "0x6013ED2")]
	[Address(RVA = "0x120F738", Offset = "0x120F738", VA = "0x120F738")]
	public GroupAnimBaseInfo(uint itemid)
	{
	}

	[Token(Token = "0x6013ED3")]
	[Address(RVA = "0x120FA0C", Offset = "0x120FA0C", VA = "0x120FA0C")]
	public static implicit operator GroupAnimBaseInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6013ED4")]
	[Address(RVA = "0x120FAD8", Offset = "0x120FAD8", VA = "0x120FAD8")]
	public static implicit operator GroupAnimBaseInfo(EmoteData data)
	{
		return null;
	}

	[Token(Token = "0x6013ED5")]
	[Address(RVA = "0x120FBA4", Offset = "0x120FBA4", VA = "0x120FBA4", Slot = "5")]
	public override uint GetCurrentId()
	{
		return default(uint);
	}

	[Token(Token = "0x6013ED6")]
	[Address(RVA = "0x120FCDC", Offset = "0x120FCDC", VA = "0x120FCDC", Slot = "6")]
	public int CompareTo(GroupAnimBaseInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x6013ED7")]
	[Address(RVA = "0x120FF54", Offset = "0x120FF54", VA = "0x120FF54")]
	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return default(uint);
	}
}
