using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B05")]
public class UIRoomToggleBtnTemplateController : UIBaseController
{
	[Token(Token = "0x4010809")]
	[FieldOffset(Offset = "0x28")]
	private UIRoomToggleBtnTemplateView m_View;

	[Token(Token = "0x401080A")]
	[FieldOffset(Offset = "0x2C")]
	private Action m_EnableClickCallback;

	[Token(Token = "0x401080B")]
	[FieldOffset(Offset = "0x30")]
	private Action m_DisableClickCallback;

	[Token(Token = "0x401080C")]
	[FieldOffset(Offset = "0x34")]
	private string m_HelpKey;

	[Token(Token = "0x6011AA9")]
	[Address(RVA = "0x2BEF31C", Offset = "0x2BEF31C", VA = "0x2BEF31C")]
	public UIRoomToggleBtnTemplateController()
	{
	}

	[Token(Token = "0x6011AAA")]
	[Address(RVA = "0x2BEF3E8", Offset = "0x2BEF3E8", VA = "0x2BEF3E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011AAB")]
	[Address(RVA = "0x2BEF48C", Offset = "0x2BEF48C", VA = "0x2BEF48C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011AAC")]
	[Address(RVA = "0x2BEF6D0", Offset = "0x2BEF6D0", VA = "0x2BEF6D0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011AAD")]
	[Address(RVA = "0x2BEF7C4", Offset = "0x2BEF7C4", VA = "0x2BEF7C4")]
	public void SetToggleBtnInfo(bool initEnabled, string labelTxt, string enabledTxt = "TXT_OB9_ZJS_ROOM_WATCH_SWITCH_YES", string disabledTxt = "TXT_OB9_ZJS_ROOM_WATCH_SWITCH_NO", string helpKey = "")
	{
	}

	[Token(Token = "0x6011AAE")]
	[Address(RVA = "0x2BEFB60", Offset = "0x2BEFB60", VA = "0x2BEFB60")]
	public void RegisterCallBack(Action enableCB, Action disableCB)
	{
	}

	[Token(Token = "0x6011AAF")]
	[Address(RVA = "0x2BEFBE0", Offset = "0x2BEFBE0", VA = "0x2BEFBE0")]
	private void OnEnabledClick()
	{
	}

	[Token(Token = "0x6011AB0")]
	[Address(RVA = "0x2BEFC4C", Offset = "0x2BEFC4C", VA = "0x2BEFC4C")]
	private void OnDisabledClick()
	{
	}

	[Token(Token = "0x6011AB1")]
	[Address(RVA = "0x2BEFCB8", Offset = "0x2BEFCB8", VA = "0x2BEFCB8")]
	private void OnHelpClick()
	{
	}

	[Token(Token = "0x6011AB2")]
	[Address(RVA = "0x2BEFEF8", Offset = "0x2BEFEF8", VA = "0x2BEFEF8")]
	public void ChooseFirst(bool first)
	{
	}

	[Token(Token = "0x6011AB3")]
	[Address(RVA = "0x2BEFFE4", Offset = "0x2BEFFE4", VA = "0x2BEFFE4")]
	public void SetEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6011AB4")]
	[Address(RVA = "0x2BF01FC", Offset = "0x2BF01FC", VA = "0x2BF01FC")]
	public void SetStates(ERoom.DropPresetState state)
	{
	}

	[Token(Token = "0x6011AB5")]
	[Address(RVA = "0x2BF02D4", Offset = "0x2BF02D4", VA = "0x2BF02D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011AB6")]
	[Address(RVA = "0x2BF02DC", Offset = "0x2BF02DC", VA = "0x2BF02DC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
