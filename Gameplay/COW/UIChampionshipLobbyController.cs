using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200200C")]
public class UIChampionshipLobbyController : UINavigationController
{
	[Token(Token = "0x400C95D")]
	[FieldOffset(Offset = "0x68")]
	private UIChampionshipLobbyView m_View;

	[Token(Token = "0x400C95E")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C95F")]
	[FieldOffset(Offset = "0x70")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400C960")]
	[FieldOffset(Offset = "0x74")]
	private AutoPopup m_AutoPopup;

	[Token(Token = "0x400C961")]
	[FieldOffset(Offset = "0x78")]
	private List<UIOnlineMatchEntranceItemController> m_EntranceList;

	[Token(Token = "0x600A210")]
	[Address(RVA = "0x282F87C", Offset = "0x282F87C", VA = "0x282F87C")]
	public UIChampionshipLobbyController()
	{
	}

	[Token(Token = "0x600A211")]
	[Address(RVA = "0x282F934", Offset = "0x282F934", VA = "0x282F934")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A212")]
	[Address(RVA = "0x282F9D8", Offset = "0x282F9D8", VA = "0x282F9D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A213")]
	[Address(RVA = "0x28300F4", Offset = "0x28300F4", VA = "0x28300F4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600A214")]
	[Address(RVA = "0x2830158", Offset = "0x2830158", VA = "0x2830158")]
	protected void Update()
	{
	}

	[Token(Token = "0x600A215")]
	[Address(RVA = "0x282FDC8", Offset = "0x282FDC8", VA = "0x282FDC8")]
	public void RefreshUI()
	{
	}

	[Token(Token = "0x600A216")]
	[Address(RVA = "0x283065C", Offset = "0x283065C", VA = "0x283065C")]
	private int SortEntranceItem(UIOnlineMatchEntranceItemController a, UIOnlineMatchEntranceItemController b)
	{
		return default(int);
	}

	[Token(Token = "0x600A217")]
	[Address(RVA = "0x28308BC", Offset = "0x28308BC", VA = "0x28308BC")]
	private int SortEntranceItem(Transform a, Transform b)
	{
		return default(int);
	}

	[Token(Token = "0x600A218")]
	[Address(RVA = "0x28301D0", Offset = "0x28301D0", VA = "0x28301D0")]
	private void CreateChampionshipEntrance()
	{
	}

	[Token(Token = "0x600A219")]
	[Address(RVA = "0x28303B0", Offset = "0x28303B0", VA = "0x28303B0")]
	private void CreateCupMatchEntrance()
	{
	}

	[Token(Token = "0x600A21A")]
	[Address(RVA = "0x28309D4", Offset = "0x28309D4", VA = "0x28309D4")]
	public void OnEntranceItemShowDetail(bool forward, int index)
	{
	}

	[Token(Token = "0x600A21B")]
	[Address(RVA = "0x2830B8C", Offset = "0x2830B8C", VA = "0x2830B8C")]
	private void OnGridReposition()
	{
	}

	[Token(Token = "0x600A21C")]
	[Address(RVA = "0x2830CB0", Offset = "0x2830CB0", VA = "0x2830CB0")]
	public int GetEntranceCount()
	{
		return default(int);
	}

	[Token(Token = "0x600A21D")]
	[Address(RVA = "0x2830D70", Offset = "0x2830D70", VA = "0x2830D70")]
	protected void OnRuleButtonClick()
	{
	}

	[Token(Token = "0x600A21E")]
	[Address(RVA = "0x2830FC0", Offset = "0x2830FC0", VA = "0x2830FC0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A21F")]
	[Address(RVA = "0x2830FC8", Offset = "0x2830FC8", VA = "0x2830FC8")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
