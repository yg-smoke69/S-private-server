using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002E7C")]
public class UIModeEditManager : SingletonModule<UIModeEditManager>
{
	[Token(Token = "0x4011BCC")]
	[FieldOffset(Offset = "0xC")]
	public SceneEditModeSelect SceneEditModeSelectSO;

	[Token(Token = "0x4011BCD")]
	[FieldOffset(Offset = "0x10")]
	public SceneEditGeneralSetting GeneralModeSettingSO;

	[Token(Token = "0x4011BCE")]
	[FieldOffset(Offset = "0x14")]
	public SceneEditCSMode CSModeSettingSO;

	[Token(Token = "0x4011BCF")]
	[FieldOffset(Offset = "0x18")]
	public SceneEditIntegralMode IntegralModeSettingSO;

	[Token(Token = "0x4011BD0")]
	[FieldOffset(Offset = "0x1C")]
	public SceneEditPartyMode PartyModeSettingSO;

	[Token(Token = "0x4011BD1")]
	[FieldOffset(Offset = "0x20")]
	public ModeVariables CustomModeSettingVariables;

	[Token(Token = "0x4011BD2")]
	[FieldOffset(Offset = "0x24")]
	public UIModeEditData CustomModeSetting;

	[Token(Token = "0x4011BD3")]
	[FieldOffset(Offset = "0x28")]
	public ModeVariables ClassicModeSettingVariables;

	[Token(Token = "0x4011BD4")]
	[FieldOffset(Offset = "0x2C")]
	public UIModeEditData ClassicModeSetting;

	[Token(Token = "0x4011BD5")]
	[FieldOffset(Offset = "0x30")]
	public List<WorkShopSkillEditListData> SkillCDRule;

	[Token(Token = "0x60136B0")]
	[Address(RVA = "0x1310D34", Offset = "0x1310D34", VA = "0x1310D34")]
	public UIModeEditManager()
	{
	}

	[Token(Token = "0x60136B1")]
	[Address(RVA = "0x1310DF8", Offset = "0x1310DF8", VA = "0x1310DF8", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60136B2")]
	[Address(RVA = "0x13119D8", Offset = "0x13119D8", VA = "0x13119D8", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60136B3")]
	[Address(RVA = "0x1311AAC", Offset = "0x1311AAC", VA = "0x1311AAC")]
	public List<uint> GenerateModeTags(JOKABEAPNPP gameMode, HHDIPHFOBFO groupMode, uint teamCnt, bool limitedAmmo, bool autoHealing, float safeZoneStartTime, float safeZoneStartTimeDefault, float safeZoneSize, float safeZoneSizeDefault, bool zeroCD)
	{
		return null;
	}
}
