using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024F3")]
public class UIBaseChatController<T> : UIBaseController, _Attribute, IConvertible where T : UIBaseChatItemController
{
	[Token(Token = "0x400E50E")]
	[FieldOffset(Offset = "0x0")]
	private ChatChannelInfo _003CcurShowChannel_003Ek__BackingField;

	[Token(Token = "0x400E50F")]
	[FieldOffset(Offset = "0x0")]
	protected UIModelChat m_Model;

	[Token(Token = "0x400E510")]
	[FieldOffset(Offset = "0x0")]
	protected List<T> m_ControllerList;

	[Token(Token = "0x400E511")]
	[FieldOffset(Offset = "0x0")]
	protected Queue<T> m_ControllerPool;

	[Token(Token = "0x400E512")]
	[FieldOffset(Offset = "0x0")]
	protected List<MessageInfo> m_MessageList;

	[Token(Token = "0x400E513")]
	[FieldOffset(Offset = "0x0")]
	protected List<StickerSpriteView> m_StickerSpriteViewList;

	[Token(Token = "0x400E514")]
	[FieldOffset(Offset = "0x0")]
	protected List<StickerTabView> m_StickerTabViewList;

	[Token(Token = "0x400E515")]
	[FieldOffset(Offset = "0x0")]
	protected UICountDownController m_MutedCDCtrl;

	[Token(Token = "0x400E516")]
	[FieldOffset(Offset = "0x0")]
	protected float lastItemPosY;

	[Token(Token = "0x400E517")]
	[FieldOffset(Offset = "0x0")]
	protected float firstItemPosY;

	[Token(Token = "0x400E518")]
	[FieldOffset(Offset = "0x0")]
	protected int lastItemIndex;

	[Token(Token = "0x400E519")]
	[FieldOffset(Offset = "0x0")]
	protected int firstItemIndex;

	[Token(Token = "0x400E51A")]
	protected const int ITEM_COUNT_PERPAGE = 10;

	[Token(Token = "0x400E51B")]
	[FieldOffset(Offset = "0x0")]
	protected bool m_HasInitSticker;

	[Token(Token = "0x400E51C")]
	[FieldOffset(Offset = "0x0")]
	protected uint currentSelectSticker;

	[Token(Token = "0x400E51D")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject NewMessage;

	[Token(Token = "0x400E51E")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject ContentNode;

	[Token(Token = "0x400E51F")]
	[FieldOffset(Offset = "0x0")]
	protected UIInput InputContainer;

	[Token(Token = "0x400E520")]
	[FieldOffset(Offset = "0x0")]
	protected UIScrollView MessageList;

	[Token(Token = "0x400E521")]
	[FieldOffset(Offset = "0x0")]
	protected UITable MessageListTable;

	[Token(Token = "0x400E522")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject EmptyNode;

	[Token(Token = "0x400E523")]
	[FieldOffset(Offset = "0x0")]
	protected UIButton EnterBtn;

	[Token(Token = "0x400E524")]
	[FieldOffset(Offset = "0x0")]
	protected UIButton OpenStickerBtn;

	[Token(Token = "0x400E525")]
	[FieldOffset(Offset = "0x0")]
	protected UIButton NewMessageBtn;

	[Token(Token = "0x400E526")]
	[FieldOffset(Offset = "0x0")]
	protected UILabel NewMessageLabel;

	[Token(Token = "0x400E527")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject IngameHint;

	[Token(Token = "0x400E528")]
	[FieldOffset(Offset = "0x0")]
	protected UILabel WhisperStatusHint;

	[Token(Token = "0x400E529")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject StickerNode;

	[Token(Token = "0x400E52A")]
	[FieldOffset(Offset = "0x0")]
	protected UIButton CloseStickerBtn;

	[Token(Token = "0x400E52B")]
	[FieldOffset(Offset = "0x0")]
	protected UIToggleButtonGroup StickerToggleBtnGroup;

	[Token(Token = "0x400E52C")]
	[FieldOffset(Offset = "0x0")]
	protected UIGrid StickerTabGrid;

	[Token(Token = "0x400E52D")]
	[FieldOffset(Offset = "0x0")]
	protected StickerTabView StickerTabItemInstance;

	[Token(Token = "0x400E52E")]
	[FieldOffset(Offset = "0x0")]
	protected UIScrollView StickerSpriteList;

	[Token(Token = "0x400E52F")]
	[FieldOffset(Offset = "0x0")]
	protected UITable StickerSpriteTable;

	[Token(Token = "0x400E530")]
	[FieldOffset(Offset = "0x0")]
	protected StickerSpriteView StickerSpriteInstance;

	[Token(Token = "0x400E531")]
	[FieldOffset(Offset = "0x0")]
	protected UIButton PurchaseBtn;

	[Token(Token = "0x400E532")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject PurchaseGO;

	[Token(Token = "0x400E533")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject DiamondGO;

	[Token(Token = "0x400E534")]
	[FieldOffset(Offset = "0x0")]
	protected UILabel StickerPriceDiamond;

	[Token(Token = "0x400E535")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject CoinGO;

	[Token(Token = "0x400E536")]
	[FieldOffset(Offset = "0x0")]
	protected UILabel StickerPriceCoin;

	[Token(Token = "0x400E537")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject GoposGO;

	[Token(Token = "0x400E538")]
	[FieldOffset(Offset = "0x0")]
	protected UILabel StickerPriceGopos;

	[Token(Token = "0x400E539")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject OwnedObject;

	[Token(Token = "0x400E53A")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject MutedNode;

	[Token(Token = "0x400E53B")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject SendMessageNode;

	[Token(Token = "0x400E53C")]
	[FieldOffset(Offset = "0x0")]
	protected Transform MutedCountDown;

	[Token(Token = "0x400E53D")]
	[FieldOffset(Offset = "0x0")]
	protected UIButton MutedHintBtn;

	[Token(Token = "0x400E53E")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject Interaction;

	[Token(Token = "0x400E53F")]
	[FieldOffset(Offset = "0x0")]
	protected UILabel InteractionLabel;

	[Token(Token = "0x400E540")]
	[FieldOffset(Offset = "0x0")]
	protected UIButton InteractionBtn;

	[Token(Token = "0x400E541")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<ChatStickerPrice> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001142")]
	public ChatChannelInfo curShowChannel
	{
		[Token(Token = "0x600D524")]
		get
		{
			return null;
		}
		[Token(Token = "0x600D525")]
		protected set
		{
		}
	}

	[Token(Token = "0x600D523")]
	public UIBaseChatController()
	{
	}

	[Token(Token = "0x600D526")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D527")]
	protected virtual ChatChannelInfo GetCurShowChannel()
	{
		return null;
	}

	[Token(Token = "0x600D528")]
	protected virtual void AfterInit()
	{
	}

	[Token(Token = "0x600D529")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600D52A")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D52B")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600D52C")]
	private void OnStickerPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600D52D")]
	private void PurchaseSticker()
	{
	}

	[Token(Token = "0x600D52E")]
	private void OnCloseStickerBtnClick()
	{
	}

	[Token(Token = "0x600D52F")]
	private void OnOpenStickerBtnClick()
	{
	}

	[Token(Token = "0x600D530")]
	protected virtual void OnStickerSpriteClick(object[] data)
	{
	}

	[Token(Token = "0x600D531")]
	protected virtual void OnStickerTabClick(object[] data)
	{
	}

	[Token(Token = "0x600D532")]
	protected virtual void OnEnterBtnClick()
	{
	}

	[Token(Token = "0x600D533")]
	private void OnMutedHintBtnClick()
	{
	}

	[Token(Token = "0x600D534")]
	protected virtual void AfterSendSuccess()
	{
	}

	[Token(Token = "0x600D535")]
	protected virtual char OnInputValidate(string text, int charIndex, char addedChar)
	{
		return default(char);
	}

	[Token(Token = "0x600D536")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D537")]
	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D538")]
	protected virtual void OnChatDataChanged(uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D539")]
	protected virtual void RefreshContentNode()
	{
	}

	[Token(Token = "0x600D53A")]
	private void SetIngameHintState()
	{
	}

	[Token(Token = "0x600D53B")]
	private void RefreshVeteranInteraction(string nickname)
	{
	}

	[Token(Token = "0x600D53C")]
	protected void RebuildMessageList()
	{
	}

	[Token(Token = "0x600D53D")]
	protected void UpdateNewMessageList()
	{
	}

	[Token(Token = "0x600D53E")]
	protected void SetInteractionBtnVsible(bool v, string nickname = "")
	{
	}

	[Token(Token = "0x600D53F")]
	protected void RefreshMessageList()
	{
	}

	[Token(Token = "0x600D540")]
	private void CheckAndHideNewMessageTip()
	{
	}

	[Token(Token = "0x600D541")]
	protected void OnStopMoving()
	{
	}

	[Token(Token = "0x600D542")]
	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D543")]
	protected virtual uint GetChatInterestedPropID()
	{
		return default(uint);
	}

	[Token(Token = "0x600D544")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D545")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D546")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600D547")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600D548")]
	private bool IsAtBottom()
	{
		return default(bool);
	}

	[Token(Token = "0x600D549")]
	private bool IsAtTop()
	{
		return default(bool);
	}

	[Token(Token = "0x600D54A")]
	private void ScrollToBottom()
	{
	}

	[Token(Token = "0x600D54B")]
	private void OnInteractionBtnClick()
	{
	}

	[Token(Token = "0x600D54C")]
	private void RefreshAllContent()
	{
	}

	[Token(Token = "0x600D54D")]
	private void WrapInitializeItem(int fromIndex, int toIndex)
	{
	}

	[Token(Token = "0x600D54E")]
	protected virtual T GetAnInstance()
	{
		return null;
	}

	[Token(Token = "0x600D54F")]
	protected void GetMessageList()
	{
	}

	[Token(Token = "0x600D550")]
	protected void SetNewMessageBtnVisible(bool v)
	{
	}

	[Token(Token = "0x600D551")]
	private static int _003COnOpenStickerBtnClick_003Em__0(ChatStickerPrice a, ChatStickerPrice b)
	{
		return default(int);
	}
}
