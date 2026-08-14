using Il2CppDummyDll;

[Token(Token = "0x2003D08")]
public class VehicleControllerInfo
{
	[Token(Token = "0x4019E68")]
	[FieldOffset(Offset = "0x8")]
	public int WheelTypeChoise;

	[Token(Token = "0x4019E69")]
	[FieldOffset(Offset = "0xC")]
	public float maxEngineRPM;

	[Token(Token = "0x4019E6A")]
	[FieldOffset(Offset = "0x10")]
	public float minEngineRPM;

	[Token(Token = "0x4019E6B")]
	[FieldOffset(Offset = "0x14")]
	public float engineTorque;

	[Token(Token = "0x4019E6C")]
	[FieldOffset(Offset = "0x18")]
	public float brakeTorque;

	[Token(Token = "0x4019E6D")]
	[FieldOffset(Offset = "0x1C")]
	public float gearShiftingDelay;

	[Token(Token = "0x4019E6E")]
	[FieldOffset(Offset = "0x20")]
	public float maxspeed;

	[Token(Token = "0x4019E6F")]
	[FieldOffset(Offset = "0x24")]
	public float defMaxspeed;

	[Token(Token = "0x4019E70")]
	[FieldOffset(Offset = "0x28")]
	public float idleBrakeInput;

	[Token(Token = "0x4019E71")]
	[FieldOffset(Offset = "0x2C")]
	public float highSpeedSteerAngle;

	[Token(Token = "0x4019E72")]
	[FieldOffset(Offset = "0x30")]
	public float highSpeedSteerAngleAtSpeed;

	[Token(Token = "0x6018704")]
	[Address(RVA = "0x2A69290", Offset = "0x2A69290", VA = "0x2A69290")]
	public VehicleControllerInfo()
	{
	}

	[Token(Token = "0x6018705")]
	[Address(RVA = "0x2A69298", Offset = "0x2A69298", VA = "0x2A69298")]
	public VehicleControllerInfo Clone()
	{
		return null;
	}
}
