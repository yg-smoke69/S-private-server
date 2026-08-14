using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023B5")]
public class UIStandardCDNTabItemController : UIStandardTabItemController
{
	[Token(Token = "0x20023B6")]
	public enum ETabState
	{
		[Token(Token = "0x400DE51")]
		Locked,
		[Token(Token = "0x400DE52")]
		Normal,
		[Token(Token = "0x400DE53")]
		Claimed,
		[Token(Token = "0x400DE54")]
		Updated
	}

	[Token(Token = "0x400DE4B")]
	private const string ENTER_ANIM_NAME = "UIFX_UIStandardCDNTab_In";

	[Token(Token = "0x400DE4C")]
	private new const string CLICK_ANIM_NAME = "UIFX_UIStandardCDNTab_Select";

	[Token(Token = "0x400DE4D")]
	private const string CLAIM_ANIM_NAME = "UIFX_UIStandardCDNTab_Receive";

	[Token(Token = "0x400DE4E")]
	[FieldOffset(Offset = "0x84")]
	private new UIStandardCDNTabItemView m_View;

	[Token(Token = "0x400DE4F")]
	[FieldOffset(Offset = "0x88")]
	private ETabState m_State;

	[Token(Token = "0x600C8E3")]
	[Address(RVA = "0x2063798", Offset = "0x2063798", VA = "0x2063798")]
	public UIStandardCDNTabItemController()
	{
	}

	[Token(Token = "0x600C8E4")]
	[Address(RVA = "0x20637A0", Offset = "0x20637A0", VA = "0x20637A0")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C8E5")]
	[Address(RVA = "0x2063848", Offset = "0x2063848", VA = "0x2063848", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C8E6")]
	[Address(RVA = "0x206394C", Offset = "0x206394C", VA = "0x206394C")]
	private void PlayEnterAnimation()
	{
	}

	[Token(Token = "0x600C8E7")]
	[Address(RVA = "0x2063A24", Offset = "0x2063A24", VA = "0x2063A24")]
	private void PlayClaimAniamtion()
	{
	}

	[Token(Token = "0x600C8E8")]
	[Address(RVA = "0x2063AFC", Offset = "0x2063AFC", VA = "0x2063AFC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C8E9")]
	[Address(RVA = "0x20633D0", Offset = "0x20633D0", VA = "0x20633D0")]
	public void SetTabStatus(ETabState eTabState)
	{
	}

	[Token(Token = "0x600C8EA")]
	[Address(RVA = "0x2063B88", Offset = "0x2063B88", VA = "0x2063B88", Slot = "37")]
	public override void CheckTagState()
	{
	}

	[Token(Token = "0x600C8EB")]
	[Address(RVA = "0x2063F80", Offset = "0x2063F80", VA = "0x2063F80", Slot = "40")]
	public override void CheckTipButton()
	{
	}

	[Token(Token = "0x600C8EC")]
	[Address(RVA = "0x2063FD4", Offset = "0x2063FD4", VA = "0x2063FD4")]
	public int GetWidgetWidth()
	{
		return default(int);
	}

	[Token(Token = "0x600C8ED")]
	[Address(RVA = "0x20640A0", Offset = "0x20640A0", VA = "0x20640A0")]
	public new UIWidget GetWidgetForGuide()
	{
		return null;
	}

	[Token(Token = "0x600C8EE")]
	[Address(RVA = "0x2064174", Offset = "0x2064174", VA = "0x2064174", Slot = "41")]
	protected override void PlayTabItemClickAnimation()
	{
	}

	[Token(Token = "0x600C8EF")]
	[Address(RVA = "0x2064268", Offset = "0x2064268", VA = "0x2064268", Slot = "42")]
	protected override bool HasClickAnim()
	{
		return default(bool);
	}

	[Token(Token = "0x600C8F0")]
	[Address(RVA = "0x20642C0", Offset = "0x20642C0", VA = "0x20642C0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C8F1")]
	[Address(RVA = "0x20642C8", Offset = "0x20642C8", VA = "0x20642C8")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600C8F2")]
	[Address(RVA = "0x20642D0", Offset = "0x20642D0", VA = "0x20642D0")]
	public void _003C_003EiFixBaseProxy_CheckTagState()
	{
	}

	[Token(Token = "0x600C8F3")]
	[Address(RVA = "0x20642D8", Offset = "0x20642D8", VA = "0x20642D8")]
	public void _003C_003EiFixBaseProxy_CheckTipButton()
	{
	}

	[Token(Token = "0x600C8F4")]
	[Address(RVA = "0x20642E0", Offset = "0x20642E0", VA = "0x20642E0")]
	public void _003C_003EiFixBaseProxy_PlayTabItemClickAnimation()
	{
	}

	[Token(Token = "0x600C8F5")]
	[Address(RVA = "0x20642E8", Offset = "0x20642E8", VA = "0x20642E8")]
	public bool _003C_003EiFixBaseProxy_HasClickAnim()
	{
		return default(bool);
	}
}
