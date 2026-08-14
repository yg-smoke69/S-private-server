using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F75")]
public class UIActivitySecretMessageGeneratePopupWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400C57D")]
	public const string SECRET_MESSAGE_EXCHANGE_LIMIT_RULE_KEY = "T_35_FH_SECRETMISSION_EXCHANGEMAXNUM";

	[Token(Token = "0x400C57E")]
	private const string SECRET_MESSAGE_GENERATE_RULE_KEY = "T_35_FH_SECRETMISSION_OUTPUTRULE";

	[Token(Token = "0x400C57F")]
	private const string LATEST_SECRET_MESSAGE_PLAYER_PREF_KEY = "SecretMessage{0}_Activity{1}_Account{2}_LatestSecretMessage";

	[Token(Token = "0x400C580")]
	private const string GUIDE_STEP1_KEY = "SecretMessage_GenerateGuide_Step1_Account{0}";

	[Token(Token = "0x400C581")]
	private const string GUIDE_STEP2_KEY = "SecretMessage_GenerateGuide_Step2_Account{0}";

	[Token(Token = "0x400C582")]
	private const string LOG_IDENTIFIER = "SecretMessageGeneratePopup";

	[Token(Token = "0x400C583")]
	[FieldOffset(Offset = "0x48")]
	private uint m_ActivityID;

	[Token(Token = "0x400C584")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_SecretMessageID;

	[Token(Token = "0x400C585")]
	[FieldOffset(Offset = "0x50")]
	private uint m_DelayExecuteGuidePeek;

	[Token(Token = "0x400C586")]
	[FieldOffset(Offset = "0x54")]
	private string m_SecretMessageContent;

	[Token(Token = "0x400C587")]
	[FieldOffset(Offset = "0x58")]
	private UIActivitySecretMessageGeneratePopupWndView m_View;

	[Token(Token = "0x400C588")]
	[FieldOffset(Offset = "0x5C")]
	private UIInvitePlatformCommonGridController m_ShareGridController;

	[Token(Token = "0x400C589")]
	[FieldOffset(Offset = "0x60")]
	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	[Token(Token = "0x17000F97")]
	private bool IsViewDataSet
	{
		[Token(Token = "0x6009BFC")]
		[Address(RVA = "0x2FC0CAC", Offset = "0x2FC0CAC", VA = "0x2FC0CAC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6009BFB")]
	[Address(RVA = "0x2FC0C20", Offset = "0x2FC0C20", VA = "0x2FC0C20")]
	public UIActivitySecretMessageGeneratePopupWndController()
	{
	}

	[Token(Token = "0x6009BFD")]
	[Address(RVA = "0x2FC0D10", Offset = "0x2FC0D10", VA = "0x2FC0D10")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009BFE")]
	[Address(RVA = "0x2FC0DB8", Offset = "0x2FC0DB8", VA = "0x2FC0DB8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009BFF")]
	[Address(RVA = "0x2FC1238", Offset = "0x2FC1238", VA = "0x2FC1238", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6009C00")]
	[Address(RVA = "0x2FC1C98", Offset = "0x2FC1C98", VA = "0x2FC1C98", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6009C01")]
	[Address(RVA = "0x2FC1E40", Offset = "0x2FC1E40", VA = "0x2FC1E40", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009C02")]
	[Address(RVA = "0x2FC2E60", Offset = "0x2FC2E60", VA = "0x2FC2E60", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009C03")]
	[Address(RVA = "0x2FC132C", Offset = "0x2FC132C", VA = "0x2FC132C")]
	private void InitShareGridController()
	{
	}

	[Token(Token = "0x6009C04")]
	[Address(RVA = "0x2FC2A70", Offset = "0x2FC2A70", VA = "0x2FC2A70")]
	private void SetShareGridControllerViewData(string secretMessage)
	{
	}

	[Token(Token = "0x6009C05")]
	[Address(RVA = "0x2FC2EF4", Offset = "0x2FC2EF4", VA = "0x2FC2EF4")]
	private string GetSecondRule()
	{
		return null;
	}

	[Token(Token = "0x6009C06")]
	[Address(RVA = "0x2FC327C", Offset = "0x2FC327C", VA = "0x2FC327C")]
	private string GetThirdRule()
	{
		return null;
	}

	[Token(Token = "0x6009C07")]
	[Address(RVA = "0x2FC0F04", Offset = "0x2FC0F04", VA = "0x2FC0F04")]
	private void SetupDefaultState()
	{
	}

	[Token(Token = "0x6009C08")]
	[Address(RVA = "0x2FC222C", Offset = "0x2FC222C", VA = "0x2FC222C")]
	private void RefreshHelpTipsLabel()
	{
	}

	[Token(Token = "0x6009C09")]
	[Address(RVA = "0x2FC2550", Offset = "0x2FC2550", VA = "0x2FC2550")]
	private void RefreshPopupWndTitle()
	{
	}

	[Token(Token = "0x6009C0A")]
	[Address(RVA = "0x2FC2688", Offset = "0x2FC2688", VA = "0x2FC2688")]
	private void RefreshSecretMessageLabel(string secretMessageContent)
	{
	}

	[Token(Token = "0x6009C0B")]
	[Address(RVA = "0x2FC2720", Offset = "0x2FC2720", VA = "0x2FC2720")]
	private void RefreshSecretMessageVFX(string secretMessage)
	{
	}

	[Token(Token = "0x6009C0C")]
	[Address(RVA = "0x2FC15B0", Offset = "0x2FC15B0", VA = "0x2FC15B0")]
	private void SetInteractionStatus(bool active)
	{
	}

	[Token(Token = "0x6009C0D")]
	[Address(RVA = "0x2FC36D4", Offset = "0x2FC36D4", VA = "0x2FC36D4")]
	private void OnCopyBtnClick()
	{
	}

	[Token(Token = "0x6009C0E")]
	[Address(RVA = "0x2FC1104", Offset = "0x2FC1104", VA = "0x2FC1104")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x6009C0F")]
	[Address(RVA = "0x2FC1D04", Offset = "0x2FC1D04", VA = "0x2FC1D04")]
	private void StopGuideQueue()
	{
	}

	[Token(Token = "0x6009C10")]
	[Address(RVA = "0x2FC178C", Offset = "0x2FC178C", VA = "0x2FC178C")]
	private void PrepareGuideQueueData()
	{
	}

	[Token(Token = "0x6009C11")]
	[Address(RVA = "0x2FC2C94", Offset = "0x2FC2C94", VA = "0x2FC2C94")]
	private void StartDelayExecuteGuidePeek()
	{
	}

	[Token(Token = "0x6009C12")]
	[Address(RVA = "0x2FC3DAC", Offset = "0x2FC3DAC", VA = "0x2FC3DAC")]
	private void DelayExecuteGuidePeek()
	{
	}

	[Token(Token = "0x6009C13")]
	[Address(RVA = "0x2FC419C", Offset = "0x2FC419C", VA = "0x2FC419C")]
	private void PopAndExecuteNext()
	{
	}

	[Token(Token = "0x6009C14")]
	[Address(RVA = "0x2FC446C", Offset = "0x2FC446C", VA = "0x2FC446C")]
	public void SetViewData(uint activityID)
	{
	}

	[Token(Token = "0x6009C15")]
	[Address(RVA = "0x2FC462C", Offset = "0x2FC462C", VA = "0x2FC462C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009C16")]
	[Address(RVA = "0x2FC4634", Offset = "0x2FC4634", VA = "0x2FC4634")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6009C17")]
	[Address(RVA = "0x2FC463C", Offset = "0x2FC463C", VA = "0x2FC463C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
