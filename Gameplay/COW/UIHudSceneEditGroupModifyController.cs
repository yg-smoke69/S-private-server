using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200232E")]
public class UIHudSceneEditGroupModifyController : UIBaseController
{
	[Token(Token = "0x400DB38")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditGroupModifyView m_View;

	[Token(Token = "0x400DB39")]
	private const string ADD_READY_GROUP_ICON = "UI_Customize_group_icon3";

	[Token(Token = "0x400DB3A")]
	private const string REMOVE_READY_GROUP_ICON = "UI_Customize_group_icon4";

	[Token(Token = "0x400DB3B")]
	private const string GROUP_CONFIRM_ICON = "UI_Customize_group_icon1";

	[Token(Token = "0x400DB3C")]
	private const string GROUP_CANCEL_ICON = "UI_Customize_group_icon2";

	[Token(Token = "0x400DB3D")]
	[FieldOffset(Offset = "0x2C")]
	private EventDelegate m_OnModifyGroupBtnDown;

	[Token(Token = "0x400DB3E")]
	[FieldOffset(Offset = "0x30")]
	private EventDelegate m_OnModifyGroupBtnUp;

	[Token(Token = "0x400DB3F")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsPressModifyGroupBtn;

	[Token(Token = "0x400DB40")]
	[FieldOffset(Offset = "0x35")]
	private bool m_IsAddToReadyGroup;

	[Token(Token = "0x400DB41")]
	[FieldOffset(Offset = "0x36")]
	private bool m_IsConfirmGroup;

	[Token(Token = "0x170010B7")]
	private int m_CurrentModifyGroupIndex
	{
		[Token(Token = "0x600C329")]
		[Address(RVA = "0x24D1A38", Offset = "0x24D1A38", VA = "0x24D1A38")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170010B8")]
	private SceneEditAgent m_Agent
	{
		[Token(Token = "0x600C32B")]
		[Address(RVA = "0x24D1B9C", Offset = "0x24D1B9C", VA = "0x24D1B9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600C328")]
	[Address(RVA = "0x24D19B4", Offset = "0x24D19B4", VA = "0x24D19B4")]
	public UIHudSceneEditGroupModifyController()
	{
	}

	[Token(Token = "0x600C32A")]
	[Address(RVA = "0x24D1C64", Offset = "0x24D1C64", VA = "0x24D1C64")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C32C")]
	[Address(RVA = "0x24D1D08", Offset = "0x24D1D08", VA = "0x24D1D08", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C32D")]
	[Address(RVA = "0x24D24C8", Offset = "0x24D24C8", VA = "0x24D24C8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C32E")]
	[Address(RVA = "0x24D2550", Offset = "0x24D2550", VA = "0x24D2550")]
	private void RefreshDelBtn()
	{
	}

	[Token(Token = "0x600C32F")]
	[Address(RVA = "0x24D26D8", Offset = "0x24D26D8", VA = "0x24D26D8")]
	private void OnGroupRemove(object[] data)
	{
	}

	[Token(Token = "0x600C330")]
	[Address(RVA = "0x24D2744", Offset = "0x24D2744", VA = "0x24D2744")]
	private void OnGroupModeChanged(object[] data)
	{
	}

	[Token(Token = "0x600C331")]
	[Address(RVA = "0x24D20DC", Offset = "0x24D20DC", VA = "0x24D20DC")]
	private void RefreshConfirmState(bool active)
	{
	}

	[Token(Token = "0x600C332")]
	[Address(RVA = "0x24D2840", Offset = "0x24D2840", VA = "0x24D2840")]
	private void UpdateConfirmIconShow()
	{
	}

	[Token(Token = "0x600C333")]
	[Address(RVA = "0x24D2B54", Offset = "0x24D2B54", VA = "0x24D2B54")]
	private void OnBtnDelete()
	{
	}

	[Token(Token = "0x600C334")]
	[Address(RVA = "0x24D2DF4", Offset = "0x24D2DF4", VA = "0x24D2DF4")]
	private void OnClickConfirmReadyGroupBtn()
	{
	}

	[Token(Token = "0x600C335")]
	[Address(RVA = "0x24D3374", Offset = "0x24D3374", VA = "0x24D3374")]
	private bool ModifyCurrentSelectedInReadyGroup(bool isAdd)
	{
		return default(bool);
	}

	[Token(Token = "0x600C336")]
	[Address(RVA = "0x24D2D04", Offset = "0x24D2D04", VA = "0x24D2D04")]
	private void RefreshAddGroupIcon()
	{
	}

	[Token(Token = "0x600C337")]
	[Address(RVA = "0x24D3658", Offset = "0x24D3658", VA = "0x24D3658")]
	private void OnSceneEditPrefabChosen(object[] data)
	{
	}

	[Token(Token = "0x600C338")]
	[Address(RVA = "0x24D21D8", Offset = "0x24D21D8", VA = "0x24D21D8")]
	private void SetModifyGroupButtonClickEventDelegate(UIButton button)
	{
	}

	[Token(Token = "0x600C339")]
	[Address(RVA = "0x24D3D80", Offset = "0x24D3D80", VA = "0x24D3D80")]
	private void OnModifyGroupBtnDown()
	{
	}

	[Token(Token = "0x600C33A")]
	[Address(RVA = "0x24D3DEC", Offset = "0x24D3DEC", VA = "0x24D3DEC")]
	private void OnModifyGroupBtnUp()
	{
	}

	[Token(Token = "0x600C33B")]
	[Address(RVA = "0x24D4018", Offset = "0x24D4018", VA = "0x24D4018", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C33C")]
	[Address(RVA = "0x24D39C8", Offset = "0x24D39C8", VA = "0x24D39C8")]
	private void TutorialAddReadyGroupBtn()
	{
	}

	[Token(Token = "0x600C33D")]
	[Address(RVA = "0x24D2978", Offset = "0x24D2978", VA = "0x24D2978")]
	private void TutorialConfirmReadyGroupBtn()
	{
	}

	[Token(Token = "0x600C33E")]
	[Address(RVA = "0x24D3BA4", Offset = "0x24D3BA4", VA = "0x24D3BA4")]
	private void TutorialConfirmReadyGroupMoveBtn()
	{
	}

	[Token(Token = "0x600C33F")]
	[Address(RVA = "0x24D421C", Offset = "0x24D421C", VA = "0x24D421C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C340")]
	[Address(RVA = "0x24D4224", Offset = "0x24D4224", VA = "0x24D4224")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C341")]
	[Address(RVA = "0x24D422C", Offset = "0x24D422C", VA = "0x24D422C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
