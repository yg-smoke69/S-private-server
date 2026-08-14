using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200195D")]
public class CSGetDigitaluniverseSettingsBRes
{
	[Token(Token = "0x4009F83")]
	[FieldOffset(Offset = "0x8")]
	public DigitaluniverseBSettingDesc main_setting;

	[Token(Token = "0x4009F84")]
	[FieldOffset(Offset = "0xC")]
	public List<DigitaluniverseBCharMissionDesc> charactergate_missions;

	[Token(Token = "0x4009F85")]
	[FieldOffset(Offset = "0x10")]
	public List<DigitaluniverseBCharStoryDesc> charactergate_storys;

	[Token(Token = "0x4009F86")]
	[FieldOffset(Offset = "0x14")]
	public List<DigitaluniverseBMissionRewardDesc> mission_awards;

	[Token(Token = "0x4009F87")]
	[FieldOffset(Offset = "0x18")]
	public List<DigitaluniverseBMapMissionDesc> mapgate_missions;

	[Token(Token = "0x4009F88")]
	[FieldOffset(Offset = "0x1C")]
	public List<DigitaluniverseBStoreRecommendDesc> store_recommends;

	[Token(Token = "0x4009F89")]
	[FieldOffset(Offset = "0x20")]
	public List<DigitaluniverseBSpecialEntranceDesc> special_entrances;

	[Token(Token = "0x4009F8A")]
	[FieldOffset(Offset = "0x24")]
	public List<DigitaluniverseBCoreRulesDesc> core_rules;

	[Token(Token = "0x4009F8B")]
	[FieldOffset(Offset = "0x28")]
	public List<DigitaluniverseBThreeDesc> three_descs;

	[Token(Token = "0x4009F8C")]
	[FieldOffset(Offset = "0x2C")]
	public List<DigitaluniverseBPostcardDesc> postcards;

	[Token(Token = "0x4009F8D")]
	[FieldOffset(Offset = "0x30")]
	public List<DigitaluniverseBStarCraftValueDesc> star_craft_value_descs;

	[Token(Token = "0x4009F8E")]
	[FieldOffset(Offset = "0x34")]
	public DigitaluniverseBStarCraftConfigDesc star_craft_config_desc;

	[Token(Token = "0x4009F8F")]
	[FieldOffset(Offset = "0x38")]
	public List<DigitaluniverseBStarCraftCdFreshDesc> star_craft_cd_fresh_descs;

	[Token(Token = "0x4009F90")]
	[FieldOffset(Offset = "0x3C")]
	public List<DigitaluniverseBStarCraftTargetDesc> star_craft_target_descs;

	[Token(Token = "0x6007FB6")]
	[Address(RVA = "0x3183ED8", Offset = "0x3183ED8", VA = "0x3183ED8")]
	public CSGetDigitaluniverseSettingsBRes()
	{
	}
}
