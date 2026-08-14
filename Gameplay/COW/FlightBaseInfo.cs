using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FA6")]
public class FlightBaseInfo : CollectionBaseInfo, _Attribute
{
	[Token(Token = "0x4012288")]
	[FieldOffset(Offset = "0x20")]
	public FlightData flight_data;

	[Token(Token = "0x6013EB1")]
	[Address(RVA = "0xDEC058", Offset = "0xDEC058", VA = "0xDEC058")]
	public FlightBaseInfo()
	{
	}

	[Token(Token = "0x6013EB2")]
	[Address(RVA = "0xDEC060", Offset = "0xDEC060", VA = "0xDEC060")]
	public FlightBaseInfo(uint itemid)
	{
	}

	[Token(Token = "0x6013EB3")]
	[Address(RVA = "0xDEC334", Offset = "0xDEC334", VA = "0xDEC334")]
	public static implicit operator FlightBaseInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6013EB4")]
	[Address(RVA = "0xDEC400", Offset = "0xDEC400", VA = "0xDEC400")]
	public static implicit operator FlightBaseInfo(SkyboardData data)
	{
		return null;
	}

	[Token(Token = "0x6013EB5")]
	[Address(RVA = "0xDEC4CC", Offset = "0xDEC4CC", VA = "0xDEC4CC", Slot = "5")]
	public override uint GetCurrentId()
	{
		return default(uint);
	}

	[Token(Token = "0x6013EB6")]
	[Address(RVA = "0xDEC604", Offset = "0xDEC604", VA = "0xDEC604", Slot = "6")]
	public int CompareTo(FlightBaseInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x6013EB7")]
	[Address(RVA = "0xDEC674", Offset = "0xDEC674", VA = "0xDEC674")]
	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return default(uint);
	}
}
