using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200025A")]
public class VehicleParamConfig
{
	[Token(Token = "0x4000E45")]
	[FieldOffset(Offset = "0x8")]
	public VehicleConfig.CarCrashParam CrashParam;

	[Token(Token = "0x4000E46")]
	[FieldOffset(Offset = "0xC")]
	public VehicleConfig.CarExplodeParam ExplodeParam;

	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0x219B964", Offset = "0x219B964", VA = "0x219B964")]
	public VehicleParamConfig()
	{
	}
}
