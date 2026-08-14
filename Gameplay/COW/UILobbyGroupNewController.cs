using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002923")]
public class UILobbyGroupNewController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002924")]
	private sealed class _003CSetButtonCoolDown_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FD6C")]
		[FieldOffset(Offset = "0x8")]
		internal float delayTime;

		[Token(Token = "0x400FD6D")]
		[FieldOffset(Offset = "0xC")]
		internal UIButton btn;

		[Token(Token = "0x400FD6E")]
		[FieldOffset(Offset = "0x10")]
		internal UILobbyGroupNewController _0024this;

		[Token(Token = "0x400FD6F")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400FD70")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400FD71")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x1700121A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010587")]
			[Address(RVA = "0xDB0930", Offset = "0xDB0930", VA = "0xDB0930", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700121B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6010588")]
			[Address(RVA = "0xDB0938", Offset = "0xDB0938", VA = "0xDB0938", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6010585")]
		[Address(RVA = "0xDABAF8", Offset = "0xDABAF8", VA = "0xDABAF8")]
		public _003CSetButtonCoolDown_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6010586")]
		[Address(RVA = "0xDB0814", Offset = "0xDB0814", VA = "0xDB0814", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010589")]
		[Address(RVA = "0xDB0940", Offset = "0xDB0940", VA = "0xDB0940", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601058A")]
		[Address(RVA = "0xDB0954", Offset = "0xDB0954", VA = "0xDB0954", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400FD57")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyGroupNewView m_View;

	[Token(Token = "0x400FD58")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x400FD59")]
	[FieldOffset(Offset = "0x30")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x400FD5A")]
	[FieldOffset(Offset = "0x34")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400FD5B")]
	[FieldOffset(Offset = "0x38")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400FD5C")]
	[FieldOffset(Offset = "0x3C")]
	protected byte m_GameMode;

	[Token(Token = "0x400FD5D")]
	[FieldOffset(Offset = "0x40")]
	private UIPopupMessageBoxController m_QuitDialog;

	[Token(Token = "0x400FD5E")]
	[FieldOffset(Offset = "0x44")]
	private HHDIPHFOBFO m_GroupMode;

	[Token(Token = "0x400FD5F")]
	[FieldOffset(Offset = "0x48")]
	private string m_MapName;

	[Token(Token = "0x400FD60")]
	[FieldOffset(Offset = "0x4C")]
	private string m_ModeName;

	[Token(Token = "0x400FD61")]
	[FieldOffset(Offset = "0x50")]
	private uint m_DelayCallID;

	[Token(Token = "0x400FD62")]
	[FieldOffset(Offset = "0x54")]
	private bool m_CanInviteJoin;

	[Token(Token = "0x400FD63")]
	[FieldOffset(Offset = "0x58")]
	private BoxCollider m_CheckBtnCollider;

	[Token(Token = "0x400FD64")]
	[FieldOffset(Offset = "0x5C")]
	private readonly int INVITE_GUIDE_TIME;

	[Token(Token = "0x400FD65")]
	[FieldOffset(Offset = "0x60")]
	private uint m_TipsGuideCall;

	[Token(Token = "0x400FD66")]
	[FieldOffset(Offset = "0x64")]
	private uint m_StartGameGuideCall;

	[Token(Token = "0x400FD67")]
	[FieldOffset(Offset = "0x68")]
	private UICommonGuideController m_CommonGuideCtrl;

	[Token(Token = "0x400FD68")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_PlayDelayCall;

	[Token(Token = "0x400FD69")]
	[FieldOffset(Offset = "0x70")]
	private ulong m_LastChangePublicTime;

	[Token(Token = "0x400FD6A")]
	[FieldOffset(Offset = "0x78")]
	private bool m_UpdateAfterPurchase;

	[Token(Token = "0x400FD6B")]
	[FieldOffset(Offset = "0x79")]
	private bool m_AllReady;

	[Token(Token = "0x6010531")]
	[Address(RVA = "0xD9E3FC", Offset = "0xD9E3FC", VA = "0xD9E3FC")]
	public UILobbyGroupNewController()
	{
	}

	[Token(Token = "0x6010532")]
	[Address(RVA = "0xD9E488", Offset = "0xD9E488", VA = "0xD9E488")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010533")]
	[Address(RVA = "0xD9E530", Offset = "0xD9E530", VA = "0xD9E530", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010534")]
	[Address(RVA = "0xDA4684", Offset = "0xDA4684", VA = "0xDA4684")]
	private void OnPeriodicLadderMapSelectChanged(object[] param)
	{
	}

	[Token(Token = "0x6010535")]
	[Address(RVA = "0xDA235C", Offset = "0xDA235C", VA = "0xDA235C")]
	private void UpdateGroupInfo()
	{
	}

	[Token(Token = "0x6010536")]
	[Address(RVA = "0xDA53C8", Offset = "0xDA53C8", VA = "0xDA53C8")]
	private void OnClickOpenInvite()
	{
	}

	[Token(Token = "0x6010537")]
	[Address(RVA = "0xDA54D4", Offset = "0xDA54D4", VA = "0xDA54D4")]
	private void OnCupTicketToggleChange()
	{
	}

	[Token(Token = "0x6010538")]
	[Address(RVA = "0xDA5B1C", Offset = "0xDA5B1C", VA = "0xDA5B1C")]
	private void OnCodeCopyBtnClick()
	{
	}

	[Token(Token = "0x6010539")]
	[Address(RVA = "0xDA5DF4", Offset = "0xDA5DF4", VA = "0xDA5DF4")]
	private bool CanRequestUseTicket(bool choice)
	{
		return default(bool);
	}

	[Token(Token = "0x601053A")]
	[Address(RVA = "0xDA6074", Offset = "0xDA6074", VA = "0xDA6074")]
	private void OnClickChangePublic()
	{
	}

	[Token(Token = "0x601053B")]
	[Address(RVA = "0xDA17C4", Offset = "0xDA17C4", VA = "0xDA17C4")]
	private void ChangePublicState(object[] args)
	{
	}

	[Token(Token = "0x601053C")]
	[Address(RVA = "0xDA4D64", Offset = "0xDA4D64", VA = "0xDA4D64")]
	private void SetGroupCodeData()
	{
	}

	[Token(Token = "0x601053D")]
	[Address(RVA = "0xDA6430", Offset = "0xDA6430", VA = "0xDA6430")]
	public void SetData(string modeName, string mapName, uint groupMode)
	{
	}

	[Token(Token = "0x601053E")]
	[Address(RVA = "0xDA64B8", Offset = "0xDA64B8", VA = "0xDA64B8")]
	private void OnClickLeaveGroup(object[] data)
	{
	}

	[Token(Token = "0x601053F")]
	[Address(RVA = "0xDA66A0", Offset = "0xDA66A0", VA = "0xDA66A0")]
	private void onLeaveBtnClick()
	{
	}

	[Token(Token = "0x6010540")]
	[Address(RVA = "0xDA6C18", Offset = "0xDA6C18", VA = "0xDA6C18", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010541")]
	[Address(RVA = "0xDA7AF8", Offset = "0xDA7AF8", VA = "0xDA7AF8")]
	private void OnMatchmakingHide(object[] data)
	{
	}

	[Token(Token = "0x6010542")]
	[Address(RVA = "0xDA7B98", Offset = "0xDA7B98", VA = "0xDA7B98")]
	private void OnMatchmakingShow(object[] data)
	{
	}

	[Token(Token = "0x6010543")]
	[Address(RVA = "0xDA7DF4", Offset = "0xDA7DF4", VA = "0xDA7DF4")]
	private void OnCupTeamLockSuccess(object[] data)
	{
	}

	[Token(Token = "0x6010544")]
	[Address(RVA = "0xDA7E8C", Offset = "0xDA7E8C", VA = "0xDA7E8C")]
	private void OnGroupQuit(object[] data)
	{
	}

	[Token(Token = "0x6010545")]
	[Address(RVA = "0xDA8070", Offset = "0xDA8070", VA = "0xDA8070", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010546")]
	[Address(RVA = "0xDA854C", Offset = "0xDA854C", VA = "0xDA854C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010547")]
	[Address(RVA = "0xDA7F14", Offset = "0xDA7F14", VA = "0xDA7F14")]
	public void CloseGroupUI()
	{
	}

	[Token(Token = "0x6010548")]
	[Address(RVA = "0xDA8970", Offset = "0xDA8970", VA = "0xDA8970")]
	private void OnPlayBtnClick()
	{
	}

	[Token(Token = "0x6010549")]
	[Address(RVA = "0xDAAAF0", Offset = "0xDAAAF0", VA = "0xDAAAF0")]
	private void OnCupMatchSecondConfirm()
	{
	}

	[Token(Token = "0x601054A")]
	[Address(RVA = "0xDAADF8", Offset = "0xDAADF8", VA = "0xDAADF8")]
	private void OnReadyBtnClick()
	{
	}

	[Token(Token = "0x601054B")]
	[Address(RVA = "0xDAB8F4", Offset = "0xDAB8F4", VA = "0xDAB8F4")]
	private bool CheckIsMapAvailabe()
	{
		return default(bool);
	}

	[Token(Token = "0x601054C")]
	[Address(RVA = "0xDAB7D4", Offset = "0xDAB7D4", VA = "0xDAB7D4")]
	private IEnumerator SetButtonCoolDown(UIButton btn, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x601054D")]
	[Address(RVA = "0xDAA99C", Offset = "0xDAA99C", VA = "0xDAA99C")]
	private void StartMatchMaking()
	{
	}

	[Token(Token = "0x601054E")]
	[Address(RVA = "0xDABB00", Offset = "0xDABB00", VA = "0xDABB00", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601054F")]
	[Address(RVA = "0xDAC96C", Offset = "0xDAC96C", VA = "0xDAC96C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010550")]
	[Address(RVA = "0xDACAB8", Offset = "0xDACAB8", VA = "0xDACAB8")]
	private void OnGroupStartNtf(object[] data)
	{
	}

	[Token(Token = "0x6010551")]
	[Address(RVA = "0xDACC10", Offset = "0xDACC10", VA = "0xDACC10")]
	private void onBgBtnClick()
	{
	}

	[Token(Token = "0x6010552")]
	[Address(RVA = "0xDACCDC", Offset = "0xDACCDC", VA = "0xDACCDC")]
	private void onCheckBtnClick()
	{
	}

	[Token(Token = "0x6010553")]
	[Address(RVA = "0xDACD90", Offset = "0xDACD90", VA = "0xDACD90")]
	private void OnGroupStopNtf(object[] data)
	{
	}

	[Token(Token = "0x6010554")]
	[Address(RVA = "0xDA13D0", Offset = "0xDA13D0", VA = "0xDA13D0")]
	private void OnGroupReadyNtf(object[] data)
	{
	}

	[Token(Token = "0x6010555")]
	[Address(RVA = "0xDA4C08", Offset = "0xDA4C08", VA = "0xDA4C08")]
	private void RefreshReadyBtnStyle()
	{
	}

	[Token(Token = "0x6010556")]
	[Address(RVA = "0xDA1284", Offset = "0xDA1284", VA = "0xDA1284")]
	private void onUIGroupAllReady(object[] data)
	{
	}

	[Token(Token = "0x6010557")]
	[Address(RVA = "0xDA4708", Offset = "0xDA4708", VA = "0xDA4708")]
	private void RefreshStartBtn()
	{
	}

	[Token(Token = "0x6010558")]
	[Address(RVA = "0xDA7C94", Offset = "0xDA7C94", VA = "0xDA7C94")]
	private void ShowReadyEffect(bool show)
	{
	}

	[Token(Token = "0x6010559")]
	[Address(RVA = "0xDAD710", Offset = "0xDAD710", VA = "0xDAD710")]
	private void OnGroupChangeNtf(object[] data)
	{
	}

	[Token(Token = "0x601055A")]
	[Address(RVA = "0xDA25E4", Offset = "0xDA25E4", VA = "0xDA25E4")]
	private void HideOnlineMatchInfo()
	{
	}

	[Token(Token = "0x601055B")]
	[Address(RVA = "0xDA2704", Offset = "0xDA2704", VA = "0xDA2704")]
	private void RefreshChampionshipInfo()
	{
	}

	[Token(Token = "0x601055C")]
	[Address(RVA = "0xDA30B8", Offset = "0xDA30B8", VA = "0xDA30B8")]
	private void RefreshCupMatchInfo()
	{
	}

	[Token(Token = "0x601055D")]
	[Address(RVA = "0xDAC3A8", Offset = "0xDAC3A8", VA = "0xDAC3A8")]
	private void RefreshTeamName()
	{
	}

	[Token(Token = "0x601055E")]
	[Address(RVA = "0xDAC568", Offset = "0xDAC568", VA = "0xDAC568")]
	private void RefreshCupMatchTeamName()
	{
	}

	[Token(Token = "0x601055F")]
	[Address(RVA = "0xDA1B60", Offset = "0xDA1B60", VA = "0xDA1B60")]
	private void RefreshAutoMatchUI()
	{
	}

	[Token(Token = "0x6010560")]
	[Address(RVA = "0xDAD880", Offset = "0xDAD880", VA = "0xDAD880")]
	private void OnServiceOff(object[] data)
	{
	}

	[Token(Token = "0x6010561")]
	[Address(RVA = "0xDADB40", Offset = "0xDADB40", VA = "0xDADB40")]
	private void OnQuitToSolo(object[] data)
	{
	}

	[Token(Token = "0x6010562")]
	[Address(RVA = "0xDADBC8", Offset = "0xDADBC8", VA = "0xDADBC8")]
	private void OnCreateGroupFail(object[] data)
	{
	}

	[Token(Token = "0x6010563")]
	[Address(RVA = "0xDADC50", Offset = "0xDADC50", VA = "0xDADC50", Slot = "33")]
	protected virtual Vector3 GetGameVoiceGroupPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6010564")]
	[Address(RVA = "0xDADCEC", Offset = "0xDADCEC", VA = "0xDADCEC")]
	private void OnDismissNtf(object[] data)
	{
	}

	[Token(Token = "0x6010565")]
	[Address(RVA = "0xDADD54", Offset = "0xDADD54", VA = "0xDADD54")]
	private void NotInGroup(object[] data)
	{
	}

	[Token(Token = "0x6010566")]
	[Address(RVA = "0xDADDBC", Offset = "0xDADDBC", VA = "0xDADDBC")]
	private void OnGroupCodeHelperBtnClick()
	{
	}

	[Token(Token = "0x6010567")]
	[Address(RVA = "0xDA2518", Offset = "0xDA2518", VA = "0xDA2518")]
	private void AdjustUIForNotchScreen()
	{
	}

	[Token(Token = "0x6010568")]
	[Address(RVA = "0xDAE004", Offset = "0xDAE004", VA = "0xDAE004")]
	private void OnClickJoinInvite()
	{
	}

	[Token(Token = "0x6010569")]
	[Address(RVA = "0xDAE9B0", Offset = "0xDAE9B0", VA = "0xDAE9B0")]
	private void OnTicketBtnClick()
	{
	}

	[Token(Token = "0x601056A")]
	[Address(RVA = "0xDAED04", Offset = "0xDAED04", VA = "0xDAED04")]
	private void OnClickWeaponBtn()
	{
	}

	[Token(Token = "0x601056B")]
	[Address(RVA = "0xDAEE14", Offset = "0xDAEE14", VA = "0xDAEE14")]
	public void StartNewbieGuide()
	{
	}

	[Token(Token = "0x601056C")]
	[Address(RVA = "0xDAF048", Offset = "0xDAF048", VA = "0xDAF048")]
	public void StopNewbieGuide(object[] args)
	{
	}

	[Token(Token = "0x601056D")]
	[Address(RVA = "0xDA86E4", Offset = "0xDA86E4", VA = "0xDA86E4")]
	public void OnStopGroupNewbieGuide()
	{
	}

	[Token(Token = "0x601056E")]
	[Address(RVA = "0xDAF0B0", Offset = "0xDAF0B0", VA = "0xDAF0B0")]
	private void OnShowLobbyStartGameGuide(object[] data)
	{
	}

	[Token(Token = "0x601056F")]
	[Address(RVA = "0xDAF408", Offset = "0xDAF408", VA = "0xDAF408")]
	private void OnGroupCodeBtnClick()
	{
	}

	[Token(Token = "0x6010570")]
	[Address(RVA = "0xDA208C", Offset = "0xDA208C", VA = "0xDA208C")]
	private void UpdateGroupCode(object[] data)
	{
	}

	[Token(Token = "0x6010571")]
	[Address(RVA = "0xDAF500", Offset = "0xDAF500", VA = "0xDAF500")]
	private void OnGroupNotReady(object[] data)
	{
	}

	[Token(Token = "0x6010572")]
	[Address(RVA = "0xDAF798", Offset = "0xDAF798", VA = "0xDAF798")]
	private void OnSelfNotReady(object[] data)
	{
	}

	[Token(Token = "0x6010573")]
	[Address(RVA = "0xDA79E8", Offset = "0xDA79E8", VA = "0xDA79E8")]
	private void CancelPlayDelayCall()
	{
	}

	[Token(Token = "0x6010574")]
	[Address(RVA = "0xDA172C", Offset = "0xDA172C", VA = "0xDA172C")]
	private void ShowCupTeamLocking(bool show)
	{
	}

	[Token(Token = "0x6010575")]
	[Address(RVA = "0xDA3E98", Offset = "0xDA3E98", VA = "0xDA3E98")]
	private void RefreshGameLobbyEnterStyle()
	{
	}

	[Token(Token = "0x6010576")]
	[Address(RVA = "0xDAD3D0", Offset = "0xDAD3D0", VA = "0xDAD3D0")]
	private void SetLabelColor(UILabel label, string labelColor, string gradientTop = "", string gradientBottom = "")
	{
	}

	[Token(Token = "0x6010577")]
	[Address(RVA = "0xDAFC34", Offset = "0xDAFC34", VA = "0xDAFC34")]
	private bool CreateVFXByResName(Transform parent, string resName)
	{
		return default(bool);
	}

	[Token(Token = "0x6010578")]
	[Address(RVA = "0xDAFA30", Offset = "0xDAFA30", VA = "0xDAFA30")]
	private void SetSpriteViewByResName(UISprite sprite, string resName)
	{
	}

	[Token(Token = "0x6010579")]
	[Address(RVA = "0xDA4388", Offset = "0xDA4388", VA = "0xDA4388")]
	private void OnEnterGroupShowCaptainName()
	{
	}

	[Token(Token = "0x601057A")]
	[Address(RVA = "0xDAFF98", Offset = "0xDAFF98", VA = "0xDAFF98")]
	private void _003ConLeaveBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x601057B")]
	[Address(RVA = "0xDAFFD0", Offset = "0xDAFFD0", VA = "0xDAFFD0")]
	private void _003ConLeaveBtnClick_003Em__1()
	{
	}

	[Token(Token = "0x601057C")]
	[Address(RVA = "0xDAFFDC", Offset = "0xDAFFDC", VA = "0xDAFFDC")]
	private void _003COnClickJoinInvite_003Em__2()
	{
	}

	[Token(Token = "0x601057D")]
	[Address(RVA = "0xDAFFF0", Offset = "0xDAFFF0", VA = "0xDAFFF0")]
	private void _003CStartNewbieGuide_003Em__3()
	{
	}

	[Token(Token = "0x601057E")]
	[Address(RVA = "0xDB0430", Offset = "0xDB0430", VA = "0xDB0430")]
	private void _003CStartNewbieGuide_003Em__4()
	{
	}

	[Token(Token = "0x601057F")]
	[Address(RVA = "0xDB0744", Offset = "0xDB0744", VA = "0xDB0744")]
	private void _003COnGroupNotReady_003Em__5()
	{
	}

	[Token(Token = "0x6010580")]
	[Address(RVA = "0xDB0750", Offset = "0xDB0750", VA = "0xDB0750")]
	private void _003COnEnterGroupShowCaptainName_003Em__6()
	{
	}

	[Token(Token = "0x6010581")]
	[Address(RVA = "0xDB07F4", Offset = "0xDB07F4", VA = "0xDB07F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010582")]
	[Address(RVA = "0xDB07FC", Offset = "0xDB07FC", VA = "0xDB07FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010583")]
	[Address(RVA = "0xDB0804", Offset = "0xDB0804", VA = "0xDB0804")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6010584")]
	[Address(RVA = "0xDB080C", Offset = "0xDB080C", VA = "0xDB080C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
