using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002338")]
public class UIHudSceneEditLeftOptionController : UIBaseController
{
	[Token(Token = "0x400DB68")]
	private const string ENABLE_REVERT_ICON = "UI_Customize_Revoke_icon";

	[Token(Token = "0x400DB69")]
	private const string DISABLE_REVERT_ICON = "UI_Customize_Revoke_icon1";

	[Token(Token = "0x400DB6A")]
	private const string LOCK_VIEW_ICON = "UI_Customize_sj_icon";

	[Token(Token = "0x400DB6B")]
	private const string FREE_VIEW_ICON = "UI_Customize_sj_icon1";

	[Token(Token = "0x400DB6C")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditLeftOptionView m_View;

	[Token(Token = "0x400DB6D")]
	[FieldOffset(Offset = "0x2C")]
	private JPPGAJBAAKK m_CurrentGame;

	[Token(Token = "0x400DB6E")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_BtnsToBeHideList;

	[Token(Token = "0x400DB6F")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsBtnsHide;

	[Token(Token = "0x600C38E")]
	[Address(RVA = "0x24DDAB0", Offset = "0x24DDAB0", VA = "0x24DDAB0")]
	public UIHudSceneEditLeftOptionController()
	{
	}

	[Token(Token = "0x600C38F")]
	[Address(RVA = "0x24DDB68", Offset = "0x24DDB68", VA = "0x24DDB68")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C390")]
	[Address(RVA = "0x24DDC0C", Offset = "0x24DDC0C", VA = "0x24DDC0C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C391")]
	[Address(RVA = "0x24DE348", Offset = "0x24DE348", VA = "0x24DE348")]
	private void OnClickMoreSettingBtn()
	{
	}

	[Token(Token = "0x600C392")]
	[Address(RVA = "0x24DE454", Offset = "0x24DE454", VA = "0x24DE454")]
	private void OnClickRevertBtn()
	{
	}

	[Token(Token = "0x600C393")]
	[Address(RVA = "0x24DE60C", Offset = "0x24DE60C", VA = "0x24DE60C")]
	private void OnRefreshRevertBtnState(object[] data)
	{
	}

	[Token(Token = "0x600C394")]
	[Address(RVA = "0x24DE740", Offset = "0x24DE740", VA = "0x24DE740")]
	private void OnClickHomeBtn(object[] data)
	{
	}

	[Token(Token = "0x600C395")]
	[Address(RVA = "0x24DE864", Offset = "0x24DE864", VA = "0x24DE864")]
	private void OnClickSwitchSighBtn()
	{
	}

	[Token(Token = "0x600C396")]
	[Address(RVA = "0x24DEA10", Offset = "0x24DEA10", VA = "0x24DEA10")]
	private void OnClickOpenHudEditorBtn()
	{
	}

	[Token(Token = "0x600C397")]
	[Address(RVA = "0x24DE1C4", Offset = "0x24DE1C4", VA = "0x24DE1C4")]
	private void RefreshOpenHudEditorBtn()
	{
	}

	[Token(Token = "0x600C398")]
	[Address(RVA = "0x24DEB20", Offset = "0x24DEB20", VA = "0x24DEB20")]
	private void OnGroupModeChanged(object[] data)
	{
	}

	[Token(Token = "0x600C399")]
	[Address(RVA = "0x24DEBE0", Offset = "0x24DEBE0", VA = "0x24DEBE0")]
	private void OnGameModeChanged(object[] data)
	{
	}

	[Token(Token = "0x600C39A")]
	[Address(RVA = "0x24DEC48", Offset = "0x24DEC48", VA = "0x24DEC48")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
