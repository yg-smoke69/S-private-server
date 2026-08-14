using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200292B")]
public class MapModeData : _Attribute
{
	[Token(Token = "0x400FD80")]
	[FieldOffset(Offset = "0x8")]
	public uint match_mode;

	[Token(Token = "0x400FD81")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400FD82")]
	[FieldOffset(Offset = "0x10")]
	public uint map_mode;

	[Token(Token = "0x400FD83")]
	[FieldOffset(Offset = "0x14")]
	public uint info_id;

	[Token(Token = "0x400FD84")]
	[FieldOffset(Offset = "0x18")]
	public string bg_sprite;

	[Token(Token = "0x400FD85")]
	[FieldOffset(Offset = "0x1C")]
	public bool is_new;

	[Token(Token = "0x400FD86")]
	[FieldOffset(Offset = "0x1D")]
	public bool force_autoMatch;

	[Token(Token = "0x400FD87")]
	[FieldOffset(Offset = "0x20")]
	public uint config_id;

	[Token(Token = "0x400FD88")]
	[FieldOffset(Offset = "0x24")]
	public uint level_visual_style;

	[Token(Token = "0x400FD89")]
	[FieldOffset(Offset = "0x28")]
	public List<int> difficulty;

	[Token(Token = "0x400FD8A")]
	[FieldOffset(Offset = "0x2C")]
	public uint sort_id;

	[Token(Token = "0x400FD8B")]
	[FieldOffset(Offset = "0x30")]
	public uint tag;

	[Token(Token = "0x400FD8C")]
	[FieldOffset(Offset = "0x34")]
	public string visualMapUrl;

	[Token(Token = "0x400FD8D")]
	[FieldOffset(Offset = "0x38")]
	public string visualMapUrl02;

	[Token(Token = "0x400FD8E")]
	[FieldOffset(Offset = "0x3C")]
	public string tutorialUrl;

	[Token(Token = "0x400FD8F")]
	[FieldOffset(Offset = "0x40")]
	public string awardUrl;

	[Token(Token = "0x400FD90")]
	[FieldOffset(Offset = "0x44")]
	public bool IsSpecialMode;

	[Token(Token = "0x400FD91")]
	[FieldOffset(Offset = "0x45")]
	public bool IsMapRandom;

	[Token(Token = "0x400FD92")]
	[FieldOffset(Offset = "0x48")]
	public string match_mode_image;

	[Token(Token = "0x400FD93")]
	[FieldOffset(Offset = "0x4C")]
	public bool IsLiveOpen;

	[Token(Token = "0x400FD94")]
	[FieldOffset(Offset = "0x50")]
	public uint LiveEffectsID;

	[Token(Token = "0x400FD95")]
	[FieldOffset(Offset = "0x54")]
	public bool MAXOnly;

	[Token(Token = "0x60105BB")]
	[Address(RVA = "0x15352DC", Offset = "0x15352DC", VA = "0x15352DC")]
	public MapModeData(uint matchMode, uint gameMode, uint mapMode, string spriteName, uint sortId)
	{
	}

	[Token(Token = "0x60105BC")]
	[Address(RVA = "0x15353C0", Offset = "0x15353C0", VA = "0x15353C0", Slot = "4")]
	public int CompareTo(MapModeData other)
	{
		return default(int);
	}

	[Token(Token = "0x60105BD")]
	[Address(RVA = "0x153549C", Offset = "0x153549C", VA = "0x153549C")]
	public static implicit operator MapModeData(MapOpeningInfo openInfo)
	{
		return null;
	}
}
