using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002709")]
internal class UIHudChangeSeatController : UIBaseController
{
	[Token(Token = "0x200270A")]
	private enum EButtonStage
	{
		[Token(Token = "0x400F0F7")]
		Reqeust,
		[Token(Token = "0x400F0F8")]
		Confirmation,
		[Token(Token = "0x400F0F9")]
		NB
	}

	[Token(Token = "0x200270B")]
	private class CDData
	{
		[Token(Token = "0x400F0FA")]
		[FieldOffset(Offset = "0x8")]
		public EButtonStage Stage;

		[Token(Token = "0x400F0FB")]
		[FieldOffset(Offset = "0xC")]
		public bool IsInCD;

		[Token(Token = "0x400F0FC")]
		[FieldOffset(Offset = "0x10")]
		public float EndCDGameTime;

		[Token(Token = "0x400F0FD")]
		[FieldOffset(Offset = "0x14")]
		public float Duration;

		[Token(Token = "0x400F0FE")]
		[FieldOffset(Offset = "0x18")]
		public UIProgressBar ProgressBar;

		[Token(Token = "0x400F0FF")]
		[FieldOffset(Offset = "0x1C")]
		public Action CDFinished;

		[Token(Token = "0x600ED3C")]
		[Address(RVA = "0x214B84C", Offset = "0x214B84C", VA = "0x214B84C")]
		public CDData(EButtonStage stage, UIProgressBar progressBar)
		{
		}

		[Token(Token = "0x600ED3D")]
		[Address(RVA = "0x214CB6C", Offset = "0x214CB6C", VA = "0x214CB6C")]
		public bool IsButtonEnable()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400F0F0")]
	[FieldOffset(Offset = "0x28")]
	private UIHudChangeSeatView m_View;

	[Token(Token = "0x400F0F1")]
	[FieldOffset(Offset = "0x2C")]
	private EButtonStage m_CurrentStage;

	[Token(Token = "0x400F0F2")]
	[FieldOffset(Offset = "0x30")]
	private byte m_PendingRequestID;

	[Token(Token = "0x400F0F3")]
	[FieldOffset(Offset = "0x34")]
	private CDData[] m_CDData;

	[Token(Token = "0x400F0F4")]
	[FieldOffset(Offset = "0x38")]
	private uint m_SeatIDOnReq;

	[Token(Token = "0x400F0F5")]
	private const uint SEAT_ID_BIAS = 1u;

	[Token(Token = "0x600ED29")]
	[Address(RVA = "0x214AFC8", Offset = "0x214AFC8", VA = "0x214AFC8")]
	public UIHudChangeSeatController()
	{
	}

	[Token(Token = "0x600ED2A")]
	[Address(RVA = "0x214B068", Offset = "0x214B068", VA = "0x214B068")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ED2B")]
	[Address(RVA = "0x214B110", Offset = "0x214B110", VA = "0x214B110", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ED2C")]
	[Address(RVA = "0x214B880", Offset = "0x214B880", VA = "0x214B880")]
	private void OnConfirmClick(object[] data)
	{
	}

	[Token(Token = "0x600ED2D")]
	[Address(RVA = "0x214BF58", Offset = "0x214BF58", VA = "0x214BF58", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600ED2E")]
	[Address(RVA = "0x214C15C", Offset = "0x214C15C", VA = "0x214C15C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600ED2F")]
	[Address(RVA = "0x214C3B4", Offset = "0x214C3B4", VA = "0x214C3B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600ED30")]
	[Address(RVA = "0x214C220", Offset = "0x214C220", VA = "0x214C220")]
	private void RefreshCD(CDData currentCDData)
	{
	}

	[Token(Token = "0x600ED31")]
	[Address(RVA = "0x214C450", Offset = "0x214C450", VA = "0x214C450")]
	private void OnGetOnVehicle(object[] data)
	{
	}

	[Token(Token = "0x600ED32")]
	[Address(RVA = "0x214C620", Offset = "0x214C620", VA = "0x214C620")]
	private void OnAskChangeSeat(object[] data)
	{
	}

	[Token(Token = "0x600ED33")]
	[Address(RVA = "0x214B8F4", Offset = "0x214B8F4", VA = "0x214B8F4")]
	private void OnBtnChangeSeat()
	{
	}

	[Token(Token = "0x600ED34")]
	[Address(RVA = "0x214C900", Offset = "0x214C900", VA = "0x214C900")]
	private void ChangeStage(EButtonStage newStage)
	{
	}

	[Token(Token = "0x600ED35")]
	[Address(RVA = "0x214CBE4", Offset = "0x214CBE4", VA = "0x214CBE4")]
	private void ShowCDTimeTween()
	{
	}

	[Token(Token = "0x600ED36")]
	[Address(RVA = "0x214B740", Offset = "0x214B740", VA = "0x214B740")]
	private void HideCDTimeTween()
	{
	}

	[Token(Token = "0x600ED37")]
	[Address(RVA = "0x214CC94", Offset = "0x214CC94", VA = "0x214CC94")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600ED38")]
	[Address(RVA = "0x214CF2C", Offset = "0x214CF2C", VA = "0x214CF2C")]
	private void _003COnUIInit_003Em__1()
	{
	}

	[Token(Token = "0x600ED39")]
	[Address(RVA = "0x214CF34", Offset = "0x214CF34", VA = "0x214CF34")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ED3A")]
	[Address(RVA = "0x214CF3C", Offset = "0x214CF3C", VA = "0x214CF3C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600ED3B")]
	[Address(RVA = "0x214CF44", Offset = "0x214CF44", VA = "0x214CF44")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
