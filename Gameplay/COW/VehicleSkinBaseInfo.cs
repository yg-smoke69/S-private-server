using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FA9")]
public class VehicleSkinBaseInfo : CollectionBaseInfo, _Attribute
{
	[Token(Token = "0x401228C")]
	[FieldOffset(Offset = "0x20")]
	public VehicleSkinData vehicle_skin_data;

	[Token(Token = "0x401228D")]
	[FieldOffset(Offset = "0x24")]
	public uint vehicle_id;

	[Token(Token = "0x6013EC5")]
	[Address(RVA = "0x219C7B8", Offset = "0x219C7B8", VA = "0x219C7B8")]
	public VehicleSkinBaseInfo()
	{
	}

	[Token(Token = "0x6013EC6")]
	[Address(RVA = "0x219C7C0", Offset = "0x219C7C0", VA = "0x219C7C0")]
	public VehicleSkinBaseInfo(uint itemid)
	{
	}

	[Token(Token = "0x6013EC7")]
	[Address(RVA = "0x219CAA4", Offset = "0x219CAA4", VA = "0x219CAA4")]
	public static implicit operator VehicleSkinBaseInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6013EC8")]
	[Address(RVA = "0x219CB70", Offset = "0x219CB70", VA = "0x219CB70")]
	public static implicit operator VehicleSkinBaseInfo(VehicleSkinData data)
	{
		return null;
	}

	[Token(Token = "0x6013EC9")]
	[Address(RVA = "0x219CC3C", Offset = "0x219CC3C", VA = "0x219CC3C", Slot = "5")]
	public override uint GetCurrentId()
	{
		return default(uint);
	}

	[Token(Token = "0x6013ECA")]
	[Address(RVA = "0x219CDA4", Offset = "0x219CDA4", VA = "0x219CDA4", Slot = "6")]
	public int CompareTo(VehicleSkinBaseInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x6013ECB")]
	[Address(RVA = "0x219CE14", Offset = "0x219CE14", VA = "0x219CE14")]
	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return default(uint);
	}
}
