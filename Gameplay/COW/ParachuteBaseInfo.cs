using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FA4")]
public class ParachuteBaseInfo : CollectionBaseInfo, _Attribute
{
	[Token(Token = "0x4012286")]
	[FieldOffset(Offset = "0x20")]
	public ParachuteData parachute_data;

	[Token(Token = "0x6013EA3")]
	[Address(RVA = "0x28CEF40", Offset = "0x28CEF40", VA = "0x28CEF40")]
	public ParachuteBaseInfo()
	{
	}

	[Token(Token = "0x6013EA4")]
	[Address(RVA = "0x28CEF48", Offset = "0x28CEF48", VA = "0x28CEF48")]
	public ParachuteBaseInfo(uint itemid)
	{
	}

	[Token(Token = "0x6013EA5")]
	[Address(RVA = "0x28CF21C", Offset = "0x28CF21C", VA = "0x28CF21C")]
	public static implicit operator ParachuteBaseInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6013EA6")]
	[Address(RVA = "0x28CF2E8", Offset = "0x28CF2E8", VA = "0x28CF2E8")]
	public static implicit operator ParachuteBaseInfo(ParachuteData data)
	{
		return null;
	}

	[Token(Token = "0x6013EA7")]
	[Address(RVA = "0x28CF3B4", Offset = "0x28CF3B4", VA = "0x28CF3B4", Slot = "5")]
	public override uint GetCurrentId()
	{
		return default(uint);
	}

	[Token(Token = "0x6013EA8")]
	[Address(RVA = "0x28CF4EC", Offset = "0x28CF4EC", VA = "0x28CF4EC", Slot = "6")]
	public int CompareTo(ParachuteBaseInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x6013EA9")]
	[Address(RVA = "0x28CF55C", Offset = "0x28CF55C", VA = "0x28CF55C")]
	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return default(uint);
	}
}
