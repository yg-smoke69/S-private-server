using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020CD")]
public class UIEPDailyRewardItemController : UIBaseController
{
	[Token(Token = "0x20020CE")]
	private enum ERewardStatus
	{
		[Token(Token = "0x400CD5C")]
		UnFinish,
		[Token(Token = "0x400CD5D")]
		Available,
		[Token(Token = "0x400CD5E")]
		Received
	}

	[Token(Token = "0x400CD52")]
	[FieldOffset(Offset = "0x28")]
	public GameObject LockGO;

	[Token(Token = "0x400CD53")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject UnLockGO;

	[Token(Token = "0x400CD54")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ClaimedGO;

	[Token(Token = "0x400CD55")]
	[FieldOffset(Offset = "0x34")]
	public GameObject CanCliamEffect;

	[Token(Token = "0x400CD56")]
	[FieldOffset(Offset = "0x38")]
	public GameObject TipGO;

	[Token(Token = "0x400CD57")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel AwardCntLabel;

	[Token(Token = "0x400CD58")]
	[FieldOffset(Offset = "0x40")]
	public UIButton OperBtn;

	[Token(Token = "0x400CD59")]
	[FieldOffset(Offset = "0x44")]
	private UIStandardItemMAXBController m_Ctrl;

	[Token(Token = "0x400CD5A")]
	[FieldOffset(Offset = "0x48")]
	private EPDailyRewardInfo m_Data;

	[Token(Token = "0x600A991")]
	[Address(RVA = "0x2BA2198", Offset = "0x2BA2198", VA = "0x2BA2198")]
	public UIEPDailyRewardItemController()
	{
	}

	[Token(Token = "0x600A992")]
	[Address(RVA = "0x2BA221C", Offset = "0x2BA221C", VA = "0x2BA221C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A993")]
	[Address(RVA = "0x2BA2348", Offset = "0x2BA2348", VA = "0x2BA2348")]
	public void InitData(EPDailyRewardInfo data)
	{
	}

	[Token(Token = "0x600A994")]
	[Address(RVA = "0x2BA25F8", Offset = "0x2BA25F8", VA = "0x2BA25F8")]
	private void SetButtonState()
	{
	}

	[Token(Token = "0x600A995")]
	[Address(RVA = "0x2BA28DC", Offset = "0x2BA28DC", VA = "0x2BA28DC")]
	private void OnOperateBtn()
	{
	}

	[Token(Token = "0x600A996")]
	[Address(RVA = "0x2BA2B5C", Offset = "0x2BA2B5C", VA = "0x2BA2B5C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
