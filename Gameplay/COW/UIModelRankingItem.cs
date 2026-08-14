using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20031F2")]
public class UIModelRankingItem : UIBaseModel
{
	[Token(Token = "0x20031F3")]
	private sealed class _003CFindRankingItemDataByID_003Ec__AnonStorey0
	{
		[Token(Token = "0x401302C")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemID;

		[Token(Token = "0x601512A")]
		[Address(RVA = "0x313E2F0", Offset = "0x313E2F0", VA = "0x313E2F0")]
		public _003CFindRankingItemDataByID_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601512B")]
		[Address(RVA = "0x313E458", Offset = "0x313E458", VA = "0x313E458")]
		internal bool _003C_003Em__0(RankingItemRank data)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401302B")]
	[FieldOffset(Offset = "0xC")]
	private List<RankingItemRank> m_RankingItemList;

	[Token(Token = "0x6015125")]
	[Address(RVA = "0x313E030", Offset = "0x313E030", VA = "0x313E030")]
	public UIModelRankingItem()
	{
	}

	[Token(Token = "0x6015126")]
	[Address(RVA = "0x313E0E8", Offset = "0x313E0E8", VA = "0x313E0E8", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6015127")]
	[Address(RVA = "0x313E140", Offset = "0x313E140", VA = "0x313E140")]
	public void ProcessRankingItem(GetRankingItemRankConfigRes res)
	{
	}

	[Token(Token = "0x6015128")]
	[Address(RVA = "0x313E1AC", Offset = "0x313E1AC", VA = "0x313E1AC")]
	public RankingItemRank FindRankingItemDataByID(uint itemID)
	{
		return null;
	}

	[Token(Token = "0x6015129")]
	[Address(RVA = "0x313E2F8", Offset = "0x313E2F8", VA = "0x313E2F8")]
	public bool CheckIsReachRankItemUseLevel(uint itemId)
	{
		return default(bool);
	}
}
