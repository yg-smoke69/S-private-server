using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200277D")]
public class UIHudInGameChatController : UIBaseController, _Attribute
{
	[Token(Token = "0x400F3CD")]
	private const int ITEM_COUNT_MAX = 50;

	[Token(Token = "0x400F3CE")]
	private const float BULLETSCREENCD = 5f;

	[Token(Token = "0x400F3CF")]
	private const float AutoShowBubbleSecond = 2f;

	[Token(Token = "0x400F3D0")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsInCD;

	[Token(Token = "0x400F3D1")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_CheckCDDelayCallID;

	[Token(Token = "0x400F3D2")]
	[FieldOffset(Offset = "0x30")]
	private int m_CharacterLimit;

	[Token(Token = "0x400F3D3")]
	[FieldOffset(Offset = "0x34")]
	private float m_CurerntCDTime;

	[Token(Token = "0x400F3D4")]
	[FieldOffset(Offset = "0x38")]
	private TouchScreenKeyboard m_CurKeyBoard;

	[Token(Token = "0x400F3D5")]
	[FieldOffset(Offset = "0x3C")]
	private string m_CachedText;

	[Token(Token = "0x400F3D6")]
	[FieldOffset(Offset = "0x40")]
	private UIModelInGameChat m_Model;

	[Token(Token = "0x400F3D7")]
	[FieldOffset(Offset = "0x44")]
	private UIHudInGameChatView m_View;

	[Token(Token = "0x400F3D8")]
	[FieldOffset(Offset = "0x48")]
	private List<ClientInGameChatMessage> m_MessageList;

	[Token(Token = "0x400F3D9")]
	[FieldOffset(Offset = "0x4C")]
	private List<ClientInGameChatMessage> m_AllMessageList;

	[Token(Token = "0x400F3DA")]
	[FieldOffset(Offset = "0x50")]
	private List<UILabel> m_LabelList;

	[Token(Token = "0x400F3DB")]
	[FieldOffset(Offset = "0x54")]
	private Queue<UILabel> m_LabelPool;

	[Token(Token = "0x400F3DC")]
	[FieldOffset(Offset = "0x58")]
	private float lastItemPosY;

	[Token(Token = "0x400F3DD")]
	[FieldOffset(Offset = "0x5C")]
	private float firstItemPosY;

	[Token(Token = "0x400F3DE")]
	[FieldOffset(Offset = "0x60")]
	private int lastItemIndex;

	[Token(Token = "0x400F3DF")]
	[FieldOffset(Offset = "0x64")]
	private int firstItemIndex;

	[Token(Token = "0x400F3E0")]
	[FieldOffset(Offset = "0x68")]
	private int m_NewMessageCount;

	[Token(Token = "0x400F3E1")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_ShowState;

	[Token(Token = "0x400F3E2")]
	[FieldOffset(Offset = "0x70")]
	private List<UILabel> m_ChatItemTemplates;

	[Token(Token = "0x400F3E3")]
	[FieldOffset(Offset = "0x74")]
	private float m_TemplateXPos;

	[Token(Token = "0x400F3E4")]
	[FieldOffset(Offset = "0x78")]
	private uint m_BulletScreenDelayCall;

	[Token(Token = "0x400F3E5")]
	[FieldOffset(Offset = "0x7C")]
	private uint testIndex;

	[Token(Token = "0x600F221")]
	[Address(RVA = "0x1353FB0", Offset = "0x1353FB0", VA = "0x1353FB0")]
	public UIHudInGameChatController()
	{
	}

	[Token(Token = "0x600F222")]
	[Address(RVA = "0x1354168", Offset = "0x1354168", VA = "0x1354168")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F223")]
	[Address(RVA = "0x135420C", Offset = "0x135420C", VA = "0x135420C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F224")]
	[Address(RVA = "0x1354850", Offset = "0x1354850", VA = "0x1354850")]
	private void Update()
	{
	}

	[Token(Token = "0x600F225")]
	[Address(RVA = "0x1354FD4", Offset = "0x1354FD4", VA = "0x1354FD4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F226")]
	[Address(RVA = "0x1355768", Offset = "0x1355768", VA = "0x1355768", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600F227")]
	[Address(RVA = "0x13558F0", Offset = "0x13558F0", VA = "0x13558F0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F228")]
	[Address(RVA = "0x13552E0", Offset = "0x13552E0", VA = "0x13552E0")]
	protected void RebuildMessageList()
	{
	}

	[Token(Token = "0x600F229")]
	[Address(RVA = "0x1356368", Offset = "0x1356368", VA = "0x1356368")]
	protected void UpdateNewMessageList(bool isInternal = false)
	{
	}

	[Token(Token = "0x600F22A")]
	[Address(RVA = "0x13572AC", Offset = "0x13572AC", VA = "0x13572AC", Slot = "33")]
	protected virtual UILabel GetAnInstance()
	{
		return null;
	}

	[Token(Token = "0x600F22B")]
	[Address(RVA = "0x1356BEC", Offset = "0x1356BEC", VA = "0x1356BEC")]
	private void RefreshAllContent()
	{
	}

	[Token(Token = "0x600F22C")]
	[Address(RVA = "0x1355978", Offset = "0x1355978", VA = "0x1355978")]
	private void WrapInitializeItem(int fromIndex, int toIndex)
	{
	}

	[Token(Token = "0x600F22D")]
	[Address(RVA = "0x1357528", Offset = "0x1357528", VA = "0x1357528")]
	private void OnChatBtnClick()
	{
	}

	[Token(Token = "0x600F22E")]
	[Address(RVA = "0x135763C", Offset = "0x135763C", VA = "0x135763C")]
	private void StartMsgCD()
	{
	}

	[Token(Token = "0x600F22F")]
	[Address(RVA = "0x1357998", Offset = "0x1357998", VA = "0x1357998")]
	private void OnHideQuickViewBtnClick()
	{
	}

	[Token(Token = "0x600F230")]
	[Address(RVA = "0x1357D58", Offset = "0x1357D58", VA = "0x1357D58")]
	private void OnSendBtnClick()
	{
	}

	[Token(Token = "0x600F231")]
	[Address(RVA = "0x13581CC", Offset = "0x13581CC", VA = "0x13581CC")]
	private void OnBubbleClick()
	{
	}

	[Token(Token = "0x600F232")]
	[Address(RVA = "0x1357A0C", Offset = "0x1357A0C", VA = "0x1357A0C")]
	private void SetChatPanelVisible(bool show)
	{
	}

	[Token(Token = "0x600F233")]
	[Address(RVA = "0x1356A1C", Offset = "0x1356A1C", VA = "0x1356A1C")]
	private bool IsAtBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x600F234")]
	[Address(RVA = "0x1358244", Offset = "0x1358244", VA = "0x1358244")]
	private bool IsAtTop()
	{
		return default(bool);
	}

	[Token(Token = "0x600F235")]
	[Address(RVA = "0x1356258", Offset = "0x1356258", VA = "0x1356258")]
	private void ScrollToBottom()
	{
	}

	[Token(Token = "0x600F236")]
	[Address(RVA = "0x1358414", Offset = "0x1358414", VA = "0x1358414")]
	private void OnStopMoving()
	{
	}

	[Token(Token = "0x600F237")]
	[Address(RVA = "0x1355048", Offset = "0x1355048", VA = "0x1355048")]
	protected void GetMessageList()
	{
	}

	[Token(Token = "0x600F238")]
	[Address(RVA = "0x13585A8", Offset = "0x13585A8", VA = "0x13585A8")]
	private string Validate(string val)
	{
		return null;
	}

	[Token(Token = "0x600F239")]
	[Address(RVA = "0x1354E0C", Offset = "0x1354E0C", VA = "0x1354E0C")]
	private void UpdateCD()
	{
	}

	[Token(Token = "0x600F23A")]
	[Address(RVA = "0x13548B8", Offset = "0x13548B8", VA = "0x13548B8")]
	private void UpdateKeyBoard()
	{
	}

	[Token(Token = "0x600F23B")]
	[Address(RVA = "0x13589B0", Offset = "0x13589B0", VA = "0x13589B0", Slot = "34")]
	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600F23C")]
	[Address(RVA = "0x1358A44", Offset = "0x1358A44", VA = "0x1358A44", Slot = "35")]
	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600F23D")]
	[Address(RVA = "0x1358B44", Offset = "0x1358B44", VA = "0x1358B44")]
	private void _003CUpdateNewMessageList_003Em__0()
	{
	}

	[Token(Token = "0x600F23E")]
	[Address(RVA = "0x1358BE4", Offset = "0x1358BE4", VA = "0x1358BE4")]
	private void _003CStartMsgCD_003Em__1()
	{
	}

	[Token(Token = "0x600F23F")]
	[Address(RVA = "0x1358CAC", Offset = "0x1358CAC", VA = "0x1358CAC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F240")]
	[Address(RVA = "0x1358CB4", Offset = "0x1358CB4", VA = "0x1358CB4")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F241")]
	[Address(RVA = "0x1358CBC", Offset = "0x1358CBC", VA = "0x1358CBC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600F242")]
	[Address(RVA = "0x1358CC4", Offset = "0x1358CC4", VA = "0x1358CC4")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
