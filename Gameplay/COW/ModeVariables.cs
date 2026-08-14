using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;
using message;

namespace COW;

[Token(Token = "0x2002E58")]
public class ModeVariables
{
	[Token(Token = "0x2002E59")]
	public enum ClassicGameModeIndex
	{
		[Token(Token = "0x4011B57")]
		CS,
		[Token(Token = "0x4011B58")]
		TDM,
		[Token(Token = "0x4011B59")]
		Party
	}

	[Token(Token = "0x2002E5A")]
	public enum CustomModeTemplateIndex
	{
		[Token(Token = "0x4011B5B")]
		Annihilate = 0,
		[Token(Token = "0x4011B5C")]
		Score = 1,
		[Token(Token = "0x4011B5D")]
		Racing = 2,
		[Token(Token = "0x4011B5E")]
		FullCustom = 3,
		[Token(Token = "0x4011B5F")]
		PVE_LEVEL = 4,
		[Token(Token = "0x4011B60")]
		PVE_DEFENCE = 5,
		[Token(Token = "0x4011B61")]
		Total = 999
	}

	[Token(Token = "0x4011B49")]
	public const int DefaultTeamNum = 2;

	[Token(Token = "0x4011B4A")]
	public const int ModeTemplateID = 1;

	[Token(Token = "0x4011B4B")]
	public const int TeamNumID = 6;

	[Token(Token = "0x4011B4C")]
	public const int TeamMemberNumID = 7;

	[Token(Token = "0x4011B4D")]
	public const int FULL_CUSTOM_ROUND_NUM_ID = 8;

	[Token(Token = "0x4011B4E")]
	public const int FULL_CUSTOM_ROUND_PREPARE_TIME_ID = 29;

	[Token(Token = "0x4011B4F")]
	public const int FULL_CUSTOM_ROUND_TIME_ID = 9;

	[Token(Token = "0x4011B50")]
	public const int FULL_CUSTOM_ENABLE_MULTI_ROUND_ID = 27;

	[Token(Token = "0x4011B51")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, ModeVariable> m_Variables;

	[Token(Token = "0x4011B52")]
	[FieldOffset(Offset = "0xC")]
	private NFEKCMOMHJJ m_CustomModeDataCache;

	[Token(Token = "0x4011B53")]
	[FieldOffset(Offset = "0x10")]
	public int CurrentCustomModeTemplateIndexInBuildingData;

	[Token(Token = "0x4011B54")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map11;

	[Token(Token = "0x4011B55")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map12;

	[Token(Token = "0x6013621")]
	[Address(RVA = "0x2283A90", Offset = "0x2283A90", VA = "0x2283A90")]
	public ModeVariables()
	{
	}

	[Token(Token = "0x6013622")]
	[Address(RVA = "0x2283B40", Offset = "0x2283B40", VA = "0x2283B40")]
	public bool IsEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x6013623")]
	[Address(RVA = "0x2283C10", Offset = "0x2283C10", VA = "0x2283C10")]
	public bool FromJsonData(JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x6013624")]
	[Address(RVA = "0x2284250", Offset = "0x2284250", VA = "0x2284250")]
	public FEIGJAGLKLM ToProtoData()
	{
		return null;
	}

	[Token(Token = "0x6013625")]
	[Address(RVA = "0x2284800", Offset = "0x2284800", VA = "0x2284800")]
	private OMAFMFJKMPB ToCSModeProtoData()
	{
		return null;
	}

	[Token(Token = "0x6013626")]
	[Address(RVA = "0x2284D44", Offset = "0x2284D44", VA = "0x2284D44")]
	private BAJPKFPIKHB ToIntegralModeProtoData()
	{
		return null;
	}

	[Token(Token = "0x6013627")]
	[Address(RVA = "0x2285378", Offset = "0x2285378", VA = "0x2285378")]
	private OKBFAGMCOKP ToPartyModeProtoData()
	{
		return null;
	}

	[Token(Token = "0x6013628")]
	[Address(RVA = "0x2286194", Offset = "0x2286194", VA = "0x2286194")]
	private PLPOJKGPFDL ToGeneralProtoData()
	{
		return null;
	}

	[Token(Token = "0x6013629")]
	[Address(RVA = "0x228570C", Offset = "0x228570C", VA = "0x228570C")]
	private NFEKCMOMHJJ ToCustomModeProtoData()
	{
		return null;
	}

	[Token(Token = "0x601362A")]
	[Address(RVA = "0x22877EC", Offset = "0x22877EC", VA = "0x22877EC")]
	private void LogVariable(ModeVariable variable, bool logAllValues = false)
	{
	}

	[Token(Token = "0x601362B")]
	[Address(RVA = "0x22879CC", Offset = "0x22879CC", VA = "0x22879CC")]
	public void LogCachedCustomModeProtoData()
	{
	}

	[Token(Token = "0x601362C")]
	[Address(RVA = "0x2287FE8", Offset = "0x2287FE8", VA = "0x2287FE8")]
	public void LogVariables()
	{
	}

	[Token(Token = "0x601362D")]
	[Address(RVA = "0x22886F8", Offset = "0x22886F8", VA = "0x22886F8")]
	public bool FromProtoData(FEIGJAGLKLM protoData)
	{
		return default(bool);
	}

	[Token(Token = "0x601362E")]
	[Address(RVA = "0x2288CF4", Offset = "0x2288CF4", VA = "0x2288CF4")]
	public bool FromCSModeProtoData(OMAFMFJKMPB protoData, uint groupMode)
	{
		return default(bool);
	}

	[Token(Token = "0x601362F")]
	[Address(RVA = "0x22892E8", Offset = "0x22892E8", VA = "0x22892E8")]
	public bool FromIntegralModeProtoData(BAJPKFPIKHB protoData, uint groupMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6013630")]
	[Address(RVA = "0x22899BC", Offset = "0x22899BC", VA = "0x22899BC")]
	public bool FromPartyModeProtoData(OKBFAGMCOKP protoData, uint groupMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6013631")]
	[Address(RVA = "0x228A848", Offset = "0x228A848", VA = "0x228A848")]
	public bool FromGeneralProtoData(PLPOJKGPFDL protoData)
	{
		return default(bool);
	}

	[Token(Token = "0x6013632")]
	[Address(RVA = "0x2289E2C", Offset = "0x2289E2C", VA = "0x2289E2C")]
	public bool FromCustomModeProtoData(uint mapID, NFEKCMOMHJJ protoData)
	{
		return default(bool);
	}

	[Token(Token = "0x6013633")]
	[Address(RVA = "0x228C388", Offset = "0x228C388", VA = "0x228C388")]
	public string ToCSVData()
	{
		return null;
	}

	[Token(Token = "0x6013634")]
	[Address(RVA = "0x228CA34", Offset = "0x228CA34", VA = "0x228CA34")]
	public ModeVariable GetVariable(string name, bool needLog = true)
	{
		return null;
	}

	[Token(Token = "0x6013635")]
	[Address(RVA = "0x228CEF0", Offset = "0x228CEF0", VA = "0x228CEF0")]
	public void CopyFrom(ModeVariables variables)
	{
	}

	[Token(Token = "0x6013636")]
	[Address(RVA = "0x228D28C", Offset = "0x228D28C", VA = "0x228D28C")]
	public uint GetGameMode()
	{
		return default(uint);
	}

	[Token(Token = "0x6013637")]
	[Address(RVA = "0x228D49C", Offset = "0x228D49C", VA = "0x228D49C")]
	public void SetGameModeWithTemplate(uint mode, uint template)
	{
	}

	[Token(Token = "0x6013638")]
	[Address(RVA = "0x228D74C", Offset = "0x228D74C", VA = "0x228D74C")]
	public uint GetGroupMode()
	{
		return default(uint);
	}

	[Token(Token = "0x6013639")]
	[Address(RVA = "0x228DCA8", Offset = "0x228DCA8", VA = "0x228DCA8")]
	public uint GetTeamCount()
	{
		return default(uint);
	}

	[Token(Token = "0x601363A")]
	[Address(RVA = "0x228DE84", Offset = "0x228DE84", VA = "0x228DE84")]
	public uint GetUGCModeTemplate()
	{
		return default(uint);
	}

	[Token(Token = "0x601363B")]
	[Address(RVA = "0x228E060", Offset = "0x228E060", VA = "0x228E060")]
	public bool GetCustomModeTemplateIndexEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x601363C")]
	[Address(RVA = "0x228E248", Offset = "0x228E248", VA = "0x228E248")]
	public bool GetCustomModeTeamNumSelectable()
	{
		return default(bool);
	}

	[Token(Token = "0x601363D")]
	[Address(RVA = "0x228BD48", Offset = "0x228BD48", VA = "0x228BD48")]
	public ModeVariable GetVariableById(int id)
	{
		return null;
	}

	[Token(Token = "0x601363E")]
	[Address(RVA = "0x228BB64", Offset = "0x228BB64", VA = "0x228BB64")]
	public void Save()
	{
	}

	[Token(Token = "0x601363F")]
	[Address(RVA = "0x228D648", Offset = "0x228D648", VA = "0x228D648")]
	public void SaveMeta()
	{
	}

	[Token(Token = "0x6013640")]
	[Address(RVA = "0x2288B08", Offset = "0x2288B08", VA = "0x2288B08")]
	public void ResetToDefault(uint mapID)
	{
	}

	[Token(Token = "0x6013641")]
	[Address(RVA = "0x228E430", Offset = "0x228E430", VA = "0x228E430")]
	public void ResetToSaved()
	{
	}
}
