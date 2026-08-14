using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003156")]
public class MapOpeningInfo
{
	[Token(Token = "0x4012B97")]
	[FieldOffset(Offset = "0x8")]
	public MapConfigData MapConfigData;

	[Token(Token = "0x4012B98")]
	[FieldOffset(Offset = "0x10")]
	public DateTime StartTimeInDay;

	[Token(Token = "0x4012B99")]
	[FieldOffset(Offset = "0x20")]
	public uint[] Weekdays;

	[Token(Token = "0x4012B9A")]
	[FieldOffset(Offset = "0x28")]
	public DateTime EndTimeInDay;

	[Token(Token = "0x4012B9B")]
	[FieldOffset(Offset = "0x38")]
	public string Tips;

	[Token(Token = "0x4012B9C")]
	[FieldOffset(Offset = "0x3C")]
	public uint MatchMode;

	[Token(Token = "0x4012B9D")]
	[FieldOffset(Offset = "0x40")]
	public uint InfoUniqueID;

	[Token(Token = "0x4012B9E")]
	[FieldOffset(Offset = "0x44")]
	public bool IsNew;

	[Token(Token = "0x4012B9F")]
	[FieldOffset(Offset = "0x45")]
	public bool IsPermanent;

	[Token(Token = "0x4012BA0")]
	[FieldOffset(Offset = "0x46")]
	public bool ForceAutoMatch;

	[Token(Token = "0x4012BA1")]
	[FieldOffset(Offset = "0x48")]
	public uint LevelVisualStyle;

	[Token(Token = "0x4012BA2")]
	[FieldOffset(Offset = "0x4C")]
	public uint[] playerCounts;

	[Token(Token = "0x4012BA3")]
	[FieldOffset(Offset = "0x50")]
	public DateTime ConfigStartTime;

	[Token(Token = "0x4012BA4")]
	[FieldOffset(Offset = "0x60")]
	public DateTime ConfigEndTime;

	[Token(Token = "0x4012BA5")]
	[FieldOffset(Offset = "0x70")]
	public uint SortId;

	[Token(Token = "0x4012BA6")]
	[FieldOffset(Offset = "0x74")]
	public List<int> difficulty;

	[Token(Token = "0x4012BA7")]
	[FieldOffset(Offset = "0x78")]
	public uint tag;

	[Token(Token = "0x4012BA8")]
	[FieldOffset(Offset = "0x7C")]
	public string visualMapUrl;

	[Token(Token = "0x4012BA9")]
	[FieldOffset(Offset = "0x80")]
	public string visualMapUrl02;

	[Token(Token = "0x4012BAA")]
	[FieldOffset(Offset = "0x84")]
	public string tutorialUrl;

	[Token(Token = "0x4012BAB")]
	[FieldOffset(Offset = "0x88")]
	public string awardUrl;

	[Token(Token = "0x4012BAC")]
	[FieldOffset(Offset = "0x8C")]
	public string[] version;

	[Token(Token = "0x4012BAD")]
	[FieldOffset(Offset = "0x90")]
	public bool is_random;

	[Token(Token = "0x4012BAE")]
	[FieldOffset(Offset = "0x94")]
	public string match_mode_image;

	[Token(Token = "0x4012BAF")]
	[FieldOffset(Offset = "0x98")]
	public bool is_force_random;

	[Token(Token = "0x4012BB0")]
	[FieldOffset(Offset = "0x99")]
	public bool is_live_open;

	[Token(Token = "0x4012BB1")]
	[FieldOffset(Offset = "0x9C")]
	public uint live_effects_id;

	[Token(Token = "0x4012BB2")]
	[FieldOffset(Offset = "0xA0")]
	public bool max_only;

	[Token(Token = "0x4012BB3")]
	[FieldOffset(Offset = "0xA8")]
	private DateTime m_Date;

	[Token(Token = "0x4012BB4")]
	[FieldOffset(Offset = "0x0")]
	private static Func<string, uint> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x4012BB5")]
	[FieldOffset(Offset = "0x4")]
	private static Func<string, uint> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x6014AD1")]
	[Address(RVA = "0x1535A38", Offset = "0x1535A38", VA = "0x1535A38")]
	public MapOpeningInfo()
	{
	}

	[Token(Token = "0x6014AD2")]
	[Address(RVA = "0x1535C08", Offset = "0x1535C08", VA = "0x1535C08")]
	public static implicit operator MapOpeningInfo(GameOpeningInfoDesc desc)
	{
		return null;
	}
}
