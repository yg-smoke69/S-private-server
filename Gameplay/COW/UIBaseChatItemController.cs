using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x20024F4")]
public class UIBaseChatItemController : UIBaseController
{
	[Token(Token = "0x400E542")]
	[FieldOffset(Offset = "0x28")]
	protected BaseChatMessageView LeftView;

	[Token(Token = "0x400E543")]
	[FieldOffset(Offset = "0x2C")]
	protected UIButton headbtnleft;

	[Token(Token = "0x400E544")]
	[FieldOffset(Offset = "0x30")]
	protected UIButton LeftContentBtn;

	[Token(Token = "0x400E545")]
	[FieldOffset(Offset = "0x34")]
	protected BaseChatMessageView RightView;

	[Token(Token = "0x400E546")]
	[FieldOffset(Offset = "0x38")]
	protected UIButton headbtn;

	[Token(Token = "0x400E547")]
	[FieldOffset(Offset = "0x3C")]
	protected UIButton RightContentBtn;

	[Token(Token = "0x400E548")]
	[FieldOffset(Offset = "0x40")]
	protected UIButton QuickAddFriendBtn;

	[Token(Token = "0x400E549")]
	[FieldOffset(Offset = "0x44")]
	protected UILabel QuickAddFriendLabel;

	[Token(Token = "0x400E54A")]
	[FieldOffset(Offset = "0x48")]
	protected GameObject ChatTips;

	[Token(Token = "0x400E54B")]
	[FieldOffset(Offset = "0x4C")]
	protected GameObject PrivateWarning;

	[Token(Token = "0x400E54C")]
	[FieldOffset(Offset = "0x50")]
	protected GameObject AddFriendTip;

	[Token(Token = "0x400E54D")]
	[FieldOffset(Offset = "0x54")]
	protected GameObject AddFriendBtnContainer;

	[Token(Token = "0x400E54E")]
	[FieldOffset(Offset = "0x58")]
	protected UISprite AddFriendBtnSprite;

	[Token(Token = "0x400E54F")]
	[FieldOffset(Offset = "0x5C")]
	protected UISprite AddFriendBtnIcon;

	[Token(Token = "0x400E550")]
	[FieldOffset(Offset = "0x60")]
	protected UISprite AddFriendBtnLight;

	[Token(Token = "0x400E551")]
	[FieldOffset(Offset = "0x64")]
	protected MessageInfo m_Data;

	[Token(Token = "0x400E552")]
	[FieldOffset(Offset = "0x68")]
	private float defaultLeftViewOffset;

	[Token(Token = "0x400E553")]
	[FieldOffset(Offset = "0x6C")]
	private float defaultRightViewOffset;

	[Token(Token = "0x400E554")]
	[FieldOffset(Offset = "0x70")]
	private float defaultItemWidth;

	[Token(Token = "0x400E555")]
	[FieldOffset(Offset = "0x74")]
	private float defaultViewYAxis;

	[Token(Token = "0x400E556")]
	[FieldOffset(Offset = "0x78")]
	private float changeViewYAxis;

	[Token(Token = "0x400E557")]
	[FieldOffset(Offset = "0x7C")]
	private UIBigEventChatMsgItemController m_LeftBigEventMsgItemCtrl;

	[Token(Token = "0x400E558")]
	[FieldOffset(Offset = "0x80")]
	private UIBigEventChatMsgItemController m_RightBigEventMsgItemCtrl;

	[Token(Token = "0x400E559")]
	[FieldOffset(Offset = "0x84")]
	private string m_BannerBgSpriteName;

	[Token(Token = "0x400E55A")]
	[FieldOffset(Offset = "0x0")]
	private static Action<object> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x17001143")]
	public Bounds bounds
	{
		[Token(Token = "0x600D553")]
		[Address(RVA = "0x1405528", Offset = "0x1405528", VA = "0x1405528")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Bounds);
		}
	}

	[Token(Token = "0x600D552")]
	[Address(RVA = "0x1405498", Offset = "0x1405498", VA = "0x1405498")]
	public UIBaseChatItemController()
	{
	}

	[Token(Token = "0x600D554")]
	[Address(RVA = "0x14055A8", Offset = "0x14055A8", VA = "0x14055A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D555")]
	[Address(RVA = "0x1405A24", Offset = "0x1405A24", VA = "0x1405A24", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D556")]
	[Address(RVA = "0x1405A88", Offset = "0x1405A88", VA = "0x1405A88", Slot = "31")]
	protected virtual EChannel.ChannelType GetParentChannelType()
	{
		return default(EChannel.ChannelType);
	}

	[Token(Token = "0x600D557")]
	[Address(RVA = "0x1405AE0", Offset = "0x1405AE0", VA = "0x1405AE0")]
	protected void OnHeadBtnClick()
	{
	}

	[Token(Token = "0x600D558")]
	[Address(RVA = "0x1406690", Offset = "0x1406690", VA = "0x1406690")]
	protected void OnQuickAddFriendBtnClick()
	{
	}

	[Token(Token = "0x600D559")]
	[Address(RVA = "0x1406A44", Offset = "0x1406A44", VA = "0x1406A44", Slot = "32")]
	public virtual void OpenIteractionPanel(InteractionPopUtil.UIInteractionPoptype PopType)
	{
	}

	[Token(Token = "0x600D55A")]
	[Address(RVA = "0x1406AD0", Offset = "0x1406AD0", VA = "0x1406AD0")]
	private void SetMessageUI(BaseChatMessageView view, bool showState)
	{
	}

	[Token(Token = "0x600D55B")]
	[Address(RVA = "0x1406BD0", Offset = "0x1406BD0", VA = "0x1406BD0", Slot = "33")]
	public virtual void SetUIData(MessageInfo info, [Optional] Transform parent)
	{
	}

	[Token(Token = "0x600D55C")]
	[Address(RVA = "0x1407B5C", Offset = "0x1407B5C", VA = "0x1407B5C")]
	public void ReSetBannerBg()
	{
	}

	[Token(Token = "0x600D55D")]
	[Address(RVA = "0x1407CD0", Offset = "0x1407CD0", VA = "0x1407CD0")]
	public bool IsShowBanner()
	{
		return default(bool);
	}

	[Token(Token = "0x600D55E")]
	[Address(RVA = "0x1407D9C", Offset = "0x1407D9C", VA = "0x1407D9C")]
	public void AdjustLayout(float clipWidth)
	{
	}

	[Token(Token = "0x600D55F")]
	[Address(RVA = "0x1407FAC", Offset = "0x1407FAC", VA = "0x1407FAC", Slot = "34")]
	public virtual void UpdateProfileInfo()
	{
	}

	[Token(Token = "0x600D560")]
	[Address(RVA = "0x14081C8", Offset = "0x14081C8", VA = "0x14081C8", Slot = "35")]
	protected virtual void OnResendBtnClick()
	{
	}

	[Token(Token = "0x600D561")]
	[Address(RVA = "0x14082F0", Offset = "0x14082F0", VA = "0x14082F0", Slot = "36")]
	protected virtual void OnClickJoin()
	{
	}

	[Token(Token = "0x600D562")]
	[Address(RVA = "0x140841C", Offset = "0x140841C", VA = "0x140841C")]
	protected void OnContentClick()
	{
	}

	[Token(Token = "0x600D563")]
	[Address(RVA = "0x1408C34", Offset = "0x1408C34", VA = "0x1408C34")]
	private void GoToReportBoard(object content)
	{
	}

	[Token(Token = "0x600D564")]
	[Address(RVA = "0x1409138", Offset = "0x1409138", VA = "0x1409138")]
	protected static void CopyToClipBoard(object content)
	{
	}

	[Token(Token = "0x600D565")]
	[Address(RVA = "0x1409400", Offset = "0x1409400", VA = "0x1409400")]
	private bool _003COnHeadBtnClick_003Em__0(ClanMember temp)
	{
		return default(bool);
	}

	[Token(Token = "0x600D566")]
	[Address(RVA = "0x1409468", Offset = "0x1409468", VA = "0x1409468")]
	private bool _003COnHeadBtnClick_003Em__1(ClanMember temp)
	{
		return default(bool);
	}

	[Token(Token = "0x600D567")]
	[Address(RVA = "0x14094D0", Offset = "0x14094D0", VA = "0x14094D0")]
	private bool _003COnHeadBtnClick_003Em__2(ClanMember temp)
	{
		return default(bool);
	}

	[Token(Token = "0x600D568")]
	[Address(RVA = "0x1409538", Offset = "0x1409538", VA = "0x1409538")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D569")]
	[Address(RVA = "0x1409540", Offset = "0x1409540", VA = "0x1409540")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
