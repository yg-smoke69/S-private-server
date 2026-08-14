using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E77")]
public static class UIModeEditDataUtil
{
	[Token(Token = "0x2002E78")]
	public enum CustomModeTemplateType
	{
		[Token(Token = "0x4011BC1")]
		FullCustom,
		[Token(Token = "0x4011BC2")]
		Score,
		[Token(Token = "0x4011BC3")]
		Racing,
		[Token(Token = "0x4011BC4")]
		Annihilate,
		[Token(Token = "0x4011BC5")]
		ScoreMulTeam,
		[Token(Token = "0x4011BC6")]
		RacingMulTeam,
		[Token(Token = "0x4011BC7")]
		AnnihilateMulTeam,
		[Token(Token = "0x4011BC8")]
		PVE_LEVEL,
		[Token(Token = "0x4011BC9")]
		PVE_DEFENCE
	}

	[Token(Token = "0x2002E79")]
	private sealed class _003CTemplateToGameModeIndex_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011BCA")]
		[FieldOffset(Offset = "0x8")]
		internal int code;

		[Token(Token = "0x60136AA")]
		[Address(RVA = "0x130A4D4", Offset = "0x130A4D4", VA = "0x130A4D4")]
		public _003CTemplateToGameModeIndex_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60136AB")]
		[Address(RVA = "0x130DDBC", Offset = "0x130DDBC", VA = "0x130DDBC")]
		internal bool _003C_003Em__0(CustomModeTemplateMappingInfo info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E7A")]
	private sealed class _003CGameModeIndexAndTeamNumToTemplate_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011BCB")]
		[FieldOffset(Offset = "0x8")]
		internal int modeIndex;

		[Token(Token = "0x60136AC")]
		[Address(RVA = "0x130A8A4", Offset = "0x130A8A4", VA = "0x130A8A4")]
		public _003CGameModeIndexAndTeamNumToTemplate_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60136AD")]
		[Address(RVA = "0x130DD88", Offset = "0x130DD88", VA = "0x130DD88")]
		internal bool _003C_003Em__0(CustomModeTemplateMappingInfo info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011BB9")]
	[FieldOffset(Offset = "0x0")]
	public static readonly uint ModeTemplateTotalSwitchId;

	[Token(Token = "0x4011BBA")]
	[FieldOffset(Offset = "0x4")]
	public static ModeVariables CustomModeVariables;

	[Token(Token = "0x4011BBB")]
	[FieldOffset(Offset = "0x8")]
	public static ModeVariables ClassicModeVariables;

	[Token(Token = "0x4011BBC")]
	[FieldOffset(Offset = "0xC")]
	public static bool IsCustomModeActivated;

	[Token(Token = "0x4011BBD")]
	[FieldOffset(Offset = "0x10")]
	public static Dictionary<int, UGCCustomModeTemplateRuleData> CustomModeTemplateRules;

	[Token(Token = "0x4011BBE")]
	[FieldOffset(Offset = "0x14")]
	public static List<CustomModeTemplateMappingInfo> CustomModeTemplateMapping;

	[Token(Token = "0x4011BBF")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map13;

	[Token(Token = "0x601368F")]
	[Address(RVA = "0x1309FCC", Offset = "0x1309FCC", VA = "0x1309FCC")]
	public static uint GetModeFromModeWithTemplate(uint modeWithTemplate)
	{
		return default(uint);
	}

	[Token(Token = "0x6013690")]
	[Address(RVA = "0x130A034", Offset = "0x130A034", VA = "0x130A034")]
	public static uint GetTemplateFromModeWithTemplate(uint modeWithTemplate)
	{
		return default(uint);
	}

	[Token(Token = "0x6013691")]
	[Address(RVA = "0x130A0A4", Offset = "0x130A0A4", VA = "0x130A0A4")]
	public static uint MakeModeWithTemplate(uint mode, uint template)
	{
		return default(uint);
	}

	[Token(Token = "0x6013692")]
	[Address(RVA = "0x130A10C", Offset = "0x130A10C", VA = "0x130A10C")]
	public static bool IsFullCustom(uint code)
	{
		return default(bool);
	}

	[Token(Token = "0x6013693")]
	[Address(RVA = "0x130A174", Offset = "0x130A174", VA = "0x130A174")]
	public static int TemplateToGameModeIndex(int code)
	{
		return default(int);
	}

	[Token(Token = "0x6013694")]
	[Address(RVA = "0x130A4DC", Offset = "0x130A4DC", VA = "0x130A4DC")]
	public static int GameModeIndexAndTeamNumToTemplate(int modeIndex, int teamNum)
	{
		return default(int);
	}

	[Token(Token = "0x6013695")]
	[Address(RVA = "0x130A8AC", Offset = "0x130A8AC", VA = "0x130A8AC")]
	public static int FallbackIfTemplateIndexIsForbidden(int modeIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6013696")]
	[Address(RVA = "0x130ABE4", Offset = "0x130ABE4", VA = "0x130ABE4")]
	public static bool FallbackIfMultiTeamsIsForbidden(int modeIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6013697")]
	[Address(RVA = "0x130ADCC", Offset = "0x130ADCC", VA = "0x130ADCC")]
	public static Dictionary<int, UGCCustomModeTemplateRuleData> TryLoadCustomModeRuleDataIfNeed(bool force = false)
	{
		return null;
	}

	[Token(Token = "0x6013698")]
	[Address(RVA = "0x130AFE0", Offset = "0x130AFE0", VA = "0x130AFE0")]
	private static void BuildCustomModeForbiddenInfo(List<UGCCustomModeTemplateRuleData> data)
	{
	}

	[Token(Token = "0x6013699")]
	[Address(RVA = "0x1308E50", Offset = "0x1308E50", VA = "0x1308E50")]
	public static IModeEditComponentData BuildComponent(ModeVariables contextVariables, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x601369A")]
	[Address(RVA = "0x130BCF4", Offset = "0x130BCF4", VA = "0x130BCF4")]
	public static ModeVariableBinding BuildBool(ModeVariables contextVariables, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x601369B")]
	[Address(RVA = "0x1309BE8", Offset = "0x1309BE8", VA = "0x1309BE8")]
	public static ModeVariableBinding BuildInt(ModeVariables contextVariables, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x601369C")]
	[Address(RVA = "0x130C294", Offset = "0x130C294", VA = "0x130C294")]
	public static ModeVariableBinding BuildFloat(ModeVariables contextVariables, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x601369D")]
	[Address(RVA = "0x1309A78", Offset = "0x1309A78", VA = "0x1309A78")]
	public static string BuildString(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x601369E")]
	[Address(RVA = "0x130C4A8", Offset = "0x130C4A8", VA = "0x130C4A8")]
	public static JsonData BuildObject(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x601369F")]
	[Address(RVA = "0x130C5F8", Offset = "0x130C5F8", VA = "0x130C5F8")]
	public static JsonData BuildArray(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x60136A0")]
	[Address(RVA = "0x130C748", Offset = "0x130C748", VA = "0x130C748")]
	public static bool BuildIntArray(JsonData jsonData, string key, List<int> arrayToBuild, bool allowEmpty = true)
	{
		return default(bool);
	}

	[Token(Token = "0x60136A1")]
	[Address(RVA = "0x130C978", Offset = "0x130C978", VA = "0x130C978")]
	public static bool BuildArray(ModeVariables contextVariables, JsonData jsonData, string key, List<ModeVariableBinding> arrayToBuild, ModeVariable.VariableType type, bool allowEmpty = true)
	{
		return default(bool);
	}

	[Token(Token = "0x60136A2")]
	[Address(RVA = "0x130BF3C", Offset = "0x130BF3C", VA = "0x130BF3C")]
	public static ModeVariableBinding BuildBinding(ModeVariables contextVariables, JsonData jsonData)
	{
		return null;
	}

	[Token(Token = "0x60136A3")]
	[Address(RVA = "0x130D0E0", Offset = "0x130D0E0", VA = "0x130D0E0")]
	public static IModeVariableBindingModifier BuildBindingModifier(ModeVariables contextVariables, JsonData jsonData, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x60136A4")]
	[Address(RVA = "0x130D5E4", Offset = "0x130D5E4", VA = "0x130D5E4")]
	public static ModeVariable BuildVariable(JsonData jsonData)
	{
		return null;
	}

	[Token(Token = "0x60136A5")]
	[Address(RVA = "0x130988C", Offset = "0x130988C", VA = "0x130988C")]
	public static JsonData CheckData(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	[Token(Token = "0x60136A6")]
	[Address(RVA = "0x130BBDC", Offset = "0x130BBDC", VA = "0x130BBDC")]
	public static void LogErrorMissingField(string fieldName)
	{
	}

	[Token(Token = "0x60136A7")]
	[Address(RVA = "0x130BA58", Offset = "0x130BA58", VA = "0x130BA58")]
	public static void LogErrorWrongType(string fieldName, JsonType type)
	{
	}

	[Token(Token = "0x60136A8")]
	[Address(RVA = "0x130CFB4", Offset = "0x130CFB4", VA = "0x130CFB4")]
	public static void LogErrorDataIsNull()
	{
	}
}
