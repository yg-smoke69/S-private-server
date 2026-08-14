using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002026")]
public class UIChampionshipTeamMemberItemController : UIEasyListItemController
{
	[Token(Token = "0x400C9DE")]
	[FieldOffset(Offset = "0x0")]
	private static Color OnlineColor;

	[Token(Token = "0x400C9DF")]
	[FieldOffset(Offset = "0x10")]
	private static Color OfflineColor;

	[Token(Token = "0x400C9E0")]
	[FieldOffset(Offset = "0x38")]
	private UIChampionshipTeamMemberItemView m_View;

	[Token(Token = "0x400C9E1")]
	[FieldOffset(Offset = "0x3C")]
	private UIBaseProfileInfoController m_BaseProfileUI;

	[Token(Token = "0x400C9E2")]
	[FieldOffset(Offset = "0x40")]
	private TeamMemberWithAccountInfo m_TeamMemberData;

	[Token(Token = "0x400C9E3")]
	[FieldOffset(Offset = "0x44")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C9E4")]
	[FieldOffset(Offset = "0x48")]
	private bool _003CShowPresence_003Ek__BackingField;

	[Token(Token = "0x400C9E5")]
	[FieldOffset(Offset = "0x49")]
	private bool _003CShowPopupMenu_003Ek__BackingField;

	[Token(Token = "0x17000FD3")]
	public bool ShowPresence
	{
		[Token(Token = "0x600A2FE")]
		[Address(RVA = "0x2617E6C", Offset = "0x2617E6C", VA = "0x2617E6C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A2FF")]
		[Address(RVA = "0x2617E74", Offset = "0x2617E74", VA = "0x2617E74")]
		set
		{
		}
	}

	[Token(Token = "0x17000FD4")]
	public bool ShowPopupMenu
	{
		[Token(Token = "0x600A300")]
		[Address(RVA = "0x2617E7C", Offset = "0x2617E7C", VA = "0x2617E7C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A301")]
		[Address(RVA = "0x2617E84", Offset = "0x2617E84", VA = "0x2617E84")]
		set
		{
		}
	}

	[Token(Token = "0x600A2FD")]
	[Address(RVA = "0x2617E64", Offset = "0x2617E64", VA = "0x2617E64")]
	public UIChampionshipTeamMemberItemController()
	{
	}

	[Token(Token = "0x600A302")]
	[Address(RVA = "0x2617E8C", Offset = "0x2617E8C", VA = "0x2617E8C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A303")]
	[Address(RVA = "0x2617F30", Offset = "0x2617F30", VA = "0x2617F30", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A304")]
	[Address(RVA = "0x26181EC", Offset = "0x26181EC", VA = "0x26181EC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600A305")]
	[Address(RVA = "0x2618250", Offset = "0x2618250", VA = "0x2618250")]
	private void OnProfileClick()
	{
	}

	[Token(Token = "0x600A306")]
	[Address(RVA = "0x2618578", Offset = "0x2618578", VA = "0x2618578", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A307")]
	[Address(RVA = "0x2618794", Offset = "0x2618794", VA = "0x2618794")]
	private void UpdateOnlineStateView()
	{
	}

	[Token(Token = "0x600A309")]
	[Address(RVA = "0x2618B44", Offset = "0x2618B44", VA = "0x2618B44")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A30A")]
	[Address(RVA = "0x2618B4C", Offset = "0x2618B4C", VA = "0x2618B4C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
