using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028BB")]
public class UIHudWereWolvesInteractController : UIBaseController
{
	[Token(Token = "0x400FABC")]
	[FieldOffset(Offset = "0x28")]
	private UIHudWereWolvesInteractView m_View;

	[Token(Token = "0x400FABD")]
	[FieldOffset(Offset = "0x2C")]
	private WereWolvesInteractType m_CurType;

	[Token(Token = "0x400FABE")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsInCD;

	[Token(Token = "0x400FABF")]
	[FieldOffset(Offset = "0x34")]
	private float m_CDEndTime;

	[Token(Token = "0x400FAC0")]
	[FieldOffset(Offset = "0x38")]
	private bool m_InNotask;

	[Token(Token = "0x400FAC1")]
	[FieldOffset(Offset = "0x39")]
	private bool m_CanTaskDoInForbid;

	[Token(Token = "0x400FAC2")]
	[FieldOffset(Offset = "0x3A")]
	private bool m_IsShow;

	[Token(Token = "0x400FAC3")]
	[FieldOffset(Offset = "0x3C")]
	protected BitArrayBoolean m_IsVisibleBit;

	[Token(Token = "0x400FAC4")]
	protected const uint ISVISIBLE_TabVote = 1u;

	[Token(Token = "0x400FAC5")]
	protected const uint ISVISIBLE_Task = 2u;

	[Token(Token = "0x400FAC6")]
	protected const uint ISVISIBLE_Bunker = 4u;

	[Token(Token = "0x6010073")]
	[Address(RVA = "0x2569A00", Offset = "0x2569A00", VA = "0x2569A00")]
	public UIHudWereWolvesInteractController()
	{
	}

	[Token(Token = "0x6010074")]
	[Address(RVA = "0x2569AB0", Offset = "0x2569AB0", VA = "0x2569AB0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010075")]
	[Address(RVA = "0x2569B58", Offset = "0x2569B58", VA = "0x2569B58", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010076")]
	[Address(RVA = "0x2569E74", Offset = "0x2569E74", VA = "0x2569E74", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6010077")]
	[Address(RVA = "0x256A010", Offset = "0x256A010", VA = "0x256A010")]
	public void HideVote()
	{
	}

	[Token(Token = "0x6010078")]
	[Address(RVA = "0x256A208", Offset = "0x256A208", VA = "0x256A208")]
	private void OnShowInteract(object[] data)
	{
	}

	[Token(Token = "0x6010079")]
	[Address(RVA = "0x256A7DC", Offset = "0x256A7DC", VA = "0x256A7DC")]
	private void SetTableVoteCD()
	{
	}

	[Token(Token = "0x601007A")]
	[Address(RVA = "0x256AA44", Offset = "0x256AA44", VA = "0x256AA44")]
	private void StartCD()
	{
	}

	[Token(Token = "0x601007B")]
	[Address(RVA = "0x256A994", Offset = "0x256A994", VA = "0x256A994")]
	private void StopCD()
	{
	}

	[Token(Token = "0x601007C")]
	[Address(RVA = "0x256AAF4", Offset = "0x256AAF4", VA = "0x256AAF4")]
	private void SetCDShowContent()
	{
	}

	[Token(Token = "0x601007D")]
	[Address(RVA = "0x256AC3C", Offset = "0x256AC3C", VA = "0x256AC3C")]
	private void OnActClick()
	{
	}

	[Token(Token = "0x601007E")]
	[Address(RVA = "0x256AD84", Offset = "0x256AD84", VA = "0x256AD84")]
	private void OnTableVote()
	{
	}

	[Token(Token = "0x601007F")]
	[Address(RVA = "0x256AED0", Offset = "0x256AED0", VA = "0x256AED0")]
	private void OnTask()
	{
	}

	[Token(Token = "0x6010080")]
	[Address(RVA = "0x256A900", Offset = "0x256A900", VA = "0x256A900")]
	private void RefreshTaskBtnVisible()
	{
	}

	[Token(Token = "0x6010081")]
	[Address(RVA = "0x256B1EC", Offset = "0x256B1EC", VA = "0x256B1EC")]
	private void OnNoTask(object[] data)
	{
	}

	[Token(Token = "0x6010082")]
	[Address(RVA = "0x256AFDC", Offset = "0x256AFDC", VA = "0x256AFDC")]
	private void OnBunker()
	{
	}

	[Token(Token = "0x6010083")]
	[Address(RVA = "0x256B2E8", Offset = "0x256B2E8", VA = "0x256B2E8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6010084")]
	[Address(RVA = "0x256B348", Offset = "0x256B348", VA = "0x256B348")]
	private void UpdateCd()
	{
	}

	[Token(Token = "0x6010085")]
	[Address(RVA = "0x256A078", Offset = "0x256A078", VA = "0x256A078")]
	private void SetVisible(uint flag, bool bVisible)
	{
	}

	[Token(Token = "0x6010086")]
	[Address(RVA = "0x256B458", Offset = "0x256B458", VA = "0x256B458")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010087")]
	[Address(RVA = "0x256B460", Offset = "0x256B460", VA = "0x256B460")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
