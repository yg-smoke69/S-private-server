using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x20032A2")]
public class UIModelUGCModeEdit : UIBaseModel
{
	[Token(Token = "0x401346E")]
	[FieldOffset(Offset = "0xC")]
	public ToggleButtonGroupRuleSetting CurrentGameMode;

	[Token(Token = "0x401346F")]
	[FieldOffset(Offset = "0x10")]
	public GeneralModeSetting GeneralModeSetting;

	[Token(Token = "0x4013470")]
	[FieldOffset(Offset = "0x14")]
	public CSModeSetting CSModeSetting;

	[Token(Token = "0x4013471")]
	[FieldOffset(Offset = "0x18")]
	public IntegralModeSetting IntegralModeSetting;

	[Token(Token = "0x4013472")]
	[FieldOffset(Offset = "0x1C")]
	public PartyModeSetting PartyModeSetting;

	[Token(Token = "0x4013473")]
	[FieldOffset(Offset = "0x20")]
	public UIModeEditData CurrentModeSetting;

	[Token(Token = "0x4013474")]
	[FieldOffset(Offset = "0x24")]
	public ModeDataModification Modification;

	[Token(Token = "0x6015568")]
	[Address(RVA = "0x169FAA4", Offset = "0x169FAA4", VA = "0x169FAA4")]
	public UIModelUGCModeEdit()
	{
	}

	[Token(Token = "0x6015569")]
	[Address(RVA = "0x169FC00", Offset = "0x169FC00", VA = "0x169FC00", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x601556A")]
	[Address(RVA = "0x169FC58", Offset = "0x169FC58", VA = "0x169FC58", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x601556B")]
	[Address(RVA = "0x16A0798", Offset = "0x16A0798", VA = "0x16A0798")]
	public FEIGJAGLKLM GetModeSettingProtoData()
	{
		return null;
	}

	[Token(Token = "0x601556C")]
	[Address(RVA = "0x16A09C8", Offset = "0x16A09C8", VA = "0x16A09C8")]
	public void BuildSettingFromModeWithTemplateSetting(uint mode, uint template)
	{
	}

	[Token(Token = "0x601556D")]
	[Address(RVA = "0x16A0CB8", Offset = "0x16A0CB8", VA = "0x16A0CB8")]
	public void BuildSettingFromProtoData(FEIGJAGLKLM protoData)
	{
	}

	[Token(Token = "0x601556E")]
	[Address(RVA = "0x16A0174", Offset = "0x16A0174", VA = "0x16A0174")]
	public void BuildSettingFromDefault(uint mapID)
	{
	}

	[Token(Token = "0x601556F")]
	[Address(RVA = "0x16A0FF0", Offset = "0x16A0FF0", VA = "0x16A0FF0")]
	public void GetRoundAndBattleStyleAndModeName(SceneEditSlotInfo slotInfo, out string round, out string battleStyle, out string modeName)
	{
	}

	[Token(Token = "0x6015570")]
	[Address(RVA = "0x16A1BA4", Offset = "0x16A1BA4", VA = "0x16A1BA4")]
	public List<uint> GenerateTagKeys()
	{
		return null;
	}

	[Token(Token = "0x6015571")]
	[Address(RVA = "0x16A27EC", Offset = "0x16A27EC", VA = "0x16A27EC")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
