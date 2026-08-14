using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029EB")]
internal class UINewPlayerUpGradesController : UIBaseController, _Attribute
{
	[Token(Token = "0x40101CD")]
	[FieldOffset(Offset = "0x28")]
	private uint characterMaxLevel;

	[Token(Token = "0x40101CE")]
	[FieldOffset(Offset = "0x2C")]
	private UINewPlayerUpGradesView m_View;

	[Token(Token = "0x40101CF")]
	[FieldOffset(Offset = "0x30")]
	private BaseItemInfo characterItemInfo;

	[Token(Token = "0x40101D0")]
	[FieldOffset(Offset = "0x34")]
	private UIModelNewPlayerUpGrades m_Model;

	[Token(Token = "0x40101D1")]
	[FieldOffset(Offset = "0x38")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x6010E1C")]
	[Address(RVA = "0x27AECD0", Offset = "0x27AECD0", VA = "0x27AECD0")]
	public UINewPlayerUpGradesController()
	{
	}

	[Token(Token = "0x6010E1D")]
	[Address(RVA = "0x27AEDC4", Offset = "0x27AEDC4", VA = "0x27AEDC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010E1E")]
	[Address(RVA = "0x27AEE6C", Offset = "0x27AEE6C", VA = "0x27AEE6C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010E1F")]
	[Address(RVA = "0x27AF270", Offset = "0x27AF270", VA = "0x27AF270", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010E20")]
	[Address(RVA = "0x27AF2D4", Offset = "0x27AF2D4", VA = "0x27AF2D4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010E21")]
	[Address(RVA = "0x27AF338", Offset = "0x27AF338", VA = "0x27AF338", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010E22")]
	[Address(RVA = "0x27AF514", Offset = "0x27AF514", VA = "0x27AF514")]
	private void SetSprite(string ResName, UISprite InSprite)
	{
	}

	[Token(Token = "0x6010E23")]
	[Address(RVA = "0x27AF66C", Offset = "0x27AF66C", VA = "0x27AF66C")]
	private void OnBtnNewPlayerUpCharacterClick()
	{
	}

	[Token(Token = "0x6010E24")]
	[Address(RVA = "0x27AF930", Offset = "0x27AF930", VA = "0x27AF930")]
	private void OnBtnMatchGameClick()
	{
	}

	[Token(Token = "0x6010E25")]
	[Address(RVA = "0x27AF9A8", Offset = "0x27AF9A8", VA = "0x27AF9A8")]
	private void OnBtnTrainingCampClick()
	{
	}

	[Token(Token = "0x6010E26")]
	[Address(RVA = "0x27AFB30", Offset = "0x27AFB30", VA = "0x27AFB30", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010E27")]
	[Address(RVA = "0x27AFC30", Offset = "0x27AFC30", VA = "0x27AFC30", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010E28")]
	[Address(RVA = "0x27AFE60", Offset = "0x27AFE60", VA = "0x27AFE60")]
	public void RefreshUI()
	{
	}

	[Token(Token = "0x6010E29")]
	[Address(RVA = "0x27AFED0", Offset = "0x27AFED0", VA = "0x27AFED0")]
	private void RefreshChaUI()
	{
	}

	[Token(Token = "0x6010E2A")]
	[Address(RVA = "0x27B038C", Offset = "0x27B038C", VA = "0x27B038C")]
	private void RefreshMatchGameUI()
	{
	}

	[Token(Token = "0x6010E2B")]
	[Address(RVA = "0x27B0BB8", Offset = "0x27B0BB8", VA = "0x27B0BB8")]
	private void RefreshTrainCampUI()
	{
	}

	[Token(Token = "0x6010E2C")]
	[Address(RVA = "0x27B0C9C", Offset = "0x27B0C9C", VA = "0x27B0C9C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010E2D")]
	[Address(RVA = "0x27B0CA4", Offset = "0x27B0CA4", VA = "0x27B0CA4")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6010E2E")]
	[Address(RVA = "0x27B0CAC", Offset = "0x27B0CAC", VA = "0x27B0CAC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010E2F")]
	[Address(RVA = "0x27B0CB4", Offset = "0x27B0CB4", VA = "0x27B0CB4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
