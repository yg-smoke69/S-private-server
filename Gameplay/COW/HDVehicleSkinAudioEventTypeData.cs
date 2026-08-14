using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000150")]
public class HDVehicleSkinAudioEventTypeData : CSVBaseData
{
	[Token(Token = "0x4000875")]
	[FieldOffset(Offset = "0x8")]
	public uint SkinID;

	[Token(Token = "0x4000876")]
	[FieldOffset(Offset = "0xC")]
	public uint VehicleID;

	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0x10")]
	public string HDDriveStartRes;

	[Token(Token = "0x4000878")]
	[FieldOffset(Offset = "0x14")]
	public string HDDriveMergeRes;

	[Token(Token = "0x4000879")]
	[FieldOffset(Offset = "0x18")]
	public string HDRoadNoiseRes;

	[Token(Token = "0x400087A")]
	[FieldOffset(Offset = "0x1C")]
	public string HDStopRes;

	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x1212C64", Offset = "0x1212C64", VA = "0x1212C64")]
	public HDVehicleSkinAudioEventTypeData()
	{
	}

	[Token(Token = "0x60007DF")]
	[Address(RVA = "0x1212D54", Offset = "0x1212D54", VA = "0x1212D54", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x1212DB8", Offset = "0x1212DB8", VA = "0x1212DB8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
