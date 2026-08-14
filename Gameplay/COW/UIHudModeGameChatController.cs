using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027C3")]
public class UIHudModeGameChatController : UIBaseController, _Attribute
{
	[Token(Token = "0x400F56E")]
	private const int ITEM_COUNT_MAX = 50;

	[Token(Token = "0x400F56F")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsInCD;

	[Token(Token = "0x400F570")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_CheckCDDelayCallID;

	[Token(Token = "0x400F571")]
	[FieldOffset(Offset = "0x30")]
	private int m_CharacterLimit;

	[Token(Token = "0x400F572")]
	[FieldOffset(Offset = "0x34")]
	private float m_CurerntCDTime;

	[Token(Token = "0x400F573")]
	[FieldOffset(Offset = "0x38")]
	private TouchScreenKeyboard m_CurKeyBoard;

	[Token(Token = "0x400F574")]
	[FieldOffset(Offset = "0x3C")]
	private string m_CachedText;

	[Token(Token = "0x400F575")]
	[FieldOffset(Offset = "0x40")]
	private UIModelInGameChat m_Model;

	[Token(Token = "0x400F576")]
	[FieldOffset(Offset = "0x44")]
	private UIHudModeGameChatView m_View;

	[Token(Token = "0x400F577")]
	[FieldOffset(Offset = "0x48")]
	private List<ClientInGameChatMessage> m_MessageList;

	[Token(Token = "0x400F578")]
	[FieldOffset(Offset = "0x4C")]
	private List<UILabel> m_LabelList;

	[Token(Token = "0x400F579")]
	[FieldOffset(Offset = "0x50")]
	private Queue<UILabel> m_LabelPool;

	[Token(Token = "0x400F57A")]
	[FieldOffset(Offset = "0x54")]
	private float lastItemPosY;

	[Token(Token = "0x400F57B")]
	[FieldOffset(Offset = "0x58")]
	private float firstItemPosY;

	[Token(Token = "0x400F57C")]
	[FieldOffset(Offset = "0x5C")]
	private int lastItemIndex;

	[Token(Token = "0x400F57D")]
	[FieldOffset(Offset = "0x60")]
	private int firstItemIndex;

	[Token(Token = "0x400F57E")]
	[FieldOffset(Offset = "0x64")]
	private bool m_ShowState;

	[Token(Token = "0x400F57F")]
	[FieldOffset(Offset = "0x68")]
	private List<UILabel> m_ChatItemTemplates;

	[Token(Token = "0x400F580")]
	[FieldOffset(Offset = "0x6C")]
	private float m_TemplateXPos;

	[Token(Token = "0x400F581")]
	[FieldOffset(Offset = "0x70")]
	private uint testIndex;

	[Token(Token = "0x600F5D3")]
	[Address(RVA = "0x19CBC28", Offset = "0x19CBC28", VA = "0x19CBC28")]
	public UIHudModeGameChatController()
	{
	}

	[Token(Token = "0x600F5D4")]
	[Address(RVA = "0x19CBDC8", Offset = "0x19CBDC8", VA = "0x19CBDC8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F5D5")]
	[Address(RVA = "0x19CBE6C", Offset = "0x19CBE6C", VA = "0x19CBE6C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F5D6")]
	[Address(RVA = "0x19CC374", Offset = "0x19CC374", VA = "0x19CC374")]
	private void Update()
	{
	}

	[Token(Token = "0x600F5D7")]
	[Address(RVA = "0x19CCAC0", Offset = "0x19CCAC0", VA = "0x19CCAC0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F5D8")]
	[Address(RVA = "0x19CD0D0", Offset = "0x19CD0D0", VA = "0x19CD0D0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600F5D9")]
	[Address(RVA = "0x19CD1E4", Offset = "0x19CD1E4", VA = "0x19CD1E4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F5DA")]
	[Address(RVA = "0x19CCC48", Offset = "0x19CCC48", VA = "0x19CCC48")]
	protected void RebuildMessageList()
	{
	}

	[Token(Token = "0x600F5DB")]
	[Address(RVA = "0x19CDBFC", Offset = "0x19CDBFC", VA = "0x19CDBFC")]
	protected void UpdateNewMessageList(bool isInternal = false)
	{
	}

	[Token(Token = "0x600F5DC")]
	[Address(RVA = "0x19CE724", Offset = "0x19CE724", VA = "0x19CE724", Slot = "33")]
	protected virtual UILabel GetAnInstance()
	{
		return null;
	}

	[Token(Token = "0x600F5DD")]
	[Address(RVA = "0x19CE064", Offset = "0x19CE064", VA = "0x19CE064")]
	private void RefreshAllContent()
	{
	}

	[Token(Token = "0x600F5DE")]
	[Address(RVA = "0x19CD26C", Offset = "0x19CD26C", VA = "0x19CD26C")]
	private void WrapInitializeItem(int fromIndex, int toIndex)
	{
	}

	[Token(Token = "0x600F5DF")]
	[Address(RVA = "0x19CE9A0", Offset = "0x19CE9A0", VA = "0x19CE9A0")]
	private void OnChatBtnClick()
	{
	}

	[Token(Token = "0x600F5E0")]
	[Address(RVA = "0x19CEAB4", Offset = "0x19CEAB4", VA = "0x19CEAB4")]
	private void StartMsgCD()
	{
	}

	[Token(Token = "0x600F5E1")]
	[Address(RVA = "0x19CEE10", Offset = "0x19CEE10", VA = "0x19CEE10")]
	private void OnHideQuickViewBtnClick()
	{
	}

	[Token(Token = "0x600F5E2")]
	[Address(RVA = "0x19CF198", Offset = "0x19CF198", VA = "0x19CF198")]
	private void OnSendBtnClick()
	{
	}

	[Token(Token = "0x600F5E3")]
	[Address(RVA = "0x19CF5D4", Offset = "0x19CF5D4", VA = "0x19CF5D4")]
	private void OnBubbleClick()
	{
	}

	[Token(Token = "0x600F5E4")]
	[Address(RVA = "0x19CEE84", Offset = "0x19CEE84", VA = "0x19CEE84")]
	private void SetChatPanelVisible(bool show)
	{
	}

	[Token(Token = "0x600F5E5")]
	[Address(RVA = "0x19CDE94", Offset = "0x19CDE94", VA = "0x19CDE94")]
	private bool IsAtBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x600F5E6")]
	[Address(RVA = "0x19CF64C", Offset = "0x19CF64C", VA = "0x19CF64C")]
	private bool IsAtTop()
	{
		return default(bool);
	}

	[Token(Token = "0x600F5E7")]
	[Address(RVA = "0x19CDB4C", Offset = "0x19CDB4C", VA = "0x19CDB4C")]
	private void ScrollToBottom()
	{
	}

	[Token(Token = "0x600F5E8")]
	[Address(RVA = "0x19CF81C", Offset = "0x19CF81C", VA = "0x19CF81C")]
	private void OnStopMoving()
	{
	}

	[Token(Token = "0x600F5E9")]
	[Address(RVA = "0x19CCB34", Offset = "0x19CCB34", VA = "0x19CCB34")]
	protected void GetMessageList()
	{
	}

	[Token(Token = "0x600F5EA")]
	[Address(RVA = "0x19CF94C", Offset = "0x19CF94C", VA = "0x19CF94C")]
	private string Validate(string val)
	{
		return null;
	}

	[Token(Token = "0x600F5EB")]
	[Address(RVA = "0x19CC8F8", Offset = "0x19CC8F8", VA = "0x19CC8F8")]
	private void UpdateCD()
	{
	}

	[Token(Token = "0x600F5EC")]
	[Address(RVA = "0x19CC3DC", Offset = "0x19CC3DC", VA = "0x19CC3DC")]
	private void UpdateKeyBoard()
	{
	}

	[Token(Token = "0x600F5ED")]
	[Address(RVA = "0x19CFD54", Offset = "0x19CFD54", VA = "0x19CFD54", Slot = "34")]
	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600F5EE")]
	[Address(RVA = "0x19CFDE8", Offset = "0x19CFDE8", VA = "0x19CFDE8", Slot = "35")]
	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600F5EF")]
	[Address(RVA = "0x19CFEC0", Offset = "0x19CFEC0", VA = "0x19CFEC0")]
	private void _003CStartMsgCD_003Em__0()
	{
	}

	[Token(Token = "0x600F5F0")]
	[Address(RVA = "0x19CFF88", Offset = "0x19CFF88", VA = "0x19CFF88")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F5F1")]
	[Address(RVA = "0x19CFF90", Offset = "0x19CFF90", VA = "0x19CFF90")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F5F2")]
	[Address(RVA = "0x19CFF98", Offset = "0x19CFF98", VA = "0x19CFF98")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600F5F3")]
	[Address(RVA = "0x19CFFA0", Offset = "0x19CFFA0", VA = "0x19CFFA0")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
