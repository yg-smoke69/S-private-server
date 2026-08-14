using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200200D")]
public class UIChampionshipMemberReviewPopupController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x200200E")]
	public class ApplyEasyListFacotry : _Attribute
	{
		[Token(Token = "0x400C96B")]
		[FieldOffset(Offset = "0x8")]
		private UIChampionshipMemberReviewPopupController teamProfile;

		[Token(Token = "0x600A233")]
		[Address(RVA = "0x2831720", Offset = "0x2831720", VA = "0x2831720")]
		public ApplyEasyListFacotry(UIChampionshipMemberReviewPopupController teamProfile)
		{
		}

		[Token(Token = "0x600A234")]
		[Address(RVA = "0x283297C", Offset = "0x283297C", VA = "0x283297C", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600A235")]
		[Address(RVA = "0x28329F8", Offset = "0x28329F8", VA = "0x28329F8", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Token(Token = "0x200200F")]
	public class InviteEasyListFacotry : _Attribute
	{
		[Token(Token = "0x400C96C")]
		[FieldOffset(Offset = "0x8")]
		private UIChampionshipMemberReviewPopupController teamProfile;

		[Token(Token = "0x600A236")]
		[Address(RVA = "0x2831740", Offset = "0x2831740", VA = "0x2831740")]
		public InviteEasyListFacotry(UIChampionshipMemberReviewPopupController teamProfile)
		{
		}

		[Token(Token = "0x600A237")]
		[Address(RVA = "0x2832C08", Offset = "0x2832C08", VA = "0x2832C08", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600A238")]
		[Address(RVA = "0x2832C84", Offset = "0x2832C84", VA = "0x2832C84", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Token(Token = "0x400C962")]
	[FieldOffset(Offset = "0x48")]
	private UIChampionshipMemberReviewPopupView m_View;

	[Token(Token = "0x400C963")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C964")]
	[FieldOffset(Offset = "0x50")]
	protected ApplyEasyListFacotry m_ApplyEasyListFactory;

	[Token(Token = "0x400C965")]
	[FieldOffset(Offset = "0x54")]
	protected InviteEasyListFacotry m_InviteEasyListFactory;

	[Token(Token = "0x400C966")]
	[FieldOffset(Offset = "0x58")]
	private uint m_ChampionshipType;

	[Token(Token = "0x400C967")]
	private const string TabApply = "TabApply";

	[Token(Token = "0x400C968")]
	private const string TabInvite = "TabInvite";

	[Token(Token = "0x400C969")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<AccountInfoBasic, ulong> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400C96A")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<AccountInfoBasic, ulong> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600A220")]
	[Address(RVA = "0x28311E8", Offset = "0x28311E8", VA = "0x28311E8")]
	public UIChampionshipMemberReviewPopupController()
	{
	}

	[Token(Token = "0x600A221")]
	[Address(RVA = "0x28311F0", Offset = "0x28311F0", VA = "0x28311F0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A222")]
	[Address(RVA = "0x2831294", Offset = "0x2831294", VA = "0x2831294", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A223")]
	[Address(RVA = "0x2831760", Offset = "0x2831760", VA = "0x2831760", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A224")]
	[Address(RVA = "0x28317E8", Offset = "0x28317E8", VA = "0x28317E8")]
	public void SetInviteView(uint championshipType)
	{
	}

	[Token(Token = "0x600A225")]
	[Address(RVA = "0x2831C0C", Offset = "0x2831C0C", VA = "0x2831C0C")]
	public void SetChampionshipType(uint championshipType)
	{
	}

	[Token(Token = "0x600A226")]
	[Address(RVA = "0x2831C6C", Offset = "0x2831C6C", VA = "0x2831C6C")]
	public void SetApplyAndInviteView()
	{
	}

	[Token(Token = "0x600A227")]
	[Address(RVA = "0x2831ECC", Offset = "0x2831ECC", VA = "0x2831ECC")]
	private void ShowApplyPage()
	{
	}

	[Token(Token = "0x600A228")]
	[Address(RVA = "0x2831A54", Offset = "0x2831A54", VA = "0x2831A54")]
	private void ShowInvitePage()
	{
	}

	[Token(Token = "0x600A229")]
	[Address(RVA = "0x2832084", Offset = "0x2832084", VA = "0x2832084")]
	private void RejectAllApply()
	{
	}

	[Token(Token = "0x600A22A")]
	[Address(RVA = "0x2832240", Offset = "0x2832240", VA = "0x2832240")]
	private void RejectAllInvite()
	{
	}

	[Token(Token = "0x600A22B")]
	[Address(RVA = "0x28323F8", Offset = "0x28323F8", VA = "0x28323F8")]
	private void UpdateInvitation()
	{
	}

	[Token(Token = "0x600A22C")]
	[Address(RVA = "0x28325D0", Offset = "0x28325D0", VA = "0x28325D0")]
	private void UpdateApplicant()
	{
	}

	[Token(Token = "0x600A22D")]
	[Address(RVA = "0x28327A8", Offset = "0x28327A8", VA = "0x28327A8", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A22E")]
	[Address(RVA = "0x2832890", Offset = "0x2832890", VA = "0x2832890", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A22F")]
	[Address(RVA = "0x2832924", Offset = "0x2832924", VA = "0x2832924")]
	private static ulong _003CRejectAllApply_003Em__0(AccountInfoBasic e)
	{
		return default(ulong);
	}

	[Token(Token = "0x600A230")]
	[Address(RVA = "0x2832948", Offset = "0x2832948", VA = "0x2832948")]
	private static ulong _003CRejectAllInvite_003Em__1(AccountInfoBasic e)
	{
		return default(ulong);
	}

	[Token(Token = "0x600A231")]
	[Address(RVA = "0x283296C", Offset = "0x283296C", VA = "0x283296C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A232")]
	[Address(RVA = "0x2832974", Offset = "0x2832974", VA = "0x2832974")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
