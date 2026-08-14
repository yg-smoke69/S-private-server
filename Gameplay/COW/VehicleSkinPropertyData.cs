using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200025E")]
public class VehicleSkinPropertyData : CSVBaseData
{
	[Token(Token = "0x4000E53")]
	[FieldOffset(Offset = "0x8")]
	public uint SkinID;

	[Token(Token = "0x4000E54")]
	[FieldOffset(Offset = "0xC")]
	public uint VehicleID;

	[Token(Token = "0x4000E55")]
	[FieldOffset(Offset = "0x10")]
	public string Region;

	[Token(Token = "0x4000E56")]
	[FieldOffset(Offset = "0x14")]
	public bool IsTaillight;

	[Token(Token = "0x4000E57")]
	[FieldOffset(Offset = "0x18")]
	public string HornAudioRes;

	[Token(Token = "0x4000E58")]
	[FieldOffset(Offset = "0x1C")]
	public string StartSoundRes;

	[Token(Token = "0x4000E59")]
	[FieldOffset(Offset = "0x20")]
	public string ShiftSoundRes;

	[Token(Token = "0x4000E5A")]
	[FieldOffset(Offset = "0x24")]
	public string HighAccRes;

	[Token(Token = "0x4000E5B")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<string, TssSdtFloat> Params;

	[Token(Token = "0x4000E5C")]
	public const string PROPERTYTYPE_MAXSPEED = "max_speed";

	[Token(Token = "0x4000E5D")]
	public const string PROPERTYTYPE_REDUCEDAMGE = "reduce_damage";

	[Token(Token = "0x4000E5E")]
	public const string PROPERTYTYPE_HIGHTSPEEDANGLE = "high_speed_steerangle";

	[Token(Token = "0x4000E5F")]
	public const string PROPERTYTYPE_ENGINETORQUE = "engine_torque";

	[Token(Token = "0x4000E60")]
	public const string PROPERTYTYPE_BRAKETORQUE = "brake_torque";

	[Token(Token = "0x4000E61")]
	public const string PROPERTYTYPE_BOOSTDURATION = "boost_duration";

	[Token(Token = "0x4000E62")]
	public const string PROPERTYTYPE_BOOSTCD = "boost_cd";

	[Token(Token = "0x4000E63")]
	public const string PROPERTYTYPE_JUMPHEIGHT = "jump_height";

	[Token(Token = "0x4000E64")]
	public const string PROPERTYTYPE_JUMPCD = "jump_cd";

	[Token(Token = "0x4000E65")]
	public const string PROPERTYTYPE_ENABLEMARK = "mark_leave";

	[Token(Token = "0x4000E66")]
	public const string PROPERTYTYPE_MESSFACTOR = "mess_factor";

	[Token(Token = "0x4000E67")]
	[FieldOffset(Offset = "0x0")]
	public static string[] PROPERTYTYPE_SHOWLIST;

	[Token(Token = "0x4000E68")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map1;

	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0x219ED48", Offset = "0x219ED48", VA = "0x219ED48")]
	public VehicleSkinPropertyData()
	{
	}

	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0x219EE38", Offset = "0x219EE38", VA = "0x219EE38", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x219EF2C", Offset = "0x219EF2C", VA = "0x219EF2C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
