using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027B8")]
public class UIHudMessageController : UIBaseController, _Attribute
{
	[Token(Token = "0x400F525")]
	[FieldOffset(Offset = "0x28")]
	private UIHudMessageView m_View;

	[Token(Token = "0x400F526")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelTeamReserve m_ModelTeamReserve;

	[Token(Token = "0x400F527")]
	[FieldOffset(Offset = "0x30")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400F528")]
	[FieldOffset(Offset = "0x34")]
	private List<UIHudReservationItemController> m_ReservationList;

	[Token(Token = "0x400F529")]
	[FieldOffset(Offset = "0x38")]
	private List<UIHudQuickChatItemController> m_QuickChatItemList;

	[Token(Token = "0x400F52A")]
	[FieldOffset(Offset = "0x3C")]
	private List<StickerSpriteView> m_StickerItemList;

	[Token(Token = "0x400F52B")]
	[FieldOffset(Offset = "0x40")]
	private UIClickMask m_ClickMask;

	[Token(Token = "0x400F52C")]
	public const int WIDGET_WIDTH = 276;

	[Token(Token = "0x400F52D")]
	public const int WIDGET_HEIGHT = 376;

	[Token(Token = "0x400F52E")]
	[FieldOffset(Offset = "0x44")]
	private TouchScreenKeyboard m_CurKeyBoard;

	[Token(Token = "0x400F52F")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsInCD;

	[Token(Token = "0x400F530")]
	[FieldOffset(Offset = "0x4C")]
	private float m_chatCD;

	[Token(Token = "0x400F531")]
	[FieldOffset(Offset = "0x50")]
	private uint m_CheckCDDelayCallID;

	[Token(Token = "0x400F532")]
	[FieldOffset(Offset = "0x54")]
	private string m_CachedText;

	[Token(Token = "0x400F533")]
	[FieldOffset(Offset = "0x58")]
	private int m_characterLimit;

	[Token(Token = "0x600F553")]
	[Address(RVA = "0x19C5454", Offset = "0x19C5454", VA = "0x19C5454")]
	public UIHudMessageController()
	{
	}

	[Token(Token = "0x600F554")]
	[Address(RVA = "0x19C5588", Offset = "0x19C5588", VA = "0x19C5588", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F555")]
	[Address(RVA = "0x19C723C", Offset = "0x19C723C", VA = "0x19C723C")]
	private void OnPlayerRevive(object[] data)
	{
	}

	[Token(Token = "0x600F556")]
	[Address(RVA = "0x19C74C8", Offset = "0x19C74C8", VA = "0x19C74C8")]
	private void OnPlayerDead(object[] data)
	{
	}

	[Token(Token = "0x600F557")]
	[Address(RVA = "0x19C7534", Offset = "0x19C7534", VA = "0x19C7534", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F558")]
	[Address(RVA = "0x19C77C8", Offset = "0x19C77C8", VA = "0x19C77C8")]
	private void OnTabToggleSelect(UIToggleButton button)
	{
	}

	[Token(Token = "0x600F559")]
	[Address(RVA = "0x19C7B10", Offset = "0x19C7B10", VA = "0x19C7B10", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600F55A")]
	[Address(RVA = "0x19C7EC8", Offset = "0x19C7EC8", VA = "0x19C7EC8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F55B")]
	[Address(RVA = "0x19C81B4", Offset = "0x19C81B4", VA = "0x19C81B4")]
	public void AddClickMaskRange(UIWidget widget)
	{
	}

	[Token(Token = "0x600F55C")]
	[Address(RVA = "0x19C82DC", Offset = "0x19C82DC", VA = "0x19C82DC")]
	private void OnNewMessageReceived(object[] data)
	{
	}

	[Token(Token = "0x600F55D")]
	[Address(RVA = "0x19C83B4", Offset = "0x19C83B4", VA = "0x19C83B4")]
	private void OnReservationBlockClick()
	{
	}

	[Token(Token = "0x600F55E")]
	[Address(RVA = "0x19C8604", Offset = "0x19C8604", VA = "0x19C8604")]
	private void OnQuickChatBlockClick()
	{
	}

	[Token(Token = "0x600F55F")]
	[Address(RVA = "0x19C8964", Offset = "0x19C8964", VA = "0x19C8964")]
	private void OnQuickChatSoundBlockClick()
	{
	}

	[Token(Token = "0x600F560")]
	[Address(RVA = "0x19C88CC", Offset = "0x19C88CC", VA = "0x19C88CC")]
	private void RefreshQuickChatSoundEnable(bool state)
	{
	}

	[Token(Token = "0x600F561")]
	[Address(RVA = "0x19C8C18", Offset = "0x19C8C18", VA = "0x19C8C18")]
	private void Update()
	{
	}

	[Token(Token = "0x600F562")]
	[Address(RVA = "0x19C95E0", Offset = "0x19C95E0", VA = "0x19C95E0")]
	public void OnStickerItemClick(object[] data)
	{
	}

	[Token(Token = "0x600F563")]
	[Address(RVA = "0x19C9B6C", Offset = "0x19C9B6C", VA = "0x19C9B6C")]
	private void OnSendClick()
	{
	}

	[Token(Token = "0x600F564")]
	[Address(RVA = "0x19C9124", Offset = "0x19C9124", VA = "0x19C9124")]
	private string Validate(string val)
	{
		return null;
	}

	[Token(Token = "0x600F565")]
	[Address(RVA = "0x19C93F8", Offset = "0x19C93F8", VA = "0x19C93F8")]
	private void StartMsgCDCheck()
	{
	}

	[Token(Token = "0x600F566")]
	[Address(RVA = "0x19C6064", Offset = "0x19C6064", VA = "0x19C6064")]
	private void InitTab()
	{
	}

	[Token(Token = "0x600F567")]
	[Address(RVA = "0x19C9E94", Offset = "0x19C9E94", VA = "0x19C9E94")]
	private void SetReserveContent()
	{
	}

	[Token(Token = "0x600F568")]
	[Address(RVA = "0x19C6328", Offset = "0x19C6328", VA = "0x19C6328")]
	private void InitReserveList()
	{
	}

	[Token(Token = "0x600F569")]
	[Address(RVA = "0x19C657C", Offset = "0x19C657C", VA = "0x19C657C")]
	private void SetReserveList()
	{
	}

	[Token(Token = "0x600F56A")]
	[Address(RVA = "0x19C72A8", Offset = "0x19C72A8", VA = "0x19C72A8")]
	private void RefreshQuickChatList(bool isDead = true)
	{
	}

	[Token(Token = "0x600F56B")]
	[Address(RVA = "0x19C6918", Offset = "0x19C6918", VA = "0x19C6918")]
	private void SetQuickChatList()
	{
	}

	[Token(Token = "0x600F56C")]
	[Address(RVA = "0x19C6CD8", Offset = "0x19C6CD8", VA = "0x19C6CD8")]
	private void InitStickerContent()
	{
	}

	[Token(Token = "0x600F56D")]
	[Address(RVA = "0x19CA11C", Offset = "0x19CA11C", VA = "0x19CA11C")]
	private bool OnEscapeClick()
	{
		return default(bool);
	}

	[Token(Token = "0x600F56E")]
	[Address(RVA = "0x19CA1B0", Offset = "0x19CA1B0", VA = "0x19CA1B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F56F")]
	[Address(RVA = "0x19CA254", Offset = "0x19CA254", VA = "0x19CA254", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600F570")]
	[Address(RVA = "0x19CA320", Offset = "0x19CA320", VA = "0x19CA320", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600F571")]
	[Address(RVA = "0x19CA3B4", Offset = "0x19CA3B4", VA = "0x19CA3B4")]
	private void _003CStartMsgCDCheck_003Em__0()
	{
	}

	[Token(Token = "0x600F572")]
	[Address(RVA = "0x19CA3C0", Offset = "0x19CA3C0", VA = "0x19CA3C0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F573")]
	[Address(RVA = "0x19CA3C8", Offset = "0x19CA3C8", VA = "0x19CA3C8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F574")]
	[Address(RVA = "0x19CA3D0", Offset = "0x19CA3D0", VA = "0x19CA3D0")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x600F575")]
	[Address(RVA = "0x19CA3D8", Offset = "0x19CA3D8", VA = "0x19CA3D8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
