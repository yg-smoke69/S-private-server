using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026FE")]
internal class UIHudCamouflageController : UIHudButtonBaseController
{
	[Token(Token = "0x400F0AC")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudCamouflageView m_View;

	[Token(Token = "0x400F0AD")]
	[FieldOffset(Offset = "0x30")]
	private bool m_GetOn;

	[Token(Token = "0x400F0AE")]
	[FieldOffset(Offset = "0x34")]
	private float m_CdTime;

	[Token(Token = "0x400F0AF")]
	[FieldOffset(Offset = "0x38")]
	private float m_LeftTime;

	[Token(Token = "0x600ECC7")]
	[Address(RVA = "0x2142DFC", Offset = "0x2142DFC", VA = "0x2142DFC")]
	public UIHudCamouflageController()
	{
	}

	[Token(Token = "0x600ECC8")]
	[Address(RVA = "0x2142E04", Offset = "0x2142E04", VA = "0x2142E04")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ECC9")]
	[Address(RVA = "0x2142EAC", Offset = "0x2142EAC", VA = "0x2142EAC", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600ECCA")]
	[Address(RVA = "0x2142F50", Offset = "0x2142F50", VA = "0x2142F50", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ECCB")]
	[Address(RVA = "0x21433C4", Offset = "0x21433C4", VA = "0x21433C4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600ECCC")]
	[Address(RVA = "0x214373C", Offset = "0x214373C", VA = "0x214373C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600ECCD")]
	[Address(RVA = "0x2143A78", Offset = "0x2143A78", VA = "0x2143A78", Slot = "33")]
	protected override void OnBtnClick()
	{
	}

	[Token(Token = "0x600ECCE")]
	[Address(RVA = "0x2143ACC", Offset = "0x2143ACC", VA = "0x2143ACC", Slot = "35")]
	protected override void OnBtnRelease()
	{
	}

	[Token(Token = "0x600ECCF")]
	[Address(RVA = "0x2143B20", Offset = "0x2143B20", VA = "0x2143B20")]
	private void OnEquipChange(object[] data)
	{
	}

	[Token(Token = "0x600ECD0")]
	[Address(RVA = "0x2143C14", Offset = "0x2143C14", VA = "0x2143C14")]
	private void OnSwitchObserver(object[] param)
	{
	}

	[Token(Token = "0x600ECD1")]
	[Address(RVA = "0x2143C7C", Offset = "0x2143C7C", VA = "0x2143C7C")]
	private void OnPlayerStateChange(object[] param)
	{
	}

	[Token(Token = "0x600ECD2")]
	[Address(RVA = "0x2143CE4", Offset = "0x2143CE4", VA = "0x2143CE4")]
	private void OnFlightRoamInfoChanged(object[] param)
	{
	}

	[Token(Token = "0x600ECD3")]
	[Address(RVA = "0x2143F78", Offset = "0x2143F78", VA = "0x2143F78")]
	private void UpdateFlightRoamIcon(object[] param)
	{
	}

	[Token(Token = "0x600ECD4")]
	[Address(RVA = "0x2143424", Offset = "0x2143424", VA = "0x2143424")]
	private void UpdateShowHide()
	{
	}

	[Token(Token = "0x600ECD5")]
	[Address(RVA = "0x214441C", Offset = "0x214441C", VA = "0x214441C")]
	private void UpdateOnOff(Player localPlayer)
	{
	}

	[Token(Token = "0x600ECD6")]
	[Address(RVA = "0x2144598", Offset = "0x2144598", VA = "0x2144598")]
	private void SetGetOn(bool getOn)
	{
	}

	[Token(Token = "0x600ECD7")]
	[Address(RVA = "0x21444B0", Offset = "0x21444B0", VA = "0x21444B0")]
	private void UpdateCdBar(Player localPlayer, GFLDMEPHOFG type)
	{
	}

	[Token(Token = "0x600ECD8")]
	[Address(RVA = "0x21432D4", Offset = "0x21432D4", VA = "0x21432D4")]
	private void HideCdBar()
	{
	}

	[Token(Token = "0x600ECD9")]
	[Address(RVA = "0x21447D4", Offset = "0x21447D4", VA = "0x21447D4")]
	private void Update()
	{
	}

	[Token(Token = "0x600ECDA")]
	[Address(RVA = "0x21446C0", Offset = "0x21446C0", VA = "0x21446C0")]
	private void ShowCdBar(float cd, float remain)
	{
	}

	[Token(Token = "0x600ECDB")]
	[Address(RVA = "0x2144C18", Offset = "0x2144C18", VA = "0x2144C18")]
	private void OnShow(object[] data)
	{
	}

	[Token(Token = "0x600ECDC")]
	[Address(RVA = "0x2144E08", Offset = "0x2144E08", VA = "0x2144E08")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ECDD")]
	[Address(RVA = "0x2144E10", Offset = "0x2144E10", VA = "0x2144E10")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600ECDE")]
	[Address(RVA = "0x2144E18", Offset = "0x2144E18", VA = "0x2144E18")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600ECDF")]
	[Address(RVA = "0x2144E20", Offset = "0x2144E20", VA = "0x2144E20")]
	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}

	[Token(Token = "0x600ECE0")]
	[Address(RVA = "0x2144E28", Offset = "0x2144E28", VA = "0x2144E28")]
	public void _003C_003EiFixBaseProxy_OnBtnRelease()
	{
	}
}
