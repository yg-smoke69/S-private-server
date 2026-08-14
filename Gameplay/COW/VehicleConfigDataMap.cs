using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200025C")]
public class VehicleConfigDataMap
{
	[Token(Token = "0x4000E4B")]
	[FieldOffset(Offset = "0x8")]
	public Dictionary<string, VehicleConfigData> Vehicles;

	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x219B5D8", Offset = "0x219B5D8", VA = "0x219B5D8")]
	public VehicleConfigDataMap()
	{
	}
}
