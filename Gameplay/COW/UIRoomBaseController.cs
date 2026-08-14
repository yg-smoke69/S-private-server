using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002AD8")]
public abstract class UIRoomBaseController : UINavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x2002AD9")]
	protected enum EGameSettingItemStyle
	{
		[Token(Token = "0x401073E")]
		Short,
		[Token(Token = "0x401073F")]
		Long
	}

	[Token(Token = "0x2002ADA")]
	protected class RoomGameSettingData
	{
		[Token(Token = "0x4010740")]
		[FieldOffset(Offset = "0x8")]
		public string Title;

		[Token(Token = "0x4010741")]
		[FieldOffset(Offset = "0xC")]
		public string Text;

		[Token(Token = "0x4010742")]
		[FieldOffset(Offset = "0x10")]
		public bool PredictToolEnable;

		[Token(Token = "0x4010743")]
		[FieldOffset(Offset = "0x11")]
		public bool PredictToolDisable;

		[Token(Token = "0x4010744")]
		[FieldOffset(Offset = "0x12")]
		public bool TrapEnable;

		[Token(Token = "0x4010745")]
		[FieldOffset(Offset = "0x13")]
		public bool TrapDisable;

		[Token(Token = "0x6011939")]
		[Address(RVA = "0x23B8030", Offset = "0x23B8030", VA = "0x23B8030")]
		public RoomGameSettingData()
		{
		}
	}

	[Token(Token = "0x2002ADB")]
	private sealed class _003CCheckReconnectPop_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010746")]
		[FieldOffset(Offset = "0x8")]
		internal FrontEndGame _003Cgame_003E__0;

		[Token(Token = "0x4010747")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010748")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010749")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170012D8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601193C")]
			[Address(RVA = "0x23B7D74", Offset = "0x23B7D74", VA = "0x23B7D74", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012D9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601193D")]
			[Address(RVA = "0x23B7D7C", Offset = "0x23B7D7C", VA = "0x23B7D7C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601193A")]
		[Address(RVA = "0x23B7C24", Offset = "0x23B7C24", VA = "0x23B7C24")]
		public _003CCheckReconnectPop_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601193B")]
		[Address(RVA = "0x23B7C2C", Offset = "0x23B7C2C", VA = "0x23B7C2C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601193E")]
		[Address(RVA = "0x23B7D84", Offset = "0x23B7D84", VA = "0x23B7D84", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601193F")]
		[Address(RVA = "0x23B7D98", Offset = "0x23B7D98", VA = "0x23B7D98", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002ADC")]
	private sealed class _003CIsSwitchSeat_003Ec__AnonStorey2
	{
		[Token(Token = "0x401074A")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountId;

		[Token(Token = "0x6011940")]
		[Address(RVA = "0x23B7E20", Offset = "0x23B7E20", VA = "0x23B7E20")]
		public _003CIsSwitchSeat_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6011941")]
		[Address(RVA = "0x23B7E28", Offset = "0x23B7E28", VA = "0x23B7E28")]
		internal bool _003C_003Em__0(RoomGroupInfo data)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002ADD")]
	private sealed class _003CRefreshOptionalMapResDownloader_003Ec__AnonStorey3
	{
		[Token(Token = "0x401074B")]
		[FieldOffset(Offset = "0x8")]
		internal ResDownloadType resType;

		[Token(Token = "0x401074C")]
		[FieldOffset(Offset = "0xC")]
		internal UIRoomBaseController _0024this;

		[Token(Token = "0x6011942")]
		[Address(RVA = "0x23B7FF4", Offset = "0x23B7FF4", VA = "0x23B7FF4")]
		public _003CRefreshOptionalMapResDownloader_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6011943")]
		[Address(RVA = "0x23B7FFC", Offset = "0x23B7FFC", VA = "0x23B7FFC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002ADE")]
	private sealed class _003CRefreshChatScrollView_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401074D")]
		[FieldOffset(Offset = "0x8")]
		internal float value;

		[Token(Token = "0x401074E")]
		[FieldOffset(Offset = "0xC")]
		internal UIRoomBaseController _0024this;

		[Token(Token = "0x401074F")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4010750")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x4010751")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170012DA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6011946")]
			[Address(RVA = "0x23B7F48", Offset = "0x23B7F48", VA = "0x23B7F48", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012DB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6011947")]
			[Address(RVA = "0x23B7F50", Offset = "0x23B7F50", VA = "0x23B7F50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6011944")]
		[Address(RVA = "0x23B7E74", Offset = "0x23B7E74", VA = "0x23B7E74")]
		public _003CRefreshChatScrollView_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6011945")]
		[Address(RVA = "0x23B7E7C", Offset = "0x23B7E7C", VA = "0x23B7E7C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6011948")]
		[Address(RVA = "0x23B7F58", Offset = "0x23B7F58", VA = "0x23B7F58", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6011949")]
		[Address(RVA = "0x23B7F6C", Offset = "0x23B7F6C", VA = "0x23B7F6C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401071E")]
	[FieldOffset(Offset = "0x68")]
	protected int ITEM_WIDTH;

	[Token(Token = "0x401071F")]
	private const int SOLO_ITEM_HEIGHT = 58;

	[Token(Token = "0x4010720")]
	private const int DUO_ITEM_HEIGHT = 110;

	[Token(Token = "0x4010721")]
	private const int QUAD_ITEM_HEIGHT = 214;

	[Token(Token = "0x4010722")]
	private const int PENTA_ITEM_HEIGHT = 266;

	[Token(Token = "0x4010723")]
	private const int HEXA_ITEM_HEIGHT = 315;

	[Token(Token = "0x4010724")]
	private const int DUO_ITEM_HEIGHT_WITH_TEAMINFO = 140;

	[Token(Token = "0x4010725")]
	private const int QUAD_ITEM_HEIGHT_WITH_TEAMINFO = 246;

	[Token(Token = "0x4010726")]
	private const int PENTA_ITEM_HEIGHT_WITH_TEAMINFO = 298;

	[Token(Token = "0x4010727")]
	private const int HEXA_ITEM_HEIGHT_WITH_TEAMINFO = 345;

	[Token(Token = "0x4010728")]
	protected const int COOLDOWN_SECONDS = 35;

	[Token(Token = "0x4010729")]
	[FieldOffset(Offset = "0x6C")]
	protected int m_ItemHeight;

	[Token(Token = "0x401072A")]
	[FieldOffset(Offset = "0x70")]
	protected UICustomRoomView m_View;

	[Token(Token = "0x401072B")]
	[FieldOffset(Offset = "0x74")]
	protected UIModelCustomRoom m_Model;

	[Token(Token = "0x401072C")]
	[FieldOffset(Offset = "0x78")]
	protected RoomCreateRuleDataManager m_DataManager;

	[Token(Token = "0x401072D")]
	[FieldOffset(Offset = "0x7C")]
	private CountDownConfig m_Config;

	[Token(Token = "0x401072E")]
	[FieldOffset(Offset = "0x80")]
	private bool m_FirstEnteringIdleStateChecked;

	[Token(Token = "0x401072F")]
	[FieldOffset(Offset = "0x84")]
	private UIModelChat m_ChatModel;

	[Token(Token = "0x4010730")]
	[FieldOffset(Offset = "0x88")]
	private Queue<UIRoomChatMessageItemController> m_RoomChatMessageItemList;

	[Token(Token = "0x4010731")]
	[FieldOffset(Offset = "0x8C")]
	protected UIRoomCardListController m_RoomCardCtrl;

	[Token(Token = "0x4010732")]
	[FieldOffset(Offset = "0x90")]
	protected UIInviteGroupBoxController m_GroupInvitationController;

	[Token(Token = "0x4010733")]
	[FieldOffset(Offset = "0x94")]
	protected UICustomRoomCountDownWindowController m_CountDownController;

	[Token(Token = "0x4010734")]
	[FieldOffset(Offset = "0x98")]
	protected List<UIRoomObserverItemController> m_SpectatorCtrls;

	[Token(Token = "0x4010735")]
	[FieldOffset(Offset = "0x9C")]
	protected EGameSettingItemStyle m_GameSettingItemStyle;

	[Token(Token = "0x4010736")]
	[FieldOffset(Offset = "0xA0")]
	private List<UIRoomGameSettingItemController> m_CustomRoomDropListItemList;

	[Token(Token = "0x4010737")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_UseNewChatStyle;

	[Token(Token = "0x4010738")]
	[FieldOffset(Offset = "0xA8")]
	private int lastSeatIndex;

	[Token(Token = "0x4010739")]
	[FieldOffset(Offset = "0xAC")]
	private UINewDownloadInfoController m_OptionalMapResDownloader;

	[Token(Token = "0x401073A")]
	[FieldOffset(Offset = "0xB0")]
	private bool FirstFitScrollView;

	[Token(Token = "0x401073B")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<RoomPlayerInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x401073C")]
	[FieldOffset(Offset = "0x4")]
	private static Action<string> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60118EF")]
	[Address(RVA = "0x1E5AFC0", Offset = "0x1E5AFC0", VA = "0x1E5AFC0")]
	protected UIRoomBaseController()
	{
	}

	[Token(Token = "0x60118F0")]
	[Address(RVA = "0x1E5B0B4", Offset = "0x1E5B0B4", VA = "0x1E5B0B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60118F1")]
	[Address(RVA = "0x1E5B158", Offset = "0x1E5B158", VA = "0x1E5B158", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60118F2")]
	[Address(RVA = "0x1E5E8CC", Offset = "0x1E5E8CC", VA = "0x1E5E8CC", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60118F3")]
	[Address(RVA = "0x1E5E9DC", Offset = "0x1E5E9DC", VA = "0x1E5E9DC", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60118F4")]
	[Address(RVA = "0x1E5E814", Offset = "0x1E5E814", VA = "0x1E5E814")]
	private IEnumerator CheckReconnectPop()
	{
		return null;
	}

	[Token(Token = "0x60118F5")]
	[Address(RVA = "0x1E5F148", Offset = "0x1E5F148", VA = "0x1E5F148", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60118F6")]
	[Address(RVA = "0x1E5F288", Offset = "0x1E5F288", VA = "0x1E5F288", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60118F7")]
	[Address(RVA = "0x1E5D28C", Offset = "0x1E5D28C", VA = "0x1E5D28C")]
	private void ResetScrollViewWidth()
	{
	}

	[Token(Token = "0x60118F8")]
	[Address(RVA = "0x1E5F584", Offset = "0x1E5F584", VA = "0x1E5F584")]
	private bool IsSwitchSeat(tcp.RoomInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x60118F9")]
	[Address(RVA = "0x1E5F7B0", Offset = "0x1E5F7B0", VA = "0x1E5F7B0", Slot = "46")]
	protected virtual void RefreshUIData(bool mapModeChanged)
	{
	}

	[Token(Token = "0x60118FA")]
	[Address(RVA = "0x1E62F84", Offset = "0x1E62F84", VA = "0x1E62F84", Slot = "47")]
	protected virtual List<RoomGameSettingData> PrepareGameSettingData()
	{
		return null;
	}

	[Token(Token = "0x60118FB")]
	[Address(RVA = "0x1E625C0", Offset = "0x1E625C0", VA = "0x1E625C0")]
	private void UpdateGameSetting(List<RoomGameSettingData> gameSettingDataList)
	{
	}

	[Token(Token = "0x60118FC")]
	[Address(RVA = "0x1E62ED0", Offset = "0x1E62ED0", VA = "0x1E62ED0")]
	private void RefreshLoadout()
	{
	}

	[Token(Token = "0x60118FD")]
	[Address(RVA = "0x1E62054", Offset = "0x1E62054", VA = "0x1E62054")]
	private void RefreshReadyBtn()
	{
	}

	[Token(Token = "0x60118FE")]
	[Address(RVA = "0x1E62FDC", Offset = "0x1E62FDC", VA = "0x1E62FDC")]
	private void OptionalDownloadStateChange()
	{
	}

	[Token(Token = "0x60118FF")]
	[Address(RVA = "0x1E63190", Offset = "0x1E63190", VA = "0x1E63190")]
	private void OnResDownloaderClick(ResDownloadType resType)
	{
	}

	[Token(Token = "0x6011900")]
	[Address(RVA = "0x1E5EAC4", Offset = "0x1E5EAC4", VA = "0x1E5EAC4")]
	private void RefreshOptionalMapResDownloader()
	{
	}

	[Token(Token = "0x6011901")]
	[Address(RVA = "0x1E6231C", Offset = "0x1E6231C", VA = "0x1E6231C")]
	private void RefreshWaiting()
	{
	}

	[Token(Token = "0x6011902")]
	[Address(RVA = "0x1E5DD4C", Offset = "0x1E5DD4C", VA = "0x1E5DD4C")]
	private void RefreshChatStyle()
	{
	}

	[Token(Token = "0x6011903")]
	[Address(RVA = "0x1E61DE8", Offset = "0x1E61DE8", VA = "0x1E61DE8")]
	private void StartBtnCountDown()
	{
	}

	[Token(Token = "0x6011904")]
	[Address(RVA = "0x1E635F4", Offset = "0x1E635F4", VA = "0x1E635F4")]
	private void OnCountDownStarted()
	{
	}

	[Token(Token = "0x6011905")]
	[Address(RVA = "0x1E61BE4", Offset = "0x1E61BE4", VA = "0x1E61BE4")]
	private void OnCountDownFinished()
	{
	}

	[Token(Token = "0x6011906")]
	[Address(RVA = "0x1E62B8C", Offset = "0x1E62B8C", VA = "0x1E62B8C")]
	protected void RefreshSystemHint()
	{
	}

	[Token(Token = "0x6011907")]
	[Address(RVA = "0x1E5E704", Offset = "0x1E5E704", VA = "0x1E5E704")]
	private void SetNoMessageActive(bool show)
	{
	}

	[Token(Token = "0x6011908")]
	[Address(RVA = "0x1E6368C", Offset = "0x1E6368C", VA = "0x1E6368C")]
	private void UpdateChatBGHeight()
	{
	}

	[Token(Token = "0x6011909")]
	[Address(RVA = "0x1E639D8", Offset = "0x1E639D8", VA = "0x1E639D8")]
	private void RefreshLatestMessage()
	{
	}

	[Token(Token = "0x601190A")]
	[Address(RVA = "0x1E63FA4", Offset = "0x1E63FA4", VA = "0x1E63FA4")]
	private IEnumerator RefreshChatScrollView(float value)
	{
		return null;
	}

	[Token(Token = "0x601190B")]
	[Address(RVA = "0x1E640A0", Offset = "0x1E640A0", VA = "0x1E640A0", Slot = "48")]
	protected virtual void InitItemWidthAndHeight()
	{
	}

	[Token(Token = "0x601190C")]
	[Address(RVA = "0x1E642CC", Offset = "0x1E642CC", VA = "0x1E642CC")]
	protected void SetGameSettingItemStyle(EGameSettingItemStyle style)
	{
	}

	[Token(Token = "0x601190D")]
	[Address(RVA = "0x1E643D8", Offset = "0x1E643D8", VA = "0x1E643D8", Slot = "49")]
	protected virtual void RefreshRoomCard()
	{
	}

	[Token(Token = "0x601190E")]
	[Address(RVA = "0x1E5D96C", Offset = "0x1E5D96C", VA = "0x1E5D96C")]
	private bool IsShowStartBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x601190F")]
	[Address(RVA = "0x1E5D9E4", Offset = "0x1E5D9E4", VA = "0x1E5D9E4")]
	private bool IsShowReadBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x6011910")]
	[Address(RVA = "0x1E5DA5C", Offset = "0x1E5DA5C", VA = "0x1E5DA5C")]
	private bool IsShowCustomizeBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x6011911")]
	[Address(RVA = "0x1E5DAD4", Offset = "0x1E5DAD4", VA = "0x1E5DAD4")]
	private bool IsShowLookOverBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x6011912")]
	protected abstract bool IsShowInviteBtn();

	[Token(Token = "0x6011913")]
	protected abstract bool IsShowOB();

	[Token(Token = "0x6011914")]
	protected abstract bool IsShowToggleDisplayTypeBtn();

	[Token(Token = "0x6011915")]
	protected abstract bool IsShowInfoPanelOpenBtn();

	[Token(Token = "0x6011916")]
	protected abstract bool IsShowLoadOut();

	[Token(Token = "0x6011917")]
	protected abstract proto.EInventory.ItemSubType RoomCardType();

	[Token(Token = "0x6011918")]
	[Address(RVA = "0x1E64634", Offset = "0x1E64634", VA = "0x1E64634")]
	private void OnBtnGameStart()
	{
	}

	[Token(Token = "0x6011919")]
	protected abstract string GetCurrentGameStartInfo();

	[Token(Token = "0x601191A")]
	protected abstract void OnBtnGameStartCallBack();

	[Token(Token = "0x601191B")]
	[Address(RVA = "0x1E653A8", Offset = "0x1E653A8", VA = "0x1E653A8")]
	private void OnBtnGameReady()
	{
	}

	[Token(Token = "0x601191C")]
	[Address(RVA = "0x1E65448", Offset = "0x1E65448", VA = "0x1E65448")]
	private void OnBtnInvite()
	{
	}

	[Token(Token = "0x601191D")]
	protected abstract void OnBtnCustomize();

	[Token(Token = "0x601191E")]
	[Address(RVA = "0x1E65698", Offset = "0x1E65698", VA = "0x1E65698")]
	private void OnOBShowBtnClick()
	{
	}

	[Token(Token = "0x601191F")]
	[Address(RVA = "0x1E65780", Offset = "0x1E65780", VA = "0x1E65780")]
	private void OnOBHideBtnClick()
	{
	}

	[Token(Token = "0x6011920")]
	[Address(RVA = "0x1E65868", Offset = "0x1E65868", VA = "0x1E65868")]
	private void OnDisplayTypeBtnChange()
	{
	}

	[Token(Token = "0x6011921")]
	[Address(RVA = "0x1E5DB50", Offset = "0x1E5DB50", VA = "0x1E5DB50")]
	private void RefreshDisplayTypeLabel()
	{
	}

	[Token(Token = "0x6011922")]
	[Address(RVA = "0x1E659FC", Offset = "0x1E659FC", VA = "0x1E659FC", Slot = "59")]
	protected virtual void OnInfoPanelOpenClick()
	{
	}

	[Token(Token = "0x6011923")]
	[Address(RVA = "0x1E6636C", Offset = "0x1E6636C", VA = "0x1E6636C", Slot = "60")]
	protected virtual void OnInfoPanelCloseClick()
	{
	}

	[Token(Token = "0x6011924")]
	[Address(RVA = "0x1E66D6C", Offset = "0x1E66D6C", VA = "0x1E66D6C")]
	private void OnChatBtnClick()
	{
	}

	[Token(Token = "0x6011925")]
	[Address(RVA = "0x1E66E94", Offset = "0x1E66E94", VA = "0x1E66E94")]
	private void OnMicroPhoneMuteToggleChange()
	{
	}

	[Token(Token = "0x6011926")]
	[Address(RVA = "0x1E67000", Offset = "0x1E67000", VA = "0x1E67000")]
	private void OnSpeakerMuteAllBtnClicked()
	{
	}

	[Token(Token = "0x6011927")]
	[Address(RVA = "0x1E632C0", Offset = "0x1E632C0", VA = "0x1E632C0")]
	private void RefreshGameVoiceBtnView()
	{
	}

	[Token(Token = "0x6011928")]
	[Address(RVA = "0x1E67228", Offset = "0x1E67228", VA = "0x1E67228")]
	private void OnVoiceJoinRoom(object[] data)
	{
	}

	[Token(Token = "0x6011929")]
	[Address(RVA = "0x1E672F8", Offset = "0x1E672F8", VA = "0x1E672F8")]
	private void OnMicrophoneChanged(object[] data)
	{
	}

	[Token(Token = "0x601192A")]
	[Address(RVA = "0x1E660D4", Offset = "0x1E660D4", VA = "0x1E660D4")]
	protected void UpdateInfoPanelBG(bool open)
	{
	}

	[Token(Token = "0x601192B")]
	[Address(RVA = "0x1E67444", Offset = "0x1E67444", VA = "0x1E67444")]
	private void OnBackBtnClick()
	{
	}

	[Token(Token = "0x601192C")]
	[Address(RVA = "0x1E67570", Offset = "0x1E67570", VA = "0x1E67570")]
	protected void OnCountDownStart(object[] data)
	{
	}

	[Token(Token = "0x601192D")]
	[Address(RVA = "0x1E67774", Offset = "0x1E67774", VA = "0x1E67774", Slot = "61")]
	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x601192E")]
	[Address(RVA = "0x1E67AC0", Offset = "0x1E67AC0", VA = "0x1E67AC0", Slot = "45")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x601192F")]
	[Address(RVA = "0x1E67B3C", Offset = "0x1E67B3C", VA = "0x1E67B3C")]
	private void OnSelectedChanged(object[] data)
	{
	}

	[Token(Token = "0x6011930")]
	[Address(RVA = "0x1E67CA8", Offset = "0x1E67CA8", VA = "0x1E67CA8", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011931")]
	[Address(RVA = "0x1E6805C", Offset = "0x1E6805C", VA = "0x1E6805C", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011932")]
	[Address(RVA = "0x1E68180", Offset = "0x1E68180", VA = "0x1E68180")]
	private static int _003CRefreshUIData_003Em__0(RoomPlayerInfo a, RoomPlayerInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6011933")]
	[Address(RVA = "0x1E68200", Offset = "0x1E68200", VA = "0x1E68200")]
	private static void _003COnBtnGameStart_003Em__1(string s)
	{
	}

	[Token(Token = "0x6011934")]
	[Address(RVA = "0x1E68448", Offset = "0x1E68448", VA = "0x1E68448")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011935")]
	[Address(RVA = "0x1E68450", Offset = "0x1E68450", VA = "0x1E68450")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011936")]
	[Address(RVA = "0x1E68458", Offset = "0x1E68458", VA = "0x1E68458")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6011937")]
	[Address(RVA = "0x1E68460", Offset = "0x1E68460", VA = "0x1E68460")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6011938")]
	[Address(RVA = "0x1E68468", Offset = "0x1E68468", VA = "0x1E68468")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
