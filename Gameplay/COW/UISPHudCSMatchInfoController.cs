using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B2E")]
internal class UISPHudCSMatchInfoController : UIBaseController
{
	[Token(Token = "0x401091B")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudCSMatchInfoView m_View;

	[Token(Token = "0x401091C")]
	[FieldOffset(Offset = "0x2C")]
	private int mSeconds;

	[Token(Token = "0x401091D")]
	[FieldOffset(Offset = "0x30")]
	private StringBuilder m_Timer;

	[Token(Token = "0x401091E")]
	[FieldOffset(Offset = "0x34")]
	private uint min;

	[Token(Token = "0x401091F")]
	[FieldOffset(Offset = "0x38")]
	private uint sec;

	[Token(Token = "0x4010920")]
	[FieldOffset(Offset = "0x3C")]
	private OAINDKGMHJK mGame;

	[Token(Token = "0x4010921")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsSetTeamBlueName;

	[Token(Token = "0x4010922")]
	[FieldOffset(Offset = "0x41")]
	private bool m_IsSetTeamRedName;

	[Token(Token = "0x4010923")]
	[FieldOffset(Offset = "0x42")]
	private bool m_IsSetTeamBlueIcon;

	[Token(Token = "0x4010924")]
	[FieldOffset(Offset = "0x43")]
	private bool m_IsSetTeamRedIcon;

	[Token(Token = "0x4010925")]
	[FieldOffset(Offset = "0x44")]
	private bool m_StartProgressing;

	[Token(Token = "0x4010926")]
	[FieldOffset(Offset = "0x48")]
	private UIProgressBar m_RemoveBombProgressBar;

	[Token(Token = "0x4010927")]
	[FieldOffset(Offset = "0x4C")]
	private float m_StartTime;

	[Token(Token = "0x4010928")]
	[FieldOffset(Offset = "0x50")]
	private float m_TotalTime;

	[Token(Token = "0x4010929")]
	[FieldOffset(Offset = "0x54")]
	private uint m_BombExplodeTime;

	[Token(Token = "0x401092A")]
	[FieldOffset(Offset = "0x58")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x6011C44")]
	[Address(RVA = "0x1D10978", Offset = "0x1D10978", VA = "0x1D10978")]
	public UISPHudCSMatchInfoController()
	{
	}

	[Token(Token = "0x6011C45")]
	[Address(RVA = "0x1D109FC", Offset = "0x1D109FC", VA = "0x1D109FC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011C46")]
	[Address(RVA = "0x1D10AA4", Offset = "0x1D10AA4", VA = "0x1D10AA4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011C47")]
	[Address(RVA = "0x1D1140C", Offset = "0x1D1140C", VA = "0x1D1140C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011C48")]
	[Address(RVA = "0x1D11880", Offset = "0x1D11880", VA = "0x1D11880", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011C49")]
	[Address(RVA = "0x1D118FC", Offset = "0x1D118FC", VA = "0x1D118FC")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x6011C4A")]
	[Address(RVA = "0x1D11E10", Offset = "0x1D11E10", VA = "0x1D11E10")]
	private void Update()
	{
	}

	[Token(Token = "0x6011C4B")]
	[Address(RVA = "0x1D11F30", Offset = "0x1D11F30", VA = "0x1D11F30")]
	private void UpdateCSCountdown()
	{
	}

	[Token(Token = "0x6011C4C")]
	[Address(RVA = "0x1D12428", Offset = "0x1D12428", VA = "0x1D12428")]
	private void UpdateBombCountdown()
	{
	}

	[Token(Token = "0x6011C4D")]
	[Address(RVA = "0x1D129CC", Offset = "0x1D129CC", VA = "0x1D129CC")]
	protected void LateUpdate()
	{
	}

	[Token(Token = "0x6011C4E")]
	[Address(RVA = "0x1D12BEC", Offset = "0x1D12BEC", VA = "0x1D12BEC")]
	private void OnAddPlayer(object[] data)
	{
	}

	[Token(Token = "0x6011C4F")]
	[Address(RVA = "0x1D1329C", Offset = "0x1D1329C", VA = "0x1D1329C")]
	private void OnScoreChanged(object[] data)
	{
	}

	[Token(Token = "0x6011C50")]
	[Address(RVA = "0x1D1353C", Offset = "0x1D1353C", VA = "0x1D1353C")]
	private void OnCoinChanged(object[] data)
	{
	}

	[Token(Token = "0x6011C51")]
	[Address(RVA = "0x1D13C3C", Offset = "0x1D13C3C", VA = "0x1D13C3C")]
	private void OnNewPhaseEnter(object[] data)
	{
	}

	[Token(Token = "0x6011C52")]
	[Address(RVA = "0x1D13FE4", Offset = "0x1D13FE4", VA = "0x1D13FE4")]
	private void OnBombPlantTimeSync(object[] data)
	{
	}

	[Token(Token = "0x6011C53")]
	[Address(RVA = "0x1D11B00", Offset = "0x1D11B00", VA = "0x1D11B00")]
	private void SetRoundInfoUI()
	{
	}

	[Token(Token = "0x6011C54")]
	[Address(RVA = "0x1D14164", Offset = "0x1D14164", VA = "0x1D14164")]
	private void OnDelayHideEconomyInfo()
	{
	}

	[Token(Token = "0x6011C55")]
	[Address(RVA = "0x1D14224", Offset = "0x1D14224", VA = "0x1D14224")]
	private void OnFactionChange(object[] data)
	{
	}

	[Token(Token = "0x6011C56")]
	[Address(RVA = "0x1D14408", Offset = "0x1D14408", VA = "0x1D14408")]
	private void OnODFactionChange(object[] data)
	{
	}

	[Token(Token = "0x6011C57")]
	[Address(RVA = "0x1D14574", Offset = "0x1D14574", VA = "0x1D14574")]
	private void On3PPreparation(object[] data)
	{
	}

	[Token(Token = "0x6011C58")]
	[Address(RVA = "0x1D14BC8", Offset = "0x1D14BC8", VA = "0x1D14BC8")]
	private void OnBombRemoved(object[] data)
	{
	}

	[Token(Token = "0x6011C59")]
	[Address(RVA = "0x1D14D08", Offset = "0x1D14D08", VA = "0x1D14D08")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011C5A")]
	[Address(RVA = "0x1D14D10", Offset = "0x1D14D10", VA = "0x1D14D10")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011C5B")]
	[Address(RVA = "0x1D14D18", Offset = "0x1D14D18", VA = "0x1D14D18")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
