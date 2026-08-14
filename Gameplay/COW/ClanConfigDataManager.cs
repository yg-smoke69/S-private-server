using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002DBB")]
internal class ClanConfigDataManager : SingletonModule<ClanConfigDataManager>
{
	[Token(Token = "0x2002DBC")]
	private sealed class _003CGetAreaList_003Ec__AnonStorey0
	{
		[Token(Token = "0x40118B6")]
		[FieldOffset(Offset = "0x8")]
		internal ClanAreaData data;

		[Token(Token = "0x6013257")]
		[Address(RVA = "0x17299F8", Offset = "0x17299F8", VA = "0x17299F8")]
		public _003CGetAreaList_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013258")]
		[Address(RVA = "0x172A628", Offset = "0x172A628", VA = "0x172A628")]
		internal bool _003C_003Em__0(MultiPopMenuListData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DBD")]
	private sealed class _003CGetAreaList_003Ec__AnonStorey1
	{
		[Token(Token = "0x40118B7")]
		[FieldOffset(Offset = "0x8")]
		internal ClanAreaData data;

		[Token(Token = "0x6013259")]
		[Address(RVA = "0x1729A00", Offset = "0x1729A00", VA = "0x1729A00")]
		public _003CGetAreaList_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601325A")]
		[Address(RVA = "0x172A6E0", Offset = "0x172A6E0", VA = "0x172A6E0")]
		internal bool _003C_003Em__0(MultiPopMenuListData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40118B3")]
	[FieldOffset(Offset = "0xC")]
	private string[] m_FilterPool;

	[Token(Token = "0x40118B4")]
	[FieldOffset(Offset = "0x10")]
	private List<MultiPopMenuListData> m_RankCondDatas;

	[Token(Token = "0x40118B5")]
	[FieldOffset(Offset = "0x14")]
	private List<MultiPopMenuListData> m_LevelCondDatas;

	[Token(Token = "0x6013241")]
	[Address(RVA = "0x17273C0", Offset = "0x17273C0", VA = "0x17273C0")]
	public ClanConfigDataManager()
	{
	}

	[Token(Token = "0x6013242")]
	[Address(RVA = "0x17275A4", Offset = "0x17275A4", VA = "0x17275A4", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013243")]
	[Address(RVA = "0x17275F8", Offset = "0x17275F8", VA = "0x17275F8", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6013244")]
	[Address(RVA = "0x17276E4", Offset = "0x17276E4", VA = "0x17276E4")]
	public bool IsOpenArea()
	{
		return default(bool);
	}

	[Token(Token = "0x6013245")]
	[Address(RVA = "0x1727818", Offset = "0x1727818", VA = "0x1727818")]
	public int GetFilterMenuItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x6013246")]
	[Address(RVA = "0x172796C", Offset = "0x172796C", VA = "0x172796C")]
	public string StringArrayToLabel(List<string> strs)
	{
		return null;
	}

	[Token(Token = "0x6013247")]
	[Address(RVA = "0x1727C9C", Offset = "0x1727C9C", VA = "0x1727C9C")]
	public EClan.ClanMainType GetClanTypeFromString(string content)
	{
		return default(EClan.ClanMainType);
	}

	[Token(Token = "0x6013248")]
	[Address(RVA = "0x1727E30", Offset = "0x1727E30", VA = "0x1727E30")]
	public string GetTagStringLabelFromID(uint tagId)
	{
		return null;
	}

	[Token(Token = "0x6013249")]
	[Address(RVA = "0x1727F60", Offset = "0x1727F60", VA = "0x1727F60")]
	public string GetTagStringKeyFromID(uint tagId)
	{
		return null;
	}

	[Token(Token = "0x601324A")]
	[Address(RVA = "0x17280AC", Offset = "0x17280AC", VA = "0x17280AC")]
	public uint GetTagIDFromTagString(string tag)
	{
		return default(uint);
	}

	[Token(Token = "0x601324B")]
	[Address(RVA = "0x17282D0", Offset = "0x17282D0", VA = "0x17282D0")]
	public List<MultiPopMenuListData> GetTags()
	{
		return null;
	}

	[Token(Token = "0x601324C")]
	[Address(RVA = "0x1728564", Offset = "0x1728564", VA = "0x1728564")]
	public List<MultiPopMenuListData> GetFilterList()
	{
		return null;
	}

	[Token(Token = "0x601324D")]
	[Address(RVA = "0x1729140", Offset = "0x1729140", VA = "0x1729140")]
	public List<MultiPopMenuListData> GetRankCondList()
	{
		return null;
	}

	[Token(Token = "0x601324E")]
	[Address(RVA = "0x1729440", Offset = "0x1729440", VA = "0x1729440")]
	public string GetRankCondStringFromID(uint rank)
	{
		return null;
	}

	[Token(Token = "0x601324F")]
	[Address(RVA = "0x172960C", Offset = "0x172960C", VA = "0x172960C")]
	public List<MultiPopMenuListData> GetLevelCondList()
	{
		return null;
	}

	[Token(Token = "0x6013250")]
	[Address(RVA = "0x17298A0", Offset = "0x17298A0", VA = "0x17298A0")]
	public string GetLevelCondStringFromID(uint level)
	{
		return null;
	}

	[Token(Token = "0x6013251")]
	[Address(RVA = "0x1728AA8", Offset = "0x1728AA8", VA = "0x1728AA8")]
	public List<MultiPopMenuListData> GetAreaList()
	{
		return null;
	}

	[Token(Token = "0x6013252")]
	[Address(RVA = "0x1729A08", Offset = "0x1729A08", VA = "0x1729A08")]
	public uint GetAreaIDFromString(string country, string area)
	{
		return default(uint);
	}

	[Token(Token = "0x6013253")]
	[Address(RVA = "0x1729D0C", Offset = "0x1729D0C", VA = "0x1729D0C")]
	public string[] GetAreaStringArrayFromID(uint areaId)
	{
		return null;
	}

	[Token(Token = "0x6013254")]
	[Address(RVA = "0x1729FEC", Offset = "0x1729FEC", VA = "0x1729FEC")]
	public string GetAreaStringFromID(uint areaId)
	{
		return null;
	}

	[Token(Token = "0x6013255")]
	[Address(RVA = "0x172A3F0", Offset = "0x172A3F0", VA = "0x172A3F0")]
	public int GetClanMaxPendingApplications()
	{
		return default(int);
	}

	[Token(Token = "0x6013256")]
	[Address(RVA = "0x172A50C", Offset = "0x172A50C", VA = "0x172A50C")]
	public int GetPlayerMaxRequestsPerDay()
	{
		return default(int);
	}
}
