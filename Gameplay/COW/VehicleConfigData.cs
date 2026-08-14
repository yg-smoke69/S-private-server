using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200025B")]
public class VehicleConfigData
{
	[Token(Token = "0x4000E47")]
	[FieldOffset(Offset = "0x8")]
	public EControlMode ControlMode;

	[Token(Token = "0x4000E48")]
	[FieldOffset(Offset = "0xC")]
	public RigidBodyConfig RigidConfig;

	[Token(Token = "0x4000E49")]
	[FieldOffset(Offset = "0x10")]
	public VehicleParamConfig VehicleConfig;

	[Token(Token = "0x4000E4A")]
	[FieldOffset(Offset = "0x14")]
	public Dictionary<string, VehicleControllerInfo> ControllerConfigs;

	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0x219A9E8", Offset = "0x219A9E8", VA = "0x219A9E8")]
	public VehicleConfigData()
	{
	}
}
