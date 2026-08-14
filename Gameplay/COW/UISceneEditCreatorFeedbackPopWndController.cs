using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200234A")]
public class UISceneEditCreatorFeedbackPopWndController : UIPopupWindowController
{
	[Token(Token = "0x200234B")]
	private sealed class _003CUpdateView_003Ec__AnonStorey0
	{
		[Token(Token = "0x400DBE3")]
		[FieldOffset(Offset = "0x8")]
		internal UGCRemarkRuleData fillData;

		[Token(Token = "0x600C49C")]
		[Address(RVA = "0x14AC650", Offset = "0x14AC650", VA = "0x14AC650")]
		public _003CUpdateView_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C49D")]
		[Address(RVA = "0x14ACBBC", Offset = "0x14ACBBC", VA = "0x14ACBBC")]
		internal bool _003C_003Em__0(UGCRemarkData data)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400DBD5")]
	private const string LIKED_ICON = "UI_Customize_like_icon";

	[Token(Token = "0x400DBD6")]
	private const string EXPERIENCE_ICON = "UI_Customize_ty_icon";

	[Token(Token = "0x400DBD7")]
	private const string SUBSCRIBE_ICON = "UI_Customize_subscribe_icon";

	[Token(Token = "0x400DBD8")]
	private const string LOOKED_ICON = "UI_Customize_yl_icon";

	[Token(Token = "0x400DBD9")]
	[FieldOffset(Offset = "0x48")]
	private UISceneEditCreatorFeedbackPopWndView m_View;

	[Token(Token = "0x400DBDA")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x400DBDB")]
	[FieldOffset(Offset = "0x50")]
	private UIModelSceneEdit.CreatorFeedBackData m_LastSaveData;

	[Token(Token = "0x400DBDC")]
	[FieldOffset(Offset = "0x54")]
	private List<UGCRemarkData> m_RemarkList;

	[Token(Token = "0x400DBDD")]
	[FieldOffset(Offset = "0x58")]
	private ulong m_Liked;

	[Token(Token = "0x400DBDE")]
	[FieldOffset(Offset = "0x60")]
	private ulong m_SubscriptionTimes;

	[Token(Token = "0x400DBDF")]
	[FieldOffset(Offset = "0x68")]
	private ulong m_DifLiked;

	[Token(Token = "0x400DBE0")]
	[FieldOffset(Offset = "0x70")]
	private ulong m_DifSubscriptionTimes;

	[Token(Token = "0x400DBE1")]
	[FieldOffset(Offset = "0x78")]
	private ulong m_ExperienceTimes;

	[Token(Token = "0x400DBE2")]
	[FieldOffset(Offset = "0x80")]
	private ulong m_LookTimes;

	[Token(Token = "0x600C492")]
	[Address(RVA = "0x14AB6D4", Offset = "0x14AB6D4", VA = "0x14AB6D4")]
	public UISceneEditCreatorFeedbackPopWndController()
	{
	}

	[Token(Token = "0x600C493")]
	[Address(RVA = "0x14AB6DC", Offset = "0x14AB6DC", VA = "0x14AB6DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C494")]
	[Address(RVA = "0x14AB780", Offset = "0x14AB780", VA = "0x14AB780", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C495")]
	[Address(RVA = "0x14ABE44", Offset = "0x14ABE44", VA = "0x14ABE44")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600C496")]
	[Address(RVA = "0x14AC780", Offset = "0x14AC780", VA = "0x14AC780")]
	private void UpdateNodeView(Transform node, uint type)
	{
	}

	[Token(Token = "0x600C497")]
	[Address(RVA = "0x14AC9AC", Offset = "0x14AC9AC", VA = "0x14AC9AC")]
	private string GetIconName(uint type)
	{
		return null;
	}

	[Token(Token = "0x600C498")]
	[Address(RVA = "0x14ACAF8", Offset = "0x14ACAF8", VA = "0x14ACAF8")]
	public ulong GetShowData(uint type)
	{
		return default(ulong);
	}

	[Token(Token = "0x600C499")]
	[Address(RVA = "0x14ABC58", Offset = "0x14ABC58", VA = "0x14ABC58")]
	public static ulong RandomULong(ulong A, ulong B)
	{
		return default(ulong);
	}

	[Token(Token = "0x600C49A")]
	[Address(RVA = "0x14AC658", Offset = "0x14AC658", VA = "0x14AC658")]
	private bool IsFillCondition(uint type, ulong data)
	{
		return default(bool);
	}

	[Token(Token = "0x600C49B")]
	[Address(RVA = "0x14ACBB4", Offset = "0x14ACBB4", VA = "0x14ACBB4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
