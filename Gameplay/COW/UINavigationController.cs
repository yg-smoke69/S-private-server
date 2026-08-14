using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029DA")]
public class UINavigationController : UIBaseNavigationController
{
	[Token(Token = "0x20029DB")]
	public class BGInfo
	{
		[Token(Token = "0x4010166")]
		[FieldOffset(Offset = "0x8")]
		public ResourceID bgResID;

		[Token(Token = "0x4010167")]
		[FieldOffset(Offset = "0xC")]
		public string bgURL;

		[Token(Token = "0x4010168")]
		[FieldOffset(Offset = "0x10")]
		public bool needResetLocalScale;

		[Token(Token = "0x6010D93")]
		[Address(RVA = "0x1B31D58", Offset = "0x1B31D58", VA = "0x1B31D58")]
		public BGInfo()
		{
		}

		[Token(Token = "0x6010D94")]
		[Address(RVA = "0x1B352D0", Offset = "0x1B352D0", VA = "0x1B352D0")]
		public BGInfo(BGInfo bgInfo)
		{
		}
	}

	[Token(Token = "0x4010158")]
	[FieldOffset(Offset = "0x0")]
	public static List<Type> m_DontRecordTimeList;

	[Token(Token = "0x4010159")]
	[FieldOffset(Offset = "0x38")]
	public ulong m_StartShowTime;

	[Token(Token = "0x401015A")]
	[FieldOffset(Offset = "0x40")]
	public int m_ShowTime;

	[Token(Token = "0x401015B")]
	[FieldOffset(Offset = "0x44")]
	protected UILobbyProfileController m_Profile;

	[Token(Token = "0x401015C")]
	[FieldOffset(Offset = "0x48")]
	private UILobbyCoinsController m_Coins;

	[Token(Token = "0x401015D")]
	[FieldOffset(Offset = "0x4C")]
	private UINewPlayerSurveyController m_NewPlayerSurvey;

	[Token(Token = "0x401015E")]
	[FieldOffset(Offset = "0x50")]
	protected UITopButtonGroupController m_TopBtns;

	[Token(Token = "0x401015F")]
	[FieldOffset(Offset = "0x54")]
	private UILobbyChatController m_ChatBtn;

	[Token(Token = "0x4010160")]
	[FieldOffset(Offset = "0x58")]
	private UILobbyOptionalDownloaderController m_OptionalDownload;

	[Token(Token = "0x4010161")]
	[FieldOffset(Offset = "0x5C")]
	private bool showTopBar;

	[Token(Token = "0x4010162")]
	[FieldOffset(Offset = "0x5D")]
	private bool showChatBtn;

	[Token(Token = "0x4010163")]
	[FieldOffset(Offset = "0x5E")]
	protected bool isDataInited;

	[Token(Token = "0x4010164")]
	[FieldOffset(Offset = "0x60")]
	protected BGInfo m_bgInfo;

	[Token(Token = "0x4010165")]
	[FieldOffset(Offset = "0x64")]
	protected GameObject m_BGVFX;

	[Token(Token = "0x6010D69")]
	[Address(RVA = "0x1B30B14", Offset = "0x1B30B14", VA = "0x1B30B14")]
	public UINavigationController()
	{
	}

	[Token(Token = "0x6010D6A")]
	[Address(RVA = "0x1B31E00", Offset = "0x1B31E00", VA = "0x1B31E00", Slot = "35")]
	protected virtual void AvatarCameraStateChange(UINavigationData navigationData)
	{
	}

	[Token(Token = "0x6010D6B")]
	[Address(RVA = "0x1B31FC0", Offset = "0x1B31FC0", VA = "0x1B31FC0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010D6C")]
	[Address(RVA = "0x1B325D4", Offset = "0x1B325D4", VA = "0x1B325D4")]
	protected void SetCornerGroups(bool status)
	{
	}

	[Token(Token = "0x6010D6D")]
	[Address(RVA = "0x1B3292C", Offset = "0x1B3292C", VA = "0x1B3292C")]
	protected void SetChatBtn(bool status)
	{
	}

	[Token(Token = "0x6010D6E")]
	[Address(RVA = "0x1B32A54", Offset = "0x1B32A54", VA = "0x1B32A54")]
	protected UILobbyChatController GetChatBtn()
	{
		return null;
	}

	[Token(Token = "0x6010D6F")]
	[Address(RVA = "0x1B32AAC", Offset = "0x1B32AAC", VA = "0x1B32AAC")]
	public UIBaseController GetTopButtonGroup()
	{
		return null;
	}

	[Token(Token = "0x6010D70")]
	[Address(RVA = "0x1B32B04", Offset = "0x1B32B04", VA = "0x1B32B04")]
	public Vector3 GetNaviTitleLeftPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6010D71")]
	[Address(RVA = "0x1B32C48", Offset = "0x1B32C48", VA = "0x1B32C48")]
	public Transform GetNaviCustomizedCtrlTrans()
	{
		return null;
	}

	[Token(Token = "0x6010D72")]
	[Address(RVA = "0x1B30DA0", Offset = "0x1B30DA0", VA = "0x1B30DA0", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6010D73")]
	[Address(RVA = "0x1B32EF8", Offset = "0x1B32EF8", VA = "0x1B32EF8", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x6010D74")]
	[Address(RVA = "0x1B33340", Offset = "0x1B33340", VA = "0x1B33340", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010D75")]
	[Address(RVA = "0x1B3362C", Offset = "0x1B3362C", VA = "0x1B3362C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010D76")]
	[Address(RVA = "0x1B33750", Offset = "0x1B33750", VA = "0x1B33750", Slot = "36")]
	protected virtual void OnSendShowTimeEvent(ref string eventLogKey, ref EventLogger.EventPageDetentionTime eventLog)
	{
	}

	[Token(Token = "0x6010D77")]
	[Address(RVA = "0x1B337C0", Offset = "0x1B337C0", VA = "0x1B337C0")]
	protected void OnDataReady()
	{
	}

	[Token(Token = "0x6010D78")]
	[Address(RVA = "0x1B33858", Offset = "0x1B33858", VA = "0x1B33858")]
	public UITexture GetBG()
	{
		return null;
	}

	[Token(Token = "0x6010D79")]
	[Address(RVA = "0x1B32D54", Offset = "0x1B32D54", VA = "0x1B32D54")]
	public void SetBG(BGInfo bgInfo)
	{
	}

	[Token(Token = "0x6010D7A")]
	[Address(RVA = "0x1B33AC4", Offset = "0x1B33AC4", VA = "0x1B33AC4")]
	public void SetBG(ResourceID bgRes, int width = 0, int height = 0, bool isFliphHorizontally = false, bool needResetLocalScale = true)
	{
	}

	[Token(Token = "0x6010D7B")]
	[Address(RVA = "0x1B33CA8", Offset = "0x1B33CA8", VA = "0x1B33CA8")]
	public void SetBG(string url, int width = 0, int height = 0, bool needResetLocalScale = true)
	{
	}

	[Token(Token = "0x6010D7C")]
	[Address(RVA = "0x1B33E38", Offset = "0x1B33E38", VA = "0x1B33E38")]
	public void SetBG(AdType adType, int width = 0, int height = 0, bool needResetLocalScale = true)
	{
	}

	[Token(Token = "0x6010D7D")]
	[Address(RVA = "0x1B33988", Offset = "0x1B33988", VA = "0x1B33988")]
	public void SetBGActive(bool active)
	{
	}

	[Token(Token = "0x6010D7E")]
	[Address(RVA = "0x1B33FFC", Offset = "0x1B33FFC", VA = "0x1B33FFC")]
	public void SetBGVFXActive(bool active)
	{
	}

	[Token(Token = "0x6010D7F")]
	[Address(RVA = "0x1B34104", Offset = "0x1B34104", VA = "0x1B34104")]
	public void SetBGVFX(ResourceID bgVFXRes, Vector2 offset, Vector2 scale)
	{
	}

	[Token(Token = "0x6010D80")]
	[Address(RVA = "0x1B34634", Offset = "0x1B34634", VA = "0x1B34634", Slot = "37")]
	protected virtual bool NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6010D81")]
	[Address(RVA = "0x1B3468C", Offset = "0x1B3468C", VA = "0x1B3468C", Slot = "38")]
	public virtual EFrontendBGMType GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x6010D82")]
	[Address(RVA = "0x1B346E4", Offset = "0x1B346E4", VA = "0x1B346E4", Slot = "39")]
	public virtual List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x6010D83")]
	[Address(RVA = "0x1B31D00", Offset = "0x1B31D00", VA = "0x1B31D00", Slot = "40")]
	public virtual bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x6010D84")]
	[Address(RVA = "0x1B3473C", Offset = "0x1B3473C", VA = "0x1B3473C")]
	public void OnBackButtonClick(object[] param)
	{
	}

	[Token(Token = "0x6010D85")]
	[Address(RVA = "0x1B34850", Offset = "0x1B34850", VA = "0x1B34850", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x6010D86")]
	[Address(RVA = "0x1B348B0", Offset = "0x1B348B0", VA = "0x1B348B0")]
	protected void HideAllNavigation()
	{
	}

	[Token(Token = "0x6010D87")]
	[Address(RVA = "0x1B34AC4", Offset = "0x1B34AC4", VA = "0x1B34AC4")]
	protected void ShowAllNavigation()
	{
	}

	[Token(Token = "0x6010D88")]
	[Address(RVA = "0x1B34CF4", Offset = "0x1B34CF4", VA = "0x1B34CF4", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x6010D89")]
	[Address(RVA = "0x1B34D54", Offset = "0x1B34D54", VA = "0x1B34D54", Slot = "41")]
	protected virtual void OnHelpButtonClick(object[] param)
	{
	}

	[Token(Token = "0x6010D8A")]
	[Address(RVA = "0x1B34DB0", Offset = "0x1B34DB0", VA = "0x1B34DB0")]
	public void NaviPageReposition()
	{
	}

	[Token(Token = "0x6010D8B")]
	[Address(RVA = "0x1B34EAC", Offset = "0x1B34EAC", VA = "0x1B34EAC")]
	public void SetTopLeftBarState(bool value)
	{
	}

	[Token(Token = "0x6010D8D")]
	[Address(RVA = "0x1B352A0", Offset = "0x1B352A0", VA = "0x1B352A0")]
	public void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x6010D8E")]
	[Address(RVA = "0x1B352A8", Offset = "0x1B352A8", VA = "0x1B352A8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6010D8F")]
	[Address(RVA = "0x1B352B0", Offset = "0x1B352B0", VA = "0x1B352B0")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x6010D90")]
	[Address(RVA = "0x1B352B8", Offset = "0x1B352B8", VA = "0x1B352B8")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x6010D91")]
	[Address(RVA = "0x1B352C0", Offset = "0x1B352C0", VA = "0x1B352C0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010D92")]
	[Address(RVA = "0x1B352C8", Offset = "0x1B352C8", VA = "0x1B352C8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
