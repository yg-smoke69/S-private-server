using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026F0")]
internal class UIHudBombController : UIHudButtonBaseController
{
	[Token(Token = "0x400F06D")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudBombView m_View;

	[Token(Token = "0x400F06E")]
	[FieldOffset(Offset = "0x30")]
	private string PlantBombIcon;

	[Token(Token = "0x400F06F")]
	[FieldOffset(Offset = "0x34")]
	private string RemoveBombIcon;

	[Token(Token = "0x400F070")]
	[FieldOffset(Offset = "0x38")]
	private string PlantBombHintLocTxt;

	[Token(Token = "0x400F071")]
	[FieldOffset(Offset = "0x3C")]
	private string RemoveBombHintLocTxt;

	[Token(Token = "0x400F072")]
	[FieldOffset(Offset = "0x40")]
	private bool m_NeedShow;

	[Token(Token = "0x400F073")]
	[FieldOffset(Offset = "0x41")]
	private bool m_MustHide;

	[Token(Token = "0x600EC1E")]
	[Address(RVA = "0x1E06684", Offset = "0x1E06684", VA = "0x1E06684")]
	public UIHudBombController()
	{
	}

	[Token(Token = "0x600EC1F")]
	[Address(RVA = "0x1E0672C", Offset = "0x1E0672C", VA = "0x1E0672C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EC20")]
	[Address(RVA = "0x1E067D0", Offset = "0x1E067D0", VA = "0x1E067D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EC21")]
	[Address(RVA = "0x1E06C98", Offset = "0x1E06C98", VA = "0x1E06C98", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EC22")]
	[Address(RVA = "0x1E0710C", Offset = "0x1E0710C", VA = "0x1E0710C", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600EC23")]
	[Address(RVA = "0x1E071B0", Offset = "0x1E071B0", VA = "0x1E071B0")]
	public void SetBombButtonStatus(bool isAttackSide)
	{
	}

	[Token(Token = "0x600EC24")]
	[Address(RVA = "0x1E073E8", Offset = "0x1E073E8", VA = "0x1E073E8")]
	public void OnEnterBombArea(object[] param)
	{
	}

	[Token(Token = "0x600EC25")]
	[Address(RVA = "0x1E076C4", Offset = "0x1E076C4", VA = "0x1E076C4")]
	public void OnEnterBombLevelObject(object[] param)
	{
	}

	[Token(Token = "0x600EC26")]
	[Address(RVA = "0x1E07958", Offset = "0x1E07958", VA = "0x1E07958")]
	public void OnPreparationStart(object[] data)
	{
	}

	[Token(Token = "0x600EC27")]
	[Address(RVA = "0x1E079CC", Offset = "0x1E079CC", VA = "0x1E079CC")]
	public void OnPreparationCancel(object[] data)
	{
	}

	[Token(Token = "0x600EC28")]
	[Address(RVA = "0x1E07A5C", Offset = "0x1E07A5C", VA = "0x1E07A5C")]
	public void OnPreparationEnd(object[] data)
	{
	}

	[Token(Token = "0x600EC29")]
	[Address(RVA = "0x1E07AD8", Offset = "0x1E07AD8", VA = "0x1E07AD8")]
	public void OnPlayerInvBombCountChange(object[] data)
	{
	}

	[Token(Token = "0x600EC2A")]
	[Address(RVA = "0x1E07D74", Offset = "0x1E07D74", VA = "0x1E07D74")]
	public void OnRoundChange(object[] data)
	{
	}

	[Token(Token = "0x600EC2B")]
	[Address(RVA = "0x1E07DF0", Offset = "0x1E07DF0", VA = "0x1E07DF0")]
	public void OnMustHideBombButton(object[] data)
	{
	}

	[Token(Token = "0x600EC2C")]
	[Address(RVA = "0x1E07E6C", Offset = "0x1E07E6C", VA = "0x1E07E6C")]
	public void OnPlayerDead(object[] data)
	{
	}

	[Token(Token = "0x600EC2D")]
	[Address(RVA = "0x1E07EE8", Offset = "0x1E07EE8", VA = "0x1E07EE8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EC2E")]
	[Address(RVA = "0x1E07EF0", Offset = "0x1E07EF0", VA = "0x1E07EF0")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
