using System;
using System.Collections.Generic;
using ECAPackage;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2000C1A")]
public class BEDataManager : SingletonModule<BEDataManager>
{
	[Token(Token = "0x2000C1B")]
	private sealed class _003CGetDescriType_003Ec__AnonStorey0
	{
		[Token(Token = "0x400646A")]
		[FieldOffset(Offset = "0x8")]
		internal IOGCEGJJHLK type;

		[Token(Token = "0x400646B")]
		[FieldOffset(Offset = "0xC")]
		internal bool exist;

		[Token(Token = "0x6005C9B")]
		[Address(RVA = "0x2E4A978", Offset = "0x2E4A978", VA = "0x2E4A978")]
		public _003CGetDescriType_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6005C9C")]
		[Address(RVA = "0x2E4B53C", Offset = "0x2E4B53C", VA = "0x2E4B53C")]
		internal bool _003C_003Em__0(KeyValuePair<string, int> e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000C1C")]
	private sealed class _003CGetDescriEntityTypeFromLogicEntityType_003Ec__AnonStorey1
	{
		[Token(Token = "0x400646C")]
		[FieldOffset(Offset = "0x8")]
		internal FONLAPPBCOO type;

		[Token(Token = "0x400646D")]
		[FieldOffset(Offset = "0xC")]
		internal bool exist;

		[Token(Token = "0x6005C9D")]
		[Address(RVA = "0x2E4ADCC", Offset = "0x2E4ADCC", VA = "0x2E4ADCC")]
		public _003CGetDescriEntityTypeFromLogicEntityType_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6005C9E")]
		[Address(RVA = "0x2E4B424", Offset = "0x2E4B424", VA = "0x2E4B424")]
		internal bool _003C_003Em__0(KeyValuePair<string, int> e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000C1D")]
	private sealed class _003CGetDescriEntityTypeFromValue_003Ec__AnonStorey2
	{
		[Token(Token = "0x400646E")]
		[FieldOffset(Offset = "0x8")]
		internal int val;

		[Token(Token = "0x400646F")]
		[FieldOffset(Offset = "0xC")]
		internal bool exist;

		[Token(Token = "0x6005C9F")]
		[Address(RVA = "0x2E4AFB8", Offset = "0x2E4AFB8", VA = "0x2E4AFB8")]
		public _003CGetDescriEntityTypeFromValue_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6005CA0")]
		[Address(RVA = "0x2E4B4B0", Offset = "0x2E4B4B0", VA = "0x2E4B4B0")]
		internal bool _003C_003Em__0(KeyValuePair<string, int> e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4006461")]
	[FieldOffset(Offset = "0x0")]
	public static ECADescriptionFile ECADescrFile;

	[Token(Token = "0x4006462")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, Dictionary<string, ECADefineBase>> VarRepItemsDic;

	[Token(Token = "0x4006463")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, List<ECADefineBase>> EntityRepItemDic;

	[Token(Token = "0x4006464")]
	[FieldOffset(Offset = "0x14")]
	private List<ECAVarTypeDefine> EntityTypeList;

	[Token(Token = "0x4006465")]
	[FieldOffset(Offset = "0x18")]
	private HashSet<string> BasicTypeSet;

	[Token(Token = "0x4006466")]
	[FieldOffset(Offset = "0x1C")]
	private readonly Dictionary<string, int> DescriTypeToMetaType;

	[Token(Token = "0x4006467")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, int> DescriEntityTypeToLogicEntityType;

	[Token(Token = "0x4006468")]
	[FieldOffset(Offset = "0x24")]
	public readonly Dictionary<uint, string> ValueTypeUIMapping;

	[Token(Token = "0x4006469")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<ECADefineBase> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6005C84")]
	[Address(RVA = "0x2E47680", Offset = "0x2E47680", VA = "0x2E47680")]
	public BEDataManager()
	{
	}

	[Token(Token = "0x6005C85")]
	[Address(RVA = "0x2E487AC", Offset = "0x2E487AC", VA = "0x2E487AC", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6005C86")]
	[Address(RVA = "0x2E48B14", Offset = "0x2E48B14", VA = "0x2E48B14")]
	public void InitDescrFile()
	{
	}

	[Token(Token = "0x6005C87")]
	[Address(RVA = "0x2E49728", Offset = "0x2E49728", VA = "0x2E49728")]
	public EGKJIDMCGML ParseValueData(ECADefineBase data, string type)
	{
		return null;
	}

	[Token(Token = "0x6005C88")]
	[Address(RVA = "0x2E4998C", Offset = "0x2E4998C", VA = "0x2E4998C")]
	public List<string> GetEventLstByOwnerType(string owner)
	{
		return null;
	}

	[Token(Token = "0x6005C89")]
	[Address(RVA = "0x2E4960C", Offset = "0x2E4960C", VA = "0x2E4960C")]
	public ECAVarTypeDefine GetVarTypeDefine(string varName)
	{
		return null;
	}

	[Token(Token = "0x6005C8A")]
	[Address(RVA = "0x2E49C0C", Offset = "0x2E49C0C", VA = "0x2E49C0C")]
	public List<ECADefineBase> GetVarRepList(string varName)
	{
		return null;
	}

	[Token(Token = "0x6005C8B")]
	[Address(RVA = "0x2E49D28", Offset = "0x2E49D28", VA = "0x2E49D28")]
	public ECADefineBase GetVarRep(string varName, string repName)
	{
		return null;
	}

	[Token(Token = "0x6005C8C")]
	[Address(RVA = "0x2E49E50", Offset = "0x2E49E50", VA = "0x2E49E50")]
	public List<ECADefineBase> GetEntityRep(string entityName, bool excludeReadOnly)
	{
		return null;
	}

	[Token(Token = "0x6005C8D")]
	[Address(RVA = "0x2E4A100", Offset = "0x2E4A100", VA = "0x2E4A100")]
	public List<ECADefineBase> GetCustomEntityRep(string entityName)
	{
		return null;
	}

	[Token(Token = "0x6005C8E")]
	[Address(RVA = "0x2E4A470", Offset = "0x2E4A470", VA = "0x2E4A470")]
	public ECADefineBase RepDataToDefine(DJMFJEMEKHM repData, int idx)
	{
		return null;
	}

	[Token(Token = "0x6005C8F")]
	[Address(RVA = "0x2E4A6AC", Offset = "0x2E4A6AC", VA = "0x2E4A6AC")]
	public IOGCEGJJHLK GetMetaTypeFromDescriType(string descriType)
	{
		return default(IOGCEGJJHLK);
	}

	[Token(Token = "0x6005C90")]
	[Address(RVA = "0x2E4A794", Offset = "0x2E4A794", VA = "0x2E4A794")]
	public string GetDescriType(IOGCEGJJHLK type)
	{
		return null;
	}

	[Token(Token = "0x6005C91")]
	[Address(RVA = "0x2E4A980", Offset = "0x2E4A980", VA = "0x2E4A980")]
	public List<string> GetEntityTypeValList()
	{
		return null;
	}

	[Token(Token = "0x6005C92")]
	[Address(RVA = "0x2E4AA54", Offset = "0x2E4AA54", VA = "0x2E4AA54")]
	public List<ECAVarTypeDefine> GetEntityTypeDefineList()
	{
		return null;
	}

	[Token(Token = "0x6005C93")]
	[Address(RVA = "0x2E4AAAC", Offset = "0x2E4AAAC", VA = "0x2E4AAAC")]
	public List<string> GetAllTypeList()
	{
		return null;
	}

	[Token(Token = "0x6005C94")]
	[Address(RVA = "0x2E4ABE8", Offset = "0x2E4ABE8", VA = "0x2E4ABE8")]
	public string GetDescriEntityTypeFromLogicEntityType(FONLAPPBCOO type)
	{
		return null;
	}

	[Token(Token = "0x6005C95")]
	[Address(RVA = "0x2E4ADD4", Offset = "0x2E4ADD4", VA = "0x2E4ADD4")]
	public string GetDescriEntityTypeFromValue(int val)
	{
		return null;
	}

	[Token(Token = "0x6005C96")]
	[Address(RVA = "0x2E4AFC0", Offset = "0x2E4AFC0", VA = "0x2E4AFC0")]
	public FONLAPPBCOO GetLogicEntityTypeFromDescriEntityType(string entityName)
	{
		return default(FONLAPPBCOO);
	}

	[Token(Token = "0x6005C97")]
	[Address(RVA = "0x2E4B0A8", Offset = "0x2E4B0A8", VA = "0x2E4B0A8")]
	public string GetDescTypeFromStrVal(string StrVal)
	{
		return null;
	}

	[Token(Token = "0x6005C98")]
	[Address(RVA = "0x2E4B25C", Offset = "0x2E4B25C", VA = "0x2E4B25C")]
	public string GetMetaConfigTypeMappingStr(IOGCEGJJHLK t)
	{
		return null;
	}

	[Token(Token = "0x6005C99")]
	[Address(RVA = "0x2E4B340", Offset = "0x2E4B340", VA = "0x2E4B340", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6005C9A")]
	[Address(RVA = "0x2E4B394", Offset = "0x2E4B394", VA = "0x2E4B394")]
	private static bool _003CGetEntityRep_003Em__0(ECADefineBase e)
	{
		return default(bool);
	}
}
