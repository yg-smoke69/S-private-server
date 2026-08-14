using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200208D")]
public class UICupMatchTeamProfileController : UIBaseController
{
	[Token(Token = "0x200208E")]
	public class InfoEasyListFactory : _Attribute
	{
		[Token(Token = "0x400CC14")]
		[FieldOffset(Offset = "0x8")]
		private UICupMatchTeamProfileController teamProfile;

		[Token(Token = "0x400CC15")]
		[FieldOffset(Offset = "0xC")]
		public bool ShowPresence;

		[Token(Token = "0x400CC16")]
		[FieldOffset(Offset = "0xD")]
		public bool ShowPopupMenu;

		[Token(Token = "0x400CC17")]
		[FieldOffset(Offset = "0x10")]
		public int CupMatchKey;

		[Token(Token = "0x600A791")]
		[Address(RVA = "0x11E071C", Offset = "0x11E071C", VA = "0x11E071C")]
		public InfoEasyListFactory(UICupMatchTeamProfileController teamProfile)
		{
		}

		[Token(Token = "0x600A792")]
		[Address(RVA = "0x11E0D94", Offset = "0x11E0D94", VA = "0x11E0D94", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600A793")]
		[Address(RVA = "0x11E0E10", Offset = "0x11E0E10", VA = "0x11E0E10", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Token(Token = "0x400CC0E")]
	[FieldOffset(Offset = "0x28")]
	public UICupMatchTeamProfileView m_View;

	[Token(Token = "0x400CC0F")]
	[FieldOffset(Offset = "0x2C")]
	protected InfoEasyListFactory m_InfoEasyListFactory;

	[Token(Token = "0x400CC10")]
	[FieldOffset(Offset = "0x30")]
	protected UICupMatchTeamOverviewController m_TeamOverviewUI;

	[Token(Token = "0x400CC11")]
	[FieldOffset(Offset = "0x34")]
	protected int m_CupMatchKey;

	[Token(Token = "0x400CC12")]
	[FieldOffset(Offset = "0x38")]
	protected Vector3 m_RecruitBtnInitPos;

	[Token(Token = "0x400CC13")]
	private const float ITEM_HEIGHT = 102f;

	[Token(Token = "0x600A789")]
	[Address(RVA = "0x11E0088", Offset = "0x11E0088", VA = "0x11E0088")]
	public UICupMatchTeamProfileController()
	{
	}

	[Token(Token = "0x600A78A")]
	[Address(RVA = "0x11E010C", Offset = "0x11E010C", VA = "0x11E010C")]
	public static ResourceID UIResource()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A78B")]
	[Address(RVA = "0x11E01B4", Offset = "0x11E01B4", VA = "0x11E01B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A78C")]
	public T OpenChild<T>(Transform parent) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x600A78D")]
	[Address(RVA = "0x11E0748", Offset = "0x11E0748", VA = "0x11E0748")]
	protected Bounds CalcPriceContainerBounds(Transform priceContainer)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Bounds);
	}

	[Token(Token = "0x600A78E")]
	[Address(RVA = "0x11E07E8", Offset = "0x11E07E8", VA = "0x11E07E8")]
	protected void UpdateRecruitPostion(List<UIModelCupMatch.AccountInfoBasicWithCupInfo> list)
	{
	}

	[Token(Token = "0x600A78F")]
	[Address(RVA = "0x11E0B14", Offset = "0x11E0B14", VA = "0x11E0B14")]
	public void UpdateTeamMemberView(CupTeamInfo teamInfo, List<UIModelCupMatch.AccountInfoBasicWithCupInfo> members, bool sortPresence = false)
	{
	}

	[Token(Token = "0x600A790")]
	[Address(RVA = "0x11E0D8C", Offset = "0x11E0D8C", VA = "0x11E0D8C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
