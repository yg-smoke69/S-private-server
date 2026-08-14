using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002A65")]
public class UIPointsRankItemController : UIEasyListItemController
{
	[Token(Token = "0x401047D")]
	[FieldOffset(Offset = "0x38")]
	private UIPointsRankItemView m_View;

	[Token(Token = "0x401047E")]
	[FieldOffset(Offset = "0x3C")]
	private LeaderBoardInfo m_Info;

	[Token(Token = "0x401047F")]
	[FieldOffset(Offset = "0x40")]
	private uint m_MaxSize;

	[Token(Token = "0x4010480")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<uint, string> m_RankCupIcon;

	[Token(Token = "0x4010481")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<uint, uint> m_RankCupBG;

	[Token(Token = "0x4010482")]
	private const uint m_DefaultRankCupBG = 1482449700u;

	[Token(Token = "0x4010483")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_UsePercentFormat;

	[Token(Token = "0x60113F9")]
	[Address(RVA = "0x224090C", Offset = "0x224090C", VA = "0x224090C")]
	public UIPointsRankItemController()
	{
	}

	[Token(Token = "0x60113FA")]
	[Address(RVA = "0x2240B68", Offset = "0x2240B68", VA = "0x2240B68")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60113FB")]
	[Address(RVA = "0x2240BCC", Offset = "0x2240BCC", VA = "0x2240BCC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60113FC")]
	[Address(RVA = "0x2240ED8", Offset = "0x2240ED8", VA = "0x2240ED8")]
	private void SetItemData(LeaderBoardInfo info)
	{
	}

	[Token(Token = "0x60113FD")]
	[Address(RVA = "0x224184C", Offset = "0x224184C", VA = "0x224184C")]
	public void SetWidgetColor(Color color)
	{
	}

	[Token(Token = "0x60113FE")]
	[Address(RVA = "0x224194C", Offset = "0x224194C", VA = "0x224194C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60113FF")]
	[Address(RVA = "0x22419EC", Offset = "0x22419EC", VA = "0x22419EC", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6011400")]
	[Address(RVA = "0x2240830", Offset = "0x2240830", VA = "0x2240830")]
	public void SetRankFormat(bool usePercentFormat)
	{
	}

	[Token(Token = "0x6011401")]
	[Address(RVA = "0x22415C4", Offset = "0x22415C4", VA = "0x22415C4")]
	private void UpdateView()
	{
	}
}
