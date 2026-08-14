using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002071")]
public class UICupMatchMemberReviewPopupController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002072")]
	private enum PageType
	{
		[Token(Token = "0x400CB7C")]
		Apply,
		[Token(Token = "0x400CB7D")]
		Invite
	}

	[Token(Token = "0x2002073")]
	public class ApplyEasyListFacotry : _Attribute
	{
		[Token(Token = "0x400CB7E")]
		[FieldOffset(Offset = "0x8")]
		private UICupMatchMemberReviewPopupController teamProfile;

		[Token(Token = "0x600A685")]
		[Address(RVA = "0x2AA69A8", Offset = "0x2AA69A8", VA = "0x2AA69A8")]
		public ApplyEasyListFacotry(UICupMatchMemberReviewPopupController teamProfile)
		{
		}

		[Token(Token = "0x600A686")]
		[Address(RVA = "0x2AA86BC", Offset = "0x2AA86BC", VA = "0x2AA86BC", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600A687")]
		[Address(RVA = "0x2AA8738", Offset = "0x2AA8738", VA = "0x2AA8738", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Token(Token = "0x2002074")]
	public class InviteEasyListFacotry : _Attribute
	{
		[Token(Token = "0x400CB7F")]
		[FieldOffset(Offset = "0x8")]
		private UICupMatchMemberReviewPopupController teamProfile;

		[Token(Token = "0x600A688")]
		[Address(RVA = "0x2AA69C8", Offset = "0x2AA69C8", VA = "0x2AA69C8")]
		public InviteEasyListFacotry(UICupMatchMemberReviewPopupController teamProfile)
		{
		}

		[Token(Token = "0x600A689")]
		[Address(RVA = "0x2AA8948", Offset = "0x2AA8948", VA = "0x2AA8948", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600A68A")]
		[Address(RVA = "0x2AA89C4", Offset = "0x2AA89C4", VA = "0x2AA89C4", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Token(Token = "0x400CB73")]
	[FieldOffset(Offset = "0x48")]
	private UICupMatchMemberReviewPopupView m_View;

	[Token(Token = "0x400CB74")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CB75")]
	[FieldOffset(Offset = "0x50")]
	protected ApplyEasyListFacotry m_ApplyEasyListFactory;

	[Token(Token = "0x400CB76")]
	[FieldOffset(Offset = "0x54")]
	protected InviteEasyListFacotry m_InviteEasyListFactory;

	[Token(Token = "0x400CB77")]
	[FieldOffset(Offset = "0x58")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CB78")]
	[FieldOffset(Offset = "0x5C")]
	private PageType m_PageType;

	[Token(Token = "0x400CB79")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<UIModelCupMatch.AccountInfoBasicWithCupInfo, ulong> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400CB7A")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<UIModelCupMatch.AccountInfoBasicWithCupInfo, ulong> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600A66D")]
	[Address(RVA = "0x2AA6468", Offset = "0x2AA6468", VA = "0x2AA6468")]
	public UICupMatchMemberReviewPopupController()
	{
	}

	[Token(Token = "0x600A66E")]
	[Address(RVA = "0x2AA6470", Offset = "0x2AA6470", VA = "0x2AA6470")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A66F")]
	[Address(RVA = "0x2AA6518", Offset = "0x2AA6518", VA = "0x2AA6518", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A670")]
	[Address(RVA = "0x2AA69E8", Offset = "0x2AA69E8", VA = "0x2AA69E8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A671")]
	[Address(RVA = "0x2AA6A70", Offset = "0x2AA6A70", VA = "0x2AA6A70")]
	public void SetInviteView(int cupMatchKey)
	{
	}

	[Token(Token = "0x600A672")]
	[Address(RVA = "0x2AA6E3C", Offset = "0x2AA6E3C", VA = "0x2AA6E3C")]
	public void SetCupMatchType(int cupMatchKey)
	{
	}

	[Token(Token = "0x600A673")]
	[Address(RVA = "0x2AA7038", Offset = "0x2AA7038", VA = "0x2AA7038")]
	public void SetApplyAndInviteView()
	{
	}

	[Token(Token = "0x600A674")]
	[Address(RVA = "0x2AA7298", Offset = "0x2AA7298", VA = "0x2AA7298")]
	private void ShowApplyPage()
	{
	}

	[Token(Token = "0x600A675")]
	[Address(RVA = "0x2AA6CDC", Offset = "0x2AA6CDC", VA = "0x2AA6CDC")]
	private void ShowInvitePage()
	{
	}

	[Token(Token = "0x600A676")]
	[Address(RVA = "0x2AA7790", Offset = "0x2AA7790", VA = "0x2AA7790")]
	private void RejectAllApply()
	{
	}

	[Token(Token = "0x600A677")]
	[Address(RVA = "0x2AA7A28", Offset = "0x2AA7A28", VA = "0x2AA7A28")]
	private void RejectAllInvite()
	{
	}

	[Token(Token = "0x600A678")]
	[Address(RVA = "0x2AA7CBC", Offset = "0x2AA7CBC", VA = "0x2AA7CBC")]
	private void UpdateInvitation()
	{
	}

	[Token(Token = "0x600A679")]
	[Address(RVA = "0x2AA7E70", Offset = "0x2AA7E70", VA = "0x2AA7E70")]
	private void UpdateApplicant()
	{
	}

	[Token(Token = "0x600A67A")]
	[Address(RVA = "0x2AA6F74", Offset = "0x2AA6F74", VA = "0x2AA6F74")]
	private void UpdateInvitationRedTips()
	{
	}

	[Token(Token = "0x600A67B")]
	[Address(RVA = "0x2AA6EB0", Offset = "0x2AA6EB0", VA = "0x2AA6EB0")]
	private void UpdateApplicationRedTips()
	{
	}

	[Token(Token = "0x600A67C")]
	[Address(RVA = "0x2AA8024", Offset = "0x2AA8024", VA = "0x2AA8024")]
	private void OnRefreshBtnClick()
	{
	}

	[Token(Token = "0x600A67D")]
	[Address(RVA = "0x2AA73C8", Offset = "0x2AA73C8", VA = "0x2AA73C8")]
	private void SetRefreshBtnState()
	{
	}

	[Token(Token = "0x600A67E")]
	[Address(RVA = "0x2AA82A0", Offset = "0x2AA82A0", VA = "0x2AA82A0", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A67F")]
	[Address(RVA = "0x2AA84CC", Offset = "0x2AA84CC", VA = "0x2AA84CC", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A680")]
	[Address(RVA = "0x2AA8564", Offset = "0x2AA8564", VA = "0x2AA8564")]
	private static ulong _003CRejectAllApply_003Em__0(UIModelCupMatch.AccountInfoBasicWithCupInfo e)
	{
		return default(ulong);
	}

	[Token(Token = "0x600A681")]
	[Address(RVA = "0x2AA859C", Offset = "0x2AA859C", VA = "0x2AA859C")]
	private static ulong _003CRejectAllInvite_003Em__1(UIModelCupMatch.AccountInfoBasicWithCupInfo e)
	{
		return default(ulong);
	}

	[Token(Token = "0x600A682")]
	[Address(RVA = "0x2AA85D4", Offset = "0x2AA85D4", VA = "0x2AA85D4")]
	private void _003CSetRefreshBtnState_003Em__2()
	{
	}

	[Token(Token = "0x600A683")]
	[Address(RVA = "0x2AA86AC", Offset = "0x2AA86AC", VA = "0x2AA86AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A684")]
	[Address(RVA = "0x2AA86B4", Offset = "0x2AA86B4", VA = "0x2AA86B4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
