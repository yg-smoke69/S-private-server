using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000C4C")]
public class GlobalEntity : _Attribute
{
	[Token(Token = "0x4006531")]
	[FieldOffset(Offset = "0x8")]
	private string _entityID;

	[Token(Token = "0x4006532")]
	[FieldOffset(Offset = "0xC")]
	private UGCCustomizeRepDataSyncManager _repDataMgr;

	[Token(Token = "0x4006533")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool, bool> OnEnableChangeEvent;

	[Token(Token = "0x4006534")]
	[FieldOffset(Offset = "0x14")]
	public Action<int, int> OnModeTemplateIDChangeEvent;

	[Token(Token = "0x4006535")]
	[FieldOffset(Offset = "0x18")]
	public Action<bool, bool> OnHumanCanReviveChangeEvent;

	[Token(Token = "0x4006536")]
	[FieldOffset(Offset = "0x1C")]
	public Action<bool, bool> OnBotCanReviveChangeEvent;

	[Token(Token = "0x4006537")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int> OnReviveCDTimeChangeEvent;

	[Token(Token = "0x4006538")]
	[FieldOffset(Offset = "0x24")]
	public Action<int, int> OnTeamNumChangeEvent;

	[Token(Token = "0x4006539")]
	[FieldOffset(Offset = "0x28")]
	public Action<int, int> OnTeamMemberNumChangeEvent;

	[Token(Token = "0x400653A")]
	[FieldOffset(Offset = "0x2C")]
	public Action<bool, bool> OnResetEquipmentChangeEvent;

	[Token(Token = "0x400653B")]
	[FieldOffset(Offset = "0x30")]
	public Action<bool, bool> OnSafeZoneEnabledChangeEvent;

	[Token(Token = "0x400653C")]
	[FieldOffset(Offset = "0x34")]
	public Action<float, float> OnSafeZoneSizeChangeEvent;

	[Token(Token = "0x400653D")]
	[FieldOffset(Offset = "0x38")]
	public Action<float, float> OnSafeZoneStartTimeChangeEvent;

	[Token(Token = "0x400653E")]
	[FieldOffset(Offset = "0x3C")]
	public Action<float, float> OnSafeZoneShrinkTimeChangeEvent;

	[Token(Token = "0x400653F")]
	[FieldOffset(Offset = "0x40")]
	public Action<float, float> OnSafeZoneDamageChangeEvent;

	[Token(Token = "0x4006540")]
	[FieldOffset(Offset = "0x44")]
	public Action<int, int> OnTargetScoreChangeEvent;

	[Token(Token = "0x4006541")]
	[FieldOffset(Offset = "0x48")]
	public Action<int, int> OnKillingScoreChangeEvent;

	[Token(Token = "0x4006542")]
	[FieldOffset(Offset = "0x4C")]
	public Action<int, int> OnReviveRuleChangeEvent;

	[Token(Token = "0x4006543")]
	[FieldOffset(Offset = "0x50")]
	public Action<List<object>, List<object>> OnPlayerRoundRankingRuleScoreTypeChangeEvent;

	[Token(Token = "0x4006544")]
	[FieldOffset(Offset = "0x54")]
	public Action<List<object>, List<object>> OnPlayerRoundRankingRuleSortTypeChangeEvent;

	[Token(Token = "0x4006545")]
	[FieldOffset(Offset = "0x58")]
	public Action<List<object>, List<object>> OnTeamRoundRankingRuleScoreTypeChangeEvent;

	[Token(Token = "0x4006546")]
	[FieldOffset(Offset = "0x5C")]
	public Action<List<object>, List<object>> OnTeamRoundRankingRuleSortTypeChangeEvent;

	[Token(Token = "0x4006547")]
	[FieldOffset(Offset = "0x60")]
	public Action<List<object>, List<object>> OnMVPRuleScoreTypeChangeEvent;

	[Token(Token = "0x4006548")]
	[FieldOffset(Offset = "0x64")]
	public Action<List<object>, List<object>> OnMVPRuleScoreWeightChangeEvent;

	[Token(Token = "0x4006549")]
	[FieldOffset(Offset = "0x68")]
	public Action<List<object>, List<object>> OnRoundRankToScoreMapChangeEvent;

	[Token(Token = "0x400654A")]
	[FieldOffset(Offset = "0x6C")]
	public Action<List<object>, List<object>> OnScoreTypeToShowResultChangeEvent;

	[Token(Token = "0x400654B")]
	[FieldOffset(Offset = "0x70")]
	public Action<int, int> OnSumRoundCountChangeEvent;

	[Token(Token = "0x400654C")]
	[FieldOffset(Offset = "0x74")]
	public Action<int, int> OnTeamRankAccumulateScoreTypeChangeEvent;

	[Token(Token = "0x400654D")]
	[FieldOffset(Offset = "0x78")]
	public Action<int, int> OnTeamRankAccumulateScoreOrderChangeEvent;

	[Token(Token = "0x400654E")]
	[FieldOffset(Offset = "0x7C")]
	public Action<int, int> OnPlayerRankAccumulateScoreTypeChangeEvent;

	[Token(Token = "0x400654F")]
	[FieldOffset(Offset = "0x80")]
	public Action<int, int> OnPlayerRankAccumulateScoreOrderChangeEvent;

	[Token(Token = "0x6005DE2")]
	[Address(RVA = "0x25919D8", Offset = "0x25919D8", VA = "0x25919D8")]
	public GlobalEntity(string entityID)
	{
	}

	[Token(Token = "0x6005DE3")]
	[Address(RVA = "0x2591AF0", Offset = "0x2591AF0", VA = "0x2591AF0", Slot = "4")]
	public string UGCEntityID()
	{
		return null;
	}

	[Token(Token = "0x6005DE4")]
	[Address(RVA = "0x2591B48", Offset = "0x2591B48", VA = "0x2591B48")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005DE5")]
	[Address(RVA = "0x2591C64", Offset = "0x2591C64", VA = "0x2591C64")]
	private void OnRepDataChangeHandle(int repDataIndex, object oldValue, object newValue)
	{
	}

	[Token(Token = "0x6005DE6")]
	[Address(RVA = "0x259303C", Offset = "0x259303C", VA = "0x259303C")]
	public bool Enable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DE7")]
	[Address(RVA = "0x259311C", Offset = "0x259311C", VA = "0x259311C")]
	public int ModeTemplateID()
	{
		return default(int);
	}

	[Token(Token = "0x6005DE8")]
	[Address(RVA = "0x25931F8", Offset = "0x25931F8", VA = "0x25931F8")]
	public bool HumanCanRevive()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DE9")]
	[Address(RVA = "0x25932D4", Offset = "0x25932D4", VA = "0x25932D4")]
	public bool BotCanRevive()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DEA")]
	[Address(RVA = "0x25933B0", Offset = "0x25933B0", VA = "0x25933B0")]
	public int ReviveCDTime()
	{
		return default(int);
	}

	[Token(Token = "0x6005DEB")]
	[Address(RVA = "0x259348C", Offset = "0x259348C", VA = "0x259348C")]
	public int TeamNum()
	{
		return default(int);
	}

	[Token(Token = "0x6005DEC")]
	[Address(RVA = "0x2593568", Offset = "0x2593568", VA = "0x2593568")]
	public int TeamMemberNum()
	{
		return default(int);
	}

	[Token(Token = "0x6005DED")]
	[Address(RVA = "0x2593644", Offset = "0x2593644", VA = "0x2593644")]
	public bool ResetEquipment()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DEE")]
	[Address(RVA = "0x2593720", Offset = "0x2593720", VA = "0x2593720")]
	public bool SafeZoneEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6005DEF")]
	[Address(RVA = "0x25937FC", Offset = "0x25937FC", VA = "0x25937FC")]
	public float SafeZoneSize()
	{
		return default(float);
	}

	[Token(Token = "0x6005DF0")]
	[Address(RVA = "0x25938D8", Offset = "0x25938D8", VA = "0x25938D8")]
	public float SafeZoneStartTime()
	{
		return default(float);
	}

	[Token(Token = "0x6005DF1")]
	[Address(RVA = "0x25939B4", Offset = "0x25939B4", VA = "0x25939B4")]
	public float SafeZoneShrinkTime()
	{
		return default(float);
	}

	[Token(Token = "0x6005DF2")]
	[Address(RVA = "0x2593A90", Offset = "0x2593A90", VA = "0x2593A90")]
	public float SafeZoneDamage()
	{
		return default(float);
	}

	[Token(Token = "0x6005DF3")]
	[Address(RVA = "0x2593B6C", Offset = "0x2593B6C", VA = "0x2593B6C")]
	public int TargetScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005DF4")]
	[Address(RVA = "0x2593C48", Offset = "0x2593C48", VA = "0x2593C48")]
	public int KillingScore()
	{
		return default(int);
	}

	[Token(Token = "0x6005DF5")]
	[Address(RVA = "0x2593D24", Offset = "0x2593D24", VA = "0x2593D24")]
	public int ReviveRule()
	{
		return default(int);
	}

	[Token(Token = "0x6005DF6")]
	[Address(RVA = "0x2593E00", Offset = "0x2593E00", VA = "0x2593E00")]
	public List<object> PlayerRoundRankingRuleScoreType()
	{
		return null;
	}

	[Token(Token = "0x6005DF7")]
	[Address(RVA = "0x2593EDC", Offset = "0x2593EDC", VA = "0x2593EDC")]
	public List<object> PlayerRoundRankingRuleSortType()
	{
		return null;
	}

	[Token(Token = "0x6005DF8")]
	[Address(RVA = "0x2593FB8", Offset = "0x2593FB8", VA = "0x2593FB8")]
	public List<object> TeamRoundRankingRuleScoreType()
	{
		return null;
	}

	[Token(Token = "0x6005DF9")]
	[Address(RVA = "0x2594094", Offset = "0x2594094", VA = "0x2594094")]
	public List<object> TeamRoundRankingRuleSortType()
	{
		return null;
	}

	[Token(Token = "0x6005DFA")]
	[Address(RVA = "0x2594170", Offset = "0x2594170", VA = "0x2594170")]
	public List<object> MVPRuleScoreType()
	{
		return null;
	}

	[Token(Token = "0x6005DFB")]
	[Address(RVA = "0x259424C", Offset = "0x259424C", VA = "0x259424C")]
	public List<object> MVPRuleScoreWeight()
	{
		return null;
	}

	[Token(Token = "0x6005DFC")]
	[Address(RVA = "0x2594328", Offset = "0x2594328", VA = "0x2594328")]
	public List<object> RoundRankToScoreMap()
	{
		return null;
	}

	[Token(Token = "0x6005DFD")]
	[Address(RVA = "0x2594404", Offset = "0x2594404", VA = "0x2594404")]
	public List<object> ScoreTypeToShowResult()
	{
		return null;
	}

	[Token(Token = "0x6005DFE")]
	[Address(RVA = "0x25944E0", Offset = "0x25944E0", VA = "0x25944E0")]
	public int SumRoundCount()
	{
		return default(int);
	}

	[Token(Token = "0x6005DFF")]
	[Address(RVA = "0x25945BC", Offset = "0x25945BC", VA = "0x25945BC")]
	public int TeamRankAccumulateScoreType()
	{
		return default(int);
	}

	[Token(Token = "0x6005E00")]
	[Address(RVA = "0x2594698", Offset = "0x2594698", VA = "0x2594698")]
	public int TeamRankAccumulateScoreOrder()
	{
		return default(int);
	}

	[Token(Token = "0x6005E01")]
	[Address(RVA = "0x2594774", Offset = "0x2594774", VA = "0x2594774")]
	public int PlayerRankAccumulateScoreType()
	{
		return default(int);
	}

	[Token(Token = "0x6005E02")]
	[Address(RVA = "0x2594850", Offset = "0x2594850", VA = "0x2594850")]
	public int PlayerRankAccumulateScoreOrder()
	{
		return default(int);
	}
}
