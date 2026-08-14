using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002567")]
public class UIClanWarRankItemController : UIEasyListItemController
{
	[Token(Token = "0x2002568")]
	public enum DisplayType
	{
		[Token(Token = "0x400E78E")]
		PersonRobbed,
		[Token(Token = "0x400E78F")]
		ClanRobbed
	}

	[Token(Token = "0x2002569")]
	public enum RankFormat
	{
		[Token(Token = "0x400E791")]
		Normal,
		[Token(Token = "0x400E792")]
		TopPercent
	}

	[Token(Token = "0x400E784")]
	[FieldOffset(Offset = "0x38")]
	private UIClanWarRankItemView m_View;

	[Token(Token = "0x400E785")]
	[FieldOffset(Offset = "0x3C")]
	private UIBaseProfileInfoController m_BaseInfoUI;

	[Token(Token = "0x400E786")]
	[FieldOffset(Offset = "0x40")]
	private DisplayType m_Display;

	[Token(Token = "0x400E787")]
	[FieldOffset(Offset = "0x44")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E788")]
	[FieldOffset(Offset = "0x48")]
	private RankFormat m_RankFormat;

	[Token(Token = "0x400E789")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_MaxSize;

	[Token(Token = "0x400E78A")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsSelf;

	[Token(Token = "0x400E78B")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<uint, string> m_RankCupIcon;

	[Token(Token = "0x400E78C")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<uint, string> m_RankBG;

	[Token(Token = "0x600DA6E")]
	[Address(RVA = "0x2906704", Offset = "0x2906704", VA = "0x2906704")]
	public UIClanWarRankItemController()
	{
	}

	[Token(Token = "0x600DA6F")]
	[Address(RVA = "0x290697C", Offset = "0x290697C", VA = "0x290697C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DA70")]
	[Address(RVA = "0x2906A24", Offset = "0x2906A24", VA = "0x2906A24", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DA71")]
	[Address(RVA = "0x2906B3C", Offset = "0x2906B3C", VA = "0x2906B3C")]
	private void InitView()
	{
	}

	[Token(Token = "0x600DA72")]
	[Address(RVA = "0x2905410", Offset = "0x2905410", VA = "0x2905410")]
	public void SetDisplayType(DisplayType displayType)
	{
	}

	[Token(Token = "0x600DA73")]
	[Address(RVA = "0x2906498", Offset = "0x2906498", VA = "0x2906498")]
	public void SetRankFormat(RankFormat format, uint maxSize)
	{
	}

	[Token(Token = "0x600DA74")]
	[Address(RVA = "0x2906438", Offset = "0x2906438", VA = "0x2906438")]
	public void SetSelf(bool isSelf)
	{
	}

	[Token(Token = "0x600DA75")]
	[Address(RVA = "0x2906BEC", Offset = "0x2906BEC", VA = "0x2906BEC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600DA76")]
	[Address(RVA = "0x2907198", Offset = "0x2907198", VA = "0x2907198")]
	private void SetPersonRobbedData(object data)
	{
	}

	[Token(Token = "0x600DA77")]
	[Address(RVA = "0x2906DD4", Offset = "0x2906DD4", VA = "0x2906DD4")]
	private void SetClanRobbedData(object data)
	{
	}

	[Token(Token = "0x600DA78")]
	[Address(RVA = "0x29074A4", Offset = "0x29074A4", VA = "0x29074A4")]
	private void SetRank(uint rank)
	{
	}

	[Token(Token = "0x600DA79")]
	[Address(RVA = "0x2907B6C", Offset = "0x2907B6C", VA = "0x2907B6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
